using BlazorBills.Services.Interfaces;
using EntityBills.Models.Domain;
using EntityBills.Models.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.HttpOverrides;
using System.Runtime.CompilerServices;

namespace BlazorBills.Components.Pages
{
    public partial class Patients
    {
        [Inject]
        private IbillsService _billService {  get; set; }

        public List<PatientDto> PatientsList { get; set; } = new List<PatientDto>();

        protected override async void OnInitialized()
        {
            PatientsList = await _billService.GetPatients();
            
        }
    }
}
