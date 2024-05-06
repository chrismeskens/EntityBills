using BlazorBills.Services.Interfaces;
using EntityBills.Models.Domain;
using EntityBills.Models.DTO;
using System.Text.Json;

namespace BlazorBills.Services
{
    public class BillService : IbillsService
    {
        private readonly HttpClient _httpClient;

        public BillService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PatientDto>> GetPatients()
        {
			List<PatientDto> patients = new List<PatientDto>();
            var apiResponse = _httpClient.GetStringAsync("api/patients").GetAwaiter().GetResult();
            //string result = apiResponse.ToString();
            //atients = await JsonSerializer.DeserializeAsync<List<PatientDto>>((apiResponse);
            return patients;
        }
    }
}
