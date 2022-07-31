using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());

//Car car1 = new Car{BrandId = 1, ColorId = 2, DailyPrice = 153234, ModelYear = 2012, Description = "Perfect car" };
//Car car2 = new Car{BrandId = 2, ColorId = 5, DailyPrice = 1543234, ModelYear = 2022, Description = "Great car" };
//Car car3 = new Car{BrandId = 1, ColorId = 4, DailyPrice = 113234, ModelYear = 2016, Description = "From the doctor" };
//carManager.Add(car1);
//carManager.Add(car2);
//carManager.Add(car3);

////Add Color
//Color color1 = new Color { Name = "White" };
//Color color2 = new Color { Name = "Black" };
//Color color3 = new Color { Name = "Gray" };
//Color color4 = new Color { Name = "Green" };
//Color color5 = new Color { Name = "Red" };
//colorManager.Add(color1);
//colorManager.Add(color2);
//colorManager.Add(color3);
//colorManager.Add(color4);
//colorManager.Add(color5);

//////Add Brand
//Brand brand1 = new Brand { Name = "BMW" };
//Brand brand2 = new Brand { Name = "Audi" };
//Brand brand3 = new Brand { Name = "Mercedes" };
//brandManager.Add(brand1);
//brandManager.Add(brand2);
//brandManager.Add(brand3);

foreach (Car car in carManager.GetAll())
{
    Console.WriteLine("Car ID: {0} and Car Description: {1}", car.Id, car.Description);
}

Console.WriteLine("Get Cars by brand id");
foreach (Car car in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine("Car ID: {0} and Car Description: {1}", car.Id, car.Description);
}
Console.WriteLine("Get Cars by color id");
foreach (Car car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine("Car ID: {0} and Car Description: {1}", car.Id, car.Description);
}