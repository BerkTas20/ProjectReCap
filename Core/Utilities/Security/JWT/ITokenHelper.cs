using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim>operationClaims);
    }
    //kullanıcı adı ve parola girilecek sonra butona basılacak
    //Burada bu operasyon çalışacak doğruysa.İlgili kullanıcı için
    //veri tabanına gidecek  , kullanıcının claimini bulup oluşturacak
    //json web token üretecek.
}
