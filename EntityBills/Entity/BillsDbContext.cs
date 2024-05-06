using EntityBills.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityBills.Entity
{
    public class BillsDbContext : DbContext
    {
        public BillsDbContext(DbContextOptions<BillsDbContext> options) : base(options) { }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Stay> Stays { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }


    }
}
