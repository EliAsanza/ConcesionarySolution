using ConcesionarySolution.Application.Services;
using ConcesionarySolution.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConcesionarySolution.Application.Configuration
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            #region Services
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IRevisionService, RevisionService>();
            services.AddTransient<ISaleService, SaleService>();
            #endregion

            return services;
        }
    }
}
