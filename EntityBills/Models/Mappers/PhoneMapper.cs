using EntityBills.Models.Domain;
using EntityBills.Models.DTO;

namespace EntityBills.Models.Mappers
{
    public class PhoneMapper
    {
        public static PhoneNumberDTo ToDto(PhoneNumber phoneNumber)
        {
            PhoneNumberDTo numberDTo = new PhoneNumberDTo()
            {
                Number = phoneNumber.Number,
            };
            return numberDTo;
        }

        public static List<PhoneNumberDTo> ToDTOS(List<PhoneNumber> phoneNumbers) 
        {
            List<PhoneNumberDTo> phoneNumberDTos = new List<PhoneNumberDTo>();
            foreach (PhoneNumber phoneNumber in phoneNumbers)
            {
                phoneNumberDTos.Add(ToDto(phoneNumber));
            }
            return phoneNumberDTos;
        }


    }
}
