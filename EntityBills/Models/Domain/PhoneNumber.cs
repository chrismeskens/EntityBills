namespace EntityBills.Models.Domain
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }

        public int Number { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

    }
}
