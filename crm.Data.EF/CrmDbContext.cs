using crm.Data.Contract.Models;
using Microsoft.EntityFrameworkCore;

namespace crm.Data.EF
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext() : base()
        {

        }

        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}

