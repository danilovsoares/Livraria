using System.Threading;
using System.Threading.Tasks;
using Livraria.Domain.Core.Bus;
using Livraria.Domain.Core.Notifications;
using Livraria.Domain.Interfaces;
using Livraria.Domain.Livros.Commands;
using Livraria.Domain.Livros.Interfaces.Repository;
using Livraria.Domain.Livros.Models;
using MediatR;

namespace Livraria.Domain.Livros.CommandHandlers
{
    public class LivroCommandHandler : CommandHandler,
        IRequestHandler<NovoLivroCommand>,
        IRequestHandler<AtualizarLivroCommand>,
        IRequestHandler<RemoverLivroCommand>

    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMediatorHandler _bus;

        public LivroCommandHandler(ILivroRepository livroRepository, IUnitOfWork uow, IMediatorHandler bus, INotificationHandler<DomainNotification> notifications)
            : base(uow, bus, notifications)
        {
            _livroRepository = livroRepository;
            _bus = bus;
        }

        public Task Handle(NovoLivroCommand command, CancellationToken cancellationToken)
        {
            if (!command.IsValid())
            {
                NotifyValidationErrors(command);
                return Task.CompletedTask;
            }

            var livro = new Livro(command.Titulo,
                command.Descricao,
                command.Autor,
                command.Editora,
                command.NumeroEdicao,
                command.AnoEdicao,
                command.ISBN);

            _livroRepository.Add(livro);

            Commit();
            return Task.CompletedTask;
        }

        public Task Handle(AtualizarLivroCommand command, CancellationToken cancellationToken)
        {
            if (!command.IsValid())
            {
                NotifyValidationErrors(command);
                return Task.CompletedTask;
            }

            var livro = _livroRepository.GetById(command.Id);
            if (livro == null)
            {
                _bus.RaiseEvent(new DomainNotification(command.MessageType, $"Livro {command.Id} não foi encontrado na base de dados."));
                return Task.CompletedTask;
            }

            livro.AtualizarInformacoes(command.Titulo,
                command.Descricao,
                command.Autor,
                command.Editora,
                command.NumeroEdicao,
                command.AnoEdicao,
                command.ISBN);

            _livroRepository.Update(livro);

            Commit();
            return Task.CompletedTask;
        }

        public Task Handle(RemoverLivroCommand command, CancellationToken cancellationToken)
        {
            if (!command.IsValid())
            {
                NotifyValidationErrors(command);
                return Task.CompletedTask;
            }

            var livro = _livroRepository.GetById(command.Id);
            if (livro == null)
            {
                _bus.RaiseEvent(new DomainNotification(command.MessageType, $"Livro {command.Id} não existe."));
                return Task.CompletedTask;
            }

            _livroRepository.Remove(command.Id);

            Commit();
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _livroRepository.Dispose();
        }
    }
}
