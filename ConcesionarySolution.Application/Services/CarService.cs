using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Domain.Interfaces.Services;

namespace ConcesionarySolution.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car AddCarAsync(Car car)
        {
            //logica de negocio
            return _carRepository.AddCarAsync(car);
        }

        public bool DeleteCarAsync(int carId)
        {
            return _carRepository.DeleteCarAsync(carId);
        }

        public IEnumerable<Car> GetAllCarAsync()
        {
            var cars = _carRepository.GetAllCarAsync();
            return cars;
        }

        public bool UpdateCarAsync(int carId, Car car)
        {
            return _carRepository.UpdateCarAsync(carId, car);
        }
    }
}
