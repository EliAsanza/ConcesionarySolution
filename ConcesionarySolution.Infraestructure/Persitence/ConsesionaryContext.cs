using Microsoft.EntityFrameworkCore;
using ConcesionarySolution.Domain.Entities;
using System.Reflection;
using ConcesionarySolution.Infraestructure.Repositories;

namespace ConcesionarySolution.Infraestructure.Persitence
{
    public class ConsesionaryContext : DbContext
    {
        public ConsesionaryContext(DbContextOptions<ConsesionaryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Revision> Revisions { get; set; }

        
    }
}