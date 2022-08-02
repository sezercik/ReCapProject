using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//UserManager userManager = new UserManager(new EfUserDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());

//User user1 = new User { FirstName = "Sezer", LastName = "Akoraler", Email = "szrakoraler@mail.com", Password = "sezer" };
//User user2 = new User { FirstName = "Ahmet", LastName = "Hamdi", Email = "hamdi_ahmet_1@hotmail.com", Password = "hamditan" };
//User user3 = new User { FirstName = "Celal", LastName = "Sönmez", Email = "sönmez111@mail.com", Password = "1sönmez1" };
//userManager.Add(user1);
//userManager.Add(user2);
//userManager.Add(user3);

//Rental rental1 = new Rental { CustomerId = 1, RentDate = DateTime.Now, CarId = 1};
//Rental rental2 = new Rental { CustomerId = 2, RentDate = DateTime.Now, CarId = 2};

//rental3 zaten eklenmiş bir araba, bu yüzden hata olarak arabanız kiralanmıştır diyor.
Rental rental3 = new Rental { CustomerId = 2, RentDate = DateTime.Now, CarId = 3};
var result = rentalManager.Add(rental3);
if(result.Success)
{
    Console.WriteLine(result.Message);
}
else
{
    Console.WriteLine(result.Message);
}
