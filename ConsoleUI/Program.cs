using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (Car car in carManager.GetAll())
{
    Console.WriteLine("Car ID: {0} and Car Description: {1}",car.CarId,car.Description);
}