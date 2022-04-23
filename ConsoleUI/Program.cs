using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;




CarManager carManager = new CarManager(new EfCarDal());
foreach ( var  car in carManager.GetAll())
{
    Console.WriteLine(car.CarName);
    
}
