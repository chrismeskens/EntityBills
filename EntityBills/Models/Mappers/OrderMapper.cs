using EntityBills.Models.Domain;
using EntityBills.Models.DTO;

namespace EntityBills.Models.Mappers
{
    public class OrderMapper
    {
        public static OrderDto ToDto(Order order)
        {
            OrderDto dto = new OrderDto()
            {
                OrderDate = order.OrderDate,
                ItemCode = order.Item.ItemCode,
                Description = order.Item.Description,
                Price = order.Item.Price,
                CostCenterId = order.Item.CostCenterID,
                Name = order.Item.CostCenter.Name
            };

            return dto;
        }

        public static List<OrderDto> ToDTOS(List<Order> orders) 
        {
            List<OrderDto> OrdersDto = new List<OrderDto>();
            foreach (Order order in orders)
            {
                OrdersDto.Add(ToDto(order));
            }
            return OrdersDto;
        }
    }
}
