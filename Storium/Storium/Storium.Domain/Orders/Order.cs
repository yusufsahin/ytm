using Storium.Domain.Abstraction;
using Storium.Domain.Shared;

namespace Storium.Domain.Orders
{
    public sealed class Order : Entity
    {
        public string OrderNumber { get; private set; }
        public DateTime DateTime { get; private set; }
        public OrderStatusEnum Status { get; private set; }

        public Order(Guid id, string orderNumber, DateTime dateTime, OrderStatusEnum status) : base(id)
        {
            OrderNumber = orderNumber;
            DateTime = dateTime;
            Status = status;
        }

        public ICollection<OrderLine> OrderLines { get; private set; }= new List<OrderLine>();
        public Order(Guid id) : base(id)
        {
        }
        public void CreateOrder(List<CreateOrderDto> createOrderDtos)
        {
            foreach (var item in createOrderDtos)
            {
                if (item.Quantity < 1)
                {
                    throw new Exception("Sipariş adedi 1 den az olamaz!");
                }
                OrderLine orderLine = new(
                  Guid.NewGuid(),
                  Id,
                  item.ProductId,
                  item.Quantity,
                  new(item.Amount, Currency.FromCode(item.Currency)));

                OrderLines.Add(orderLine);
            }

        }


        // RemoveOrderLine

        public void RemoveOrderLine(Guid orderLineId)
        {
            var orderLine = OrderLines.FirstOrDefault(x => x.Id == orderLineId);
            if (orderLine is null)
            {
                throw new Exception("Silmek istediğiniz sipariş kalemi bulunamadı!");
            }
            OrderLines.Remove(orderLine);
        }


    }
}
