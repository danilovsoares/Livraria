using System.Collections.Generic;
using System.Linq;
using Livraria.Domain.Livros.Interfaces.Repository;
using Livraria.Domain.Livros.Models;
using Livraria.Infra.Data.Context;
using Livraria.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Data.Livros.Repository
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(LivrariaContext context)
            : base(context)
        {
        }

        public IQueryable<Livro> ObterLivrosOrdenados() =>
            DbSet.AsNoTracking().OrderBy(o => o.Titulo);
    }
}
