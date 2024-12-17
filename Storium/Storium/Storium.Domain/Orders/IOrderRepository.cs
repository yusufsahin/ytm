using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storium.Domain.Orders
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateAsync(List<CreateOrderDto> createOrderDtos, CancellationToken cancellationToken = default);
    }
}
