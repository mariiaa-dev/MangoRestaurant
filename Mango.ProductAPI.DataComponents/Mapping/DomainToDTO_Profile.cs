using AutoMapper;
using Mango.ProductAPI.DataComponents.DTOs;
using Mango.ProductAPI.Persistence.Domains;

namespace Mango.ProductAPI.DataComponents.Mapping
{
    public class DomainToDTO_Profile : Profile
    {
        public DomainToDTO_Profile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
