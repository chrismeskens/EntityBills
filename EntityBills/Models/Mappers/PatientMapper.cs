using EntityBills.Models.Domain;
using EntityBills.Models.DTO;

namespace EntityBills.Models.Mappers
{
	public class PatientMapper
	{
		public static PatientDto ToDto(Patient patient)
		{
			DTO.PatientDto dto = new DTO.PatientDto()
			{
				PatientId = patient.PatientId,
				FirstName = patient.FirstName,
				LastName = patient.LastName,
				PatientAdress = patient.PatientAdress,
			};
			return dto;
		}

		public static List<PatientDto> ToListPatients(List<Patient> patients)
		{
			List<PatientDto> dtos = new List<PatientDto>();
			foreach (var patient in patients)
			{
				dtos.Add(PatientMapper.ToDto(patient));
			}
			return dtos;
		}

	}
}
