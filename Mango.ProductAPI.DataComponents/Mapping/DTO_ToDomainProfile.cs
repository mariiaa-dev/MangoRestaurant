using AutoMapper;
using Mango.ProductAPI.DataComponents.DTOs;
using Mango.ProductAPI.Persistence.Domains;

namespace Mango.ProductAPI.DataComponents.Mapping
{
    internal class DTO_ToDomainProfile : Profile
    {
        public DTO_ToDomainProfile()
        {
            CreateMap<ProductDTO, Product>();
        }
    }
}
