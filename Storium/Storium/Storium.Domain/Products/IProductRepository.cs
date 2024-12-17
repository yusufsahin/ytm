using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storium.Domain.Products
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);

        Task CreateAsync(string name, int quantity, decimal amount, string currency, Guid categoryId, CancellationToken cancellationToken = default);

    }
}
