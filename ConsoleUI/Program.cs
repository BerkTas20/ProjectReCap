using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//RentalManager rentalManager = new RentalManager(new EfRentalDal());
//var result = rentalManager.Add(new Rental() { CarId = 1, CustomerId = 2, });
//Console.WriteLine(result.Message);


CarManager carManager = new CarManager(new EfCarDal());


var result = carManager.GetCarDetails();
if (result.Success)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarName);

    }
}
else
{
    Console.WriteLine(result.Message);
}

Console.WriteLine("Ekleme------------------");
carManager.Add(new Car { CarId = 5, BrandId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = 7250, CarName = "BMW 520i" });

Console.WriteLine("Güncelleme------------------");
carManager.Update(new Car { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 5750, CarName = "Mercedes E200" });

Console.WriteLine("Silme------------------");
carManager.Delete(new Car { CarId = 4, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 8250, CarName = "Honda Civ" });

