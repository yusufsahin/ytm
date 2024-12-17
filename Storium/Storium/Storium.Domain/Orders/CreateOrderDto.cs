using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storium.Domain.Orders
{
  public sealed record CreateOrderDto(Guid ProductId, int Quantity,decimal amount,string currency);
}
