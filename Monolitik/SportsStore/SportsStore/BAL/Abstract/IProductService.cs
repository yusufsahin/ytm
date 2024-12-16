using SportsStore.Dtos;

namespace SportsStore.BAL.Abstract
{
    public interface IProductService
    {

        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task SaveProductAsync(ProductDto product);
        Task DeleteProductAsync(int id);
        Task<ProductDto> GetProductByIdAsync(int id);
        Task UpdateProductAsync(ProductDto product);
    }
}
