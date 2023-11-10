using Mango.ProductAPI.DataComponents.DTOs;

namespace Mango.ProductAPI.DataComponents.Repositories.Interfaces
{
    internal interface IProductReposotiry
    {
        Task<IEnumerable<ProductDTO>> GetAsync();
        Task<ProductDTO> GetByIdAsync(int id);
        Task<ProductDTO> CreateUpdateAsync(ProductDTO productDTO);
        Task<bool> DeleteAsync(int id);
    }
}
