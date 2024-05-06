using EntityBills.Models.Domain;

namespace EntityBills.Models.DTO
{
    public class OrderDto
    {
        public DateTime OrderDate { get; set; }

        public int ItemCode { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int CostCenterId { get; set; }

        public string Name { get; set; }
    }
}
