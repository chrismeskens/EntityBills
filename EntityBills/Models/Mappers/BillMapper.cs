using EntityBills.Models.Domain;
using EntityBills.Models.DTO;

namespace EntityBills.Models.Mappers
{
    public class BillMapper
    {
        public static BillDto ToDto(Bill bill)
        {
            BillDto dto = new BillDto()
            {
                BillDtoId = bill.BillId,
                BillingDate = bill.BillingDate,
                AdmissionDate = bill.Stay.AdmissionDate,
                DischargeDate = bill.Stay.DischargeDate,
                Orders = OrderMapper.ToDTOS(bill.Stay.Orders),
                PatientId = bill.Stay.PatientId,
                FirstName = bill.Stay.Patient.FirstName,
                LastName = bill.Stay.Patient.LastName,
                PatientAdress = bill.Stay.Patient.PatientAdress,
                Zip = bill.Stay.Patient.ZipCode.Zip,
                City = bill.Stay.Patient.ZipCode.City,
                State = bill.Stay.Patient.ZipCode.State,
                PhoneNumbers = PhoneMapper.ToDTOS(bill.Stay.Patient.PhoneNumbers)

            };
            return dto;
        }


        public static List<BillDto> ToDtoList(List<Bill> bills) 
        {
            List<BillDto> dtos = new List<BillDto>();
            foreach (Bill bill in bills)
            {
                dtos.Add(ToDto(bill));
            }
            return dtos;
        }

    }
}
