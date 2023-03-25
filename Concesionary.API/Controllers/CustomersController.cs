using ConcesionarySolution.Application.Services;
using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concesionary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController: Controller
    {
        //Inyrccion de dependencias
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                return Ok(_customerService.GetAllCustomersAsync());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCustomer(Customer request)
        {
            return Ok(_customerService.AddCustomerAsync(request));
        }

        [HttpPut]
        [Route("UpdateCustomer/{customerId:int}")]
        public async Task<IActionResult> UpdateCustomer(int customerId, Customer request)
        {
            return Ok(_customerService.UpdateCustomerAsync(customerId, request));
        }

        [HttpDelete]
        [Route("DeleteCustomerById/{customerId:int}")]
        public async Task<IActionResult> DeleteCustomerById(int customerId)
        {
            return Ok(_customerService.DeleteCustomerAsync(customerId));
        }
    }
}
