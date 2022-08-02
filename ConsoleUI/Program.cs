using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());


Console.WriteLine("Colors");
var result = colorManager.GetAll();
if (result.Success)
{
    foreach (var color in result.Data)
    {
        Console.WriteLine(color.Name);
    }
}
else
{
    Console.WriteLine(result.Message);
}


Console.WriteLine("\n\n");
//Console.WriteLine("Id=1 Color is updated");
//Color color1 = new Color { Id = 1,Name = "Siyam"};
//colorManager.Update(color1);
// foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.Name);
//    }
//Console.WriteLine("\n\n");
//Console.WriteLine("Id=2 Color is deleted");
//Color color2 = new Color { Id = 2, Name = "Black"};
//colorManager.Delete(color2);
//foreach (var color in colorManager.GetAll())
//{
//    Console.WriteLine(color.Name);
//}
//Console.WriteLine("\n\n");
//Console.WriteLine("Color 3 is = "+colorManager.GetById(3).Name);
//Console.WriteLine("\n\n");

//Console.WriteLine("Colors End");

//Console.WriteLine("Brands");
//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.Name);
//}

//Console.WriteLine("\n\n");
//Console.WriteLine("Id=2 Brand is updated");
//Brand brand1 = new Brand { Id = 2, Name = "Lamborghini" };
//brandManager.Update(brand1);
//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.Name);
//}
//Console.WriteLine("\n\n");
//Console.WriteLine("Id=2 Brand is deleted");
//Brand brand2 = new Brand { Id = 2, Name = "Audi" };
//brandManager.Delete(brand2);
//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.Name);
//}
//Console.WriteLine("\n\n");
//Console.WriteLine("brand 3 is = " + brandManager.GetById(3).Name);
//Console.WriteLine("\n\n");

//Console.WriteLine("Brands End");
//foreach (Car car in carManager.GetAll())
//{
//    Console.WriteLine("Car ID: {0} and Car Description: {1}", car.Id, car.Description);
//}

//Console.WriteLine("Get Cars by brand id");
//foreach (Car car in carManager.GetCarsByBrandId(1))
//{
//    Console.WriteLine("Car ID: {0} and Car Description: {1}", car.Id, car.Description);
//}
//Console.WriteLine("Get Cars by color id");
//foreach (Car car in carManager.GetCarsByColorId(1))
//{
//    Console.WriteLine("Car ID: {0} and Car Description: {1}", car.Id, car.Description);
//}