using Livraria.Domain.Interfaces;
using Livraria.Domain.Livros.Models;
using System.Linq;

namespace Livraria.Domain.Livros.Interfaces.Repository
{
    public interface ILivroRepository : IRepository<Livro>
    {
        IQueryable<Livro> ObterLivrosOrdenados();
    }
}
