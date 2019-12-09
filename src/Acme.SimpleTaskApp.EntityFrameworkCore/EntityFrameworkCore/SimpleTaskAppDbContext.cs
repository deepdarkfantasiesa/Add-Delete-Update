using Abp.EntityFrameworkCore;
using Acme.SimpleTaskApp.Tasks;
using Microsoft.EntityFrameworkCore;
using Acme.SimpleTaskApp.Workers;
using Acme.SimpleTaskApp.Customers;

namespace Acme.SimpleTaskApp.EntityFrameworkCore
{
    public class SimpleTaskAppDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<SimpleTask> Tasks { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<HouseWorker> Workers { get; set; }
        
        public DbSet<Certificate> Certificates { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public SimpleTaskAppDbContext(DbContextOptions<SimpleTaskAppDbContext> options) 
            : base(options)
        {

        }
    }
}
