using Livraria.Domain.Core.Bus;
using Livraria.Domain.Core.Notifications;
using Livraria.Domain.Interfaces;
using Livraria.Domain.Livros.CommandHandlers;
using Livraria.Domain.Livros.Interfaces.Repository;
using Moq;
using System;
using System.Threading;
using Test.Stub.Livros.Commands;
using Test.Stub.Livros.Models;
using Xunit;

namespace Test.Domain.Livros.Commands
{
    public class RemoverLivroCommandTest
    {
        private Mock<IMediatorHandler> bus;
        private Mock<ILivroRepository> livroRepository;
        private Mock<IUnitOfWork> uow;
        private Mock<DomainNotificationHandler> notifications;

        public RemoverLivroCommandTest()
        {
            bus = new Mock<IMediatorHandler>();
            livroRepository = new Mock<ILivroRepository>();
            uow = new Mock<IUnitOfWork>();
            notifications = new Mock<DomainNotificationHandler>();
        }

        [Fact, Trait("Command", "Command/Livro/RemoverLivroCommand")]
        public void Command_Valido_Nao_Deve_Exibir_Erro()
        {
            var command = RemoverLivroCommandOverride.RemoverLivroCommand();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.True(validationResult.Errors.Count == default(int));
        }

        [Fact, Trait("Command", "Command/Livro/RemoverLivroCommand")]
        public void Command_Com_ID_NULL_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = RemoverLivroCommandOverride.RemoverLivroCommandComIdNULL();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("Id"));
        }

        [Fact, Trait("Command", "Command/Livro/RemoverLivroCommand")]
        public void Command_Com_Id_De_Um_Livro_Existente_Nao_Deve_Exibir_Erro()
        {
            livroRepository
              .Setup(x => x.GetById(It.IsAny<Guid>()))
              .Returns(LivroStub.Livro());

            var removerLivroCommand = RemoverLivroCommandOverride.RemoverLivroCommand();
            CancellationToken cancellationToken = new CancellationToken();

            var commandHandler = new LivroCommandHandler(livroRepository.Object, uow.Object, bus.Object, notifications.Object);
            commandHandler.Handle(removerLivroCommand, cancellationToken);

            bus.Verify(x => x.RaiseEvent(It.Is<DomainNotification>(m => m.Key == "RemoverLivroCommand")), Times.Never());
        }

        [Fact, Trait("Command", "Command/Livro/RemoverLivroCommand")]
        public void Command_Com_Id_De_Um_Livro_Nao_Existente_Deve_Exibir_Erro()
        {
            livroRepository
              .Setup(x => x.GetById(It.IsAny<Guid>()))
              .Returns<LivroStub>(null);

            var removerLivroCommand = RemoverLivroCommandOverride.RemoverLivroCommand();
            CancellationToken cancellationToken = new CancellationToken();

            var commandHandler = new LivroCommandHandler(livroRepository.Object, uow.Object, bus.Object, notifications.Object);
            commandHandler.Handle(removerLivroCommand, cancellationToken);

            bus.Verify(x => x.RaiseEvent(It.Is<DomainNotification>(m => m.Key == "RemoverLivroCommand")), Times.AtLeastOnce());
        }
    }
}
