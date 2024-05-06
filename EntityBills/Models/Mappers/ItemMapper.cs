using EntityBills.Models.Domain;
using EntityBills.Models.DTO;

namespace EntityBills.Models.Mappers
{
    public class ItemMapper
    {
        public static Item ToDomain(ItemDto itemdto)
        {
            Item item = new Item()
            {
                ItemId = itemdto.ItemId,
                ItemCode = itemdto.ItemCode,
                Description = itemdto.Description,
                Price = itemdto.Price,
                CostCenterID = itemdto.CostCenterID,
            };

            return item;
        }
    }
}
