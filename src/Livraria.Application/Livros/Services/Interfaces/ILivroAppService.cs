using Livraria.Application.Livros.ViewModels.Request;
using Livraria.Application.Livros.ViewModels.Response;
using System;
using System.Collections.Generic;

namespace Livraria.Application.Livro.Services.Interfaces
{
    public interface ILivroAppService : IDisposable
    {
        void Save(SalvarLivroViewModel livro);
        IEnumerable<LivroViewModel> GetAll();
        LivroViewModel GetById(Guid id);
        void Update(AtualizarLivroViewModel livro);
        void Remove(Guid id);
    }
}
