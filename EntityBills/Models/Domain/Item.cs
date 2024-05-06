namespace EntityBills.Models.Domain
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ItemCode { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int CostCenterID { get; set; }

        public CostCenter CostCenter { get; set; }

    }
}
