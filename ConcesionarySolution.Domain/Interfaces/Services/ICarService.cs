
using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCarAsync();
        Car AddCarAsync(Car car);
        bool UpdateCarAsync(int carId, Car car);
        bool DeleteCarAsync(int carId);
    }
}
