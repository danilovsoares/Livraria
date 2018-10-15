using AutoMapper;
using Livraria.Application.Livros.ViewModels.Request;
using Livraria.Domain.Livros.Commands;

namespace Livraria.Application.Livros.AutoMapper
{
    public class ViewModelToDomainLivro : Profile
    {
        public ViewModelToDomainLivro()
        {
            CreateMap<SalvarLivroViewModel, NovoLivroCommand>();
            CreateMap<AtualizarLivroViewModel, AtualizarLivroCommand>();
        }
    }
}
