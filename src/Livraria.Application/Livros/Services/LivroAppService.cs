using AutoMapper;
using Livraria.Application.Livro.Services.Interfaces;
using Livraria.Application.Livros.ViewModels.Request;
using Livraria.Application.Livros.ViewModels.Response;
using Livraria.Domain.Core.Bus;
using Livraria.Domain.Livros.Commands;
using Livraria.Domain.Livros.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Livraria.Application.Livros.Services
{
    public class LivroAppService : ILivroAppService
    {
        private readonly IMapper _mapper;
        private readonly ILivroRepository _livroRepository;
        private readonly IMediatorHandler _bus;

        public LivroAppService(IMapper mapper,
                                  ILivroRepository livroRepository,
                                  IMediatorHandler bus)
        {
            _mapper = mapper;
            _livroRepository = livroRepository;
            _bus = bus;
        }

        public IEnumerable<LivroViewModel> GetAll() =>
             _mapper.Map<IEnumerable<LivroViewModel>>(_livroRepository.ObterLivrosOrdenados());

        public LivroViewModel GetById(Guid id) =>
            _mapper.Map<LivroViewModel>(_livroRepository.GetById(id));

        public void Remove(Guid id)
        {
            var removerLivroCommand = new RemoverLivroCommand(id);
            _bus.SendCommand(removerLivroCommand);
        }

        public void Save(SalvarLivroViewModel livro)
        {
            var novoLivroCommand = _mapper.Map<NovoLivroCommand>(livro);
            _bus.SendCommand(novoLivroCommand);
        }

        public void Update(AtualizarLivroViewModel livro)
        {
            var atualizarLivroCommand = _mapper.Map<AtualizarLivroCommand>(livro);
            _bus.SendCommand(atualizarLivroCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
