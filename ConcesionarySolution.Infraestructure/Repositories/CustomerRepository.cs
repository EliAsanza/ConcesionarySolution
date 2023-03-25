using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Infraestructure.Persitence;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarySolution.Infraestructure.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ConsesionaryContext _context;
        public CustomerRepository(ConsesionaryContext context)
        {
            _context = context;
        }

        public Customer AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomerAsync()
        {
            try
            {
                var customers = _context.Customers.ToList();
                return customers;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public bool DeleteCustomerAsync(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
            if (customer == null)
                return false;

            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return true;
        }

        
        public bool UpdateCustomerAsync(int customerId, Customer customer)
        {
            var customerDb = _context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
            if (customerDb == null)
                return false;

            customerDb.City = customer.City;
            customerDb.Address = customer.Address;
            customerDb.Phone= customer.Phone;
            _context.SaveChanges();

            return true;
        }
    }
}
