using EntityBills.Models.Domain;

namespace EntityBills.Models.DTO
{
    public class BillDto
    {
        public int BillDtoId { get; set; }

        public DateTime BillingDate { get; set; }

        public DateTime AdmissionDate { get; set; }

        public DateTime DischargeDate { get; set; }

        public List<OrderDto> Orders { get; set; }

        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PatientAdress { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public List<PhoneNumberDTo> PhoneNumbers { get; set; }
    }
}
