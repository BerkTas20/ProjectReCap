using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;




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
    

