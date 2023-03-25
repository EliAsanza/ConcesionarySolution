using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Domain.Interfaces.Services;
using ConcesionarySolution.Infraestructure.Repositories;

namespace ConcesionarySolution.Application.Services
{
    public class CustomerService : ICustomerService
    {
        //al servicio le inyecto la dependencia del repository

        private readonly ICustomerRepository _customerRepositoy;

        public CustomerService(ICustomerRepository customerRepositoy)
        {
            _customerRepositoy= customerRepositoy;
        }

        public Customer AddCustomerAsync(Customer customer)
        {
            //logica de negocio
            return _customerRepositoy.AddCustomerAsync(customer);
        }

        public bool DeleteCustomerAsync(int customerId)
        {
            return _customerRepositoy.DeleteCustomerAsync(customerId);
        }

        public IEnumerable<Customer> GetAllCustomersAsync()
        {
            var customers = _customerRepositoy.GetAllCustomerAsync();
            return customers;
        }

        public bool UpdateCustomerAsync(int customerId, Customer customer)
        {
            return _customerRepositoy.UpdateCustomerAsync(customerId, customer);
        }
    }
}
