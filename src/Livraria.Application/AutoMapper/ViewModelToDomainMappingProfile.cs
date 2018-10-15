using AutoMapper;
using Livraria.Application.Livros.AutoMapper;

namespace Livraria.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            new ViewModelToDomainLivro();
        }
    }
}
