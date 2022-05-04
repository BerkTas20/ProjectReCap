using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba başarıyla eklendi";
        public static string CarDeleted = "Araba başarıyla  silindi";
        public static string CarUpdated = "Araba başarıyla güncellendi";
        public static string CarNameInvalid = "Araba isim formatına uymuyor";
        public static string CarPriceInvalid = "Araba fiyat formatına uymuyor!";
        public static string CarPriceAndNameInvalid = "Araba isim ve fiyat formatına uymuyor!";
        public static string CarsListedWithDetails = "Arabalar detaylarıyla listelendi";
        public static string CarsListed = "Arabalar listelendi";
        public const string ThisCarHasNotBeenReturnedYet = "Bu araba henüz teslim edilmedi";
        public const string TheImageLimitForThisCarHasBeenExceeded = "Bu araba için daha fazla resim ekleyemezsin";


        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandDeleted = "Marka başarıyla silindi";
        public static string BrandUpdated = "Araba başarıyla güncellendi";

        public static string ColorAdded = "Renk başarıyla  eklendi";
        public static string ColorDeleted = "Renk başarıyla  silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";
       

        public static string RentalAdded = "Kiralama işlemi başarıyla eklendi";
        public static string RentalDeleted = "Kiralama işlemi başarıyla silindi";
        public static string RentalUpdated = "Kiralama işlemi başarıyla güncellendi";
        public static string RentalAddingFailed = "Araba şu anda kiralanamaz";

        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";


        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";

    }
}
