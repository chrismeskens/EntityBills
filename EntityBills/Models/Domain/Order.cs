namespace EntityBills.Models.Domain
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int StayId { get; set; }

        public Stay Stay { get; set; }
        
    }
}
