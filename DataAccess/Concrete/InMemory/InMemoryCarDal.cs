using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:IProductDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 87593, ModelYear = 2005,
                    Description = "Awesome car, no painting, no crush."
                },
                new Car
                {
                    CarId = 2, BrandId = 1, ColorId = 4, DailyPrice = 1234123, ModelYear = 2020,
                    Description = "You can't find another one like this."
                },
                new Car
                {
                    CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 107593, ModelYear = 2015,
                    Description = "From the doctor"
                },
                new Car
                {
                    CarId = 4, BrandId = 2, ColorId = 1, DailyPrice = 154930, ModelYear = 2010,
                    Description = "One word 'Clean' "
                },
                new Car
                {
                    CarId = 5, BrandId = 3, ColorId = 1, DailyPrice = 90544, ModelYear = 2009,
                    Description = "Nothing to say"
                }
            };
        }


        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdated = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdated.BrandId = car.BrandId;
            carToUpdated.ColorId = car.ColorId;
            carToUpdated.Description = car.Description;
            carToUpdated.DailyPrice = car.DailyPrice;
            carToUpdated.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDeleted = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDeleted);
        }
    }
}
