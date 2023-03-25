using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concesionary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : Controller
    {
        //Inyrccion de dependencias
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            try
            {
                return Ok(_carService.GetAllCarAsync());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCar(Car request)
        {
            return Ok(_carService.AddCarAsync(request));
        }

        [HttpPut]
        [Route("UpdateCar/{carId:int}")]
        public async Task<IActionResult> UpdateCar(int carId, Car request)
        {
            return Ok(_carService.UpdateCarAsync(carId, request));
        }

        [HttpDelete]
        [Route("DeleteCarById/{carId:int}")]
        public async Task<IActionResult> DeleteCarById(int carId)
        {
            return Ok(_carService.DeleteCarAsync(carId));
        }

    }
}
