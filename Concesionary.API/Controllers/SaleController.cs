using ConcesionarySolution.Application.Services;
using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concesionary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController: Controller
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSales() 
        {
            try
            {
                return Ok(_saleService.GetAllSaleAsync());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSale(Sale request)
        {
            return Ok(_saleService.AddSaleAsync(request));

        }



    }
}
