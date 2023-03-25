using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Infraestructure.Persitence;

namespace ConcesionarySolution.Infraestructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ConsesionaryContext _context;
        public CarRepository(ConsesionaryContext context)
        {
           _context = context;
        }

        public Car AddCarAsync(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }

        public IEnumerable<Car> GetAllCarAsync()
        {
            try
            {
                var cars = _context.Cars
                    .ToList();
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public bool DeleteCarAsync(int carId)
        {
            var car = _context.Cars.FirstOrDefault(x => x.CarId == carId);
            if (car == null)
                return false;

            _context.Cars.Remove(car);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateCarAsync(int carId, Car car)
        {
            var carDb = _context.Cars.FirstOrDefault(x => x.CarId == carId);
            if (carDb == null)
                return false;

            carDb.Price = car.Price;
            carDb.LicensePlate = car.LicensePlate;
            carDb.Model = car.Model;
            _context.SaveChanges();

            return true;
        }
    }
}
