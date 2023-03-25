using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomersAsync();
        Customer AddCustomerAsync(Customer customer);
        bool UpdateCustomerAsync(int customerId, Customer customer);
        bool DeleteCustomerAsync(int customerId);
    }
}
