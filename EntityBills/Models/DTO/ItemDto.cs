using EntityBills.Models.Domain;

namespace EntityBills.Models.DTO
{
    public class ItemDto
    {
        public int ItemId { get; set; }
        public int ItemCode { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int CostCenterID { get; set; }
    }
}
