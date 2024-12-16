using SportsStore.Models;

namespace SportsStore.DAL.Abstract
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task SaveProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task<Product> GetProductByIdAsync(int id);
        Task UpdateProductAsync(Product product);
    }
}
