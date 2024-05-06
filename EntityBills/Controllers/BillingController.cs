using EntityBills.Models.Domain;
using EntityBills.Models.DTO;
using EntityBills.Models.Mappers;
using EntityBills.Service;
using Microsoft.AspNetCore.Mvc;

namespace EntityBills.Controllers
{
    [ApiController]
    [Route ("api")]
    public class BillingController : Controller
    {
        private readonly BillingService _billingService;

        public BillingController(BillingService billingService)
        {
            _billingService = billingService;
        }

        [HttpGet("patients")]
        public IActionResult GetPatients()
        {
            return Ok(PatientMapper.ToListPatients(_billingService.GetPatients()));
        }

        [HttpGet("items")]
        public IActionResult GetItems()
        {
            return Ok(_billingService.GetItems());
        }

        [HttpGet("costcenters")]
        public IActionResult GetCostcenters()
        {
            return Ok(_billingService.GetCostCenters());
        }

        [HttpGet("bills")]
        public IActionResult GetBills()
        {
            return Ok(BillMapper.ToDtoList(_billingService.GetBills()));
        }

        [HttpPost("newItem")]
        public IActionResult CreateItem(ItemDto itemDto)
        {
            Item newItem = _billingService.CreateItem(ItemMapper.ToDomain(itemDto));
            return Created($"{newItem.ItemId}",newItem);
        }

    }
}
