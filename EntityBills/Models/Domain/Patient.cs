namespace EntityBills.Models.Domain
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PatientAdress { get; set; }

        public int ZipCodeId { get; set; }

        public ZipCode ZipCode { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }


    }
}
