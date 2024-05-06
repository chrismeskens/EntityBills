using EntityBills.Entity;
using EntityBills.Models.Domain;
using EntityBills.Models.DTO;
using EntityBills.Models.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace EntityBills.Service
{
    public class BillingService
    {
        private readonly BillsDbContext _context;

        public BillingService(BillsDbContext context)
        {
            _context = context;
        }

        public List<Patient>GetPatients()
        {
            return _context.Patients.Include(z=>z.ZipCode).Include(p=>p.PhoneNumbers).ToList();
        }

        public List<Item> GetItems()
        {
            return _context.Items.Include(c=>c.CostCenter).ToList();
        }

        public List<CostCenter> GetCostCenters()
        {
            return _context.CostCenters.Include(i=>i.Items).ToList();
        }

        public List<Bill> GetBills() 
        {
            return _context.Bills.Include(s=>s.Stay).ThenInclude(s => s.Patient).ThenInclude(p=>p.ZipCode)
                                 .Include(s=>s.Stay).ThenInclude(p=>p.Patient).ThenInclude(p=>p.PhoneNumbers)
                                 .Include(s=>s.Stay).ThenInclude(o=>o.Orders).ThenInclude(i=>i.Item).ThenInclude(c=>c.CostCenter).ToList();
        }


        public Item CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

    }
}
