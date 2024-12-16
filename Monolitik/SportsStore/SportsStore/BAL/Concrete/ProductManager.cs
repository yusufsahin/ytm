using SportsStore.BAL.Abstract;
using SportsStore.Dtos;

namespace SportsStore.BAL.Concrete
{
    public class ProductManager : IProductService
    {
        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProductsAsync()
        {

            List<ProductDto> products = new List<ProductDto>();
            products.Add(new ProductDto { Id = 1, Name = "Kayak", Description = "A boat for one person", Price = 275, Category = "Watersports" });
            products.Add(new ProductDto { Id = 2, Name = "Lifejacket", Description = "Protective and fashionable", Price = 48.95m, Category = "Watersports" });

            return Task.FromResult(products.AsEnumerable());
        }

        public Task SaveProductAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
