using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Repositories
{
    public  interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomerAsync();
        Customer AddCustomerAsync(Customer customer);
        bool UpdateCustomerAsync(int customerId, Customer customer);
        bool DeleteCustomerAsync(int customerId);
    }
}
