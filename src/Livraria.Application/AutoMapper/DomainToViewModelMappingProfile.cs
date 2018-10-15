using AutoMapper;
using Livraria.Application.Livros.AutoMapper;

namespace Livraria.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            new DomainToViewModelLivro();
        }
    }
}
