using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>>GetCarsByBrandId(int brandId);
        IDataResult<List<Car>>GetCarsByColorId(int colorId);
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult AddTransactionalTest(Car car);
        //Uygulamada tutarlılığı korumak için.
        //Örneğin ; benim hesabımda 100 lira para var.Keremin hesabına 10 tl aktaracağım.
        //bu benim hesabımın 10 tl düşecek şekilde update edilmesi anlamına geliyor.
        //keremin de hesabının 10 lira artacak şekilde update edilmesi gerekiyor.
        //Yani iki tane veritabanı işlemi var.Benim hesabım güncellenirken keremin hesabı hata verdi.
        //işlemin bu sefer geri alınması gerekiyor.
    }
}
