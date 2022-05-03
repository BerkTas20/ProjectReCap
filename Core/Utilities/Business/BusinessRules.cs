using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params verirsek run metodu içerisinde istediğim kadar parametre olarak IResult verebiliyorum.Sonra da bu parametreler array haline getiriliğ logicse atanıyor.
        {
            foreach (var logic in logics) //iş kurallarını döndürdüm.Tüm kurallar başarılıysa null döner.
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
