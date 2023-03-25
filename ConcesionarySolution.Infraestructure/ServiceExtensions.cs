using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Infraestructure.Persitence;
using ConcesionarySolution.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConcesionarySolution.Infraestructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ConsesionaryContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ConsesionaryContext).Assembly.FullName)));

            #region Repositories
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<ISaleRepository, SaleRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IRevisionRepository, RevisionRepository>();
            #endregion

            return services;
        }
    }
}
