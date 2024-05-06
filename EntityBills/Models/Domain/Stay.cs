namespace EntityBills.Models.Domain
{
    public class Stay
    {
        public int StayId { get; set; }       

        public DateTime AdmissionDate { get; set; }

        public DateTime DischargeDate { get; set; }

        public List<Order> Orders { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

    }
}
