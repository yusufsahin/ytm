using SportsStore.DAL.Abstract;
using SportsStore.Models;

namespace SportsStore.DAL.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
