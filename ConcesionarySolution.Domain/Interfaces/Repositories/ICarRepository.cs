using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCarAsync();
        Car AddCarAsync(Car car);
        bool UpdateCarAsync(int carId, Car car);
        bool DeleteCarAsync(int carId);


    }
}
