using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storium.Domain.Orders
{
    public interface IOrderRepository
    {
        public interface IOrderRepository
        {
            Task<Order> CreateAsync(List<CreateOrderDto> createOrderDtos, CancellationToken cancellationToken = default);
            Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
        }
    }
}
