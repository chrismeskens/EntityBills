using EntityBills.Models.Domain;
using EntityBills.Models.DTO;

namespace BlazorBills.Services.Interfaces
{
    public interface IbillsService
    {
        public Task<List<PatientDto>> GetPatients();
    }
}
