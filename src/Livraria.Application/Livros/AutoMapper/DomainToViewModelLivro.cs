using AutoMapper;
using Livraria.Application.Livros.ViewModels.Response;

namespace Livraria.Application.Livros.AutoMapper
{
    public class DomainToViewModelLivro : Profile
    {
        public DomainToViewModelLivro()
        {
            CreateMap<Domain.Livros.Models.Livro, LivroViewModel>();
        }
    }
}
