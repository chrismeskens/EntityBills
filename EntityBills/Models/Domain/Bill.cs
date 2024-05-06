

namespace EntityBills.Models.Domain
{
    public class Bill
    {
        public int BillId { get; set; }

        public DateTime BillingDate { get; set; }

        public int StayId { get; set; }

        public Stay Stay { get; set; }

        public int Total {  get; set; }

    }
}
