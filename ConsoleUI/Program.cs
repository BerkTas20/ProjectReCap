using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach ( var  car in carManager.GetAll())
{
    Console.WriteLine(car.BrandId);
    
}
