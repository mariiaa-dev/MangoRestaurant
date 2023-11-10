using Mango.ProductAPI.DataComponents.DTOs;
using Mango.ProductAPI.DataComponents.Repositories.Interfaces;

namespace Mango.ProductAPI.DataComponents.Repositories
{
    internal class ProductRepository : IProductReposotiry
    {
        public Task<ProductDTO> CreateUpdateAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
