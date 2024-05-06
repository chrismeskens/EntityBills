namespace EntityBills.Models.Domain
{
    public class CostCenter
    {
        public int CostCenterId { get; set; }

        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
