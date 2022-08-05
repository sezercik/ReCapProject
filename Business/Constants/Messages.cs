using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        //General Strings
        public static string MaintenanceTime = "Bakım Gerçekleştiriliyor";
        //Car Strings
        public static string CarAdded = "Araba Eklendi";
        public static string CarUpdated = "Araba Detayları Güncellendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarListedById = "Araba Getirildi";
        public static string CarDetailsListed = "Araba Detayları Getirildi";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarsListedByBrand = "Arabalar Markaya Göre Listelendi";
        public static string CarsListedByColor = "Arabalar Renge Göre Listelendi";
        public static string CarNameAndPriceError = "Araba ismi minimum 2 karakter olmalı ve Günlük Fiyatı sıfırdan büyük olmalı";

        //Brand Strings
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Detayları Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListedById = "Marka Getirildi";
        public static string BrandsListed = "Markalar Listelendi";

        //Color Strings
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorUpdated = "Renk Detayları Güncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListedById = "Renk Getirildi";
        public static string ColorsListed = "Renk Listelendi";

        //User Strings
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserUpdated = "Kullanıcı Detayları Güncellendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserListedById = "Kullanıcı Getirildi";
        public static string UsersListed = "Kullanıcı Listelendi";

        //Customer Strings
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerUpdated = "Müşteri Detayları Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerListedById = "Müşteri Getirildi";
        public static string CustomersListed = "Müşteri Listelendi";

        //Rental Strings
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalUpdated = "Kiralama Detayları Güncellendi";
        public static string RentalDeleted = "Kiralama işlemi Silindi";
        public static string RentalListedById = "Kiralama işlemi Getirildi";
        public static string RentalsListed = "Kiralama işlemleri Listelendi";
        public static string RentalCarHired = "Kiralamak istediğiniz araba zaten kiralanmış";

        //Car image Strings
        public static string CarImageLimitExceeded = "Arabanın en fazla 5 resmi olabilir";
        public static string CarImagesAdded = "Araba Resimleri Eklenmiştir";
        public static string CarImagesNotAdded = "Araba Resimleri Eklenememiştir";
        public static string CarImageDeleted = "Araba resmi silinmiştir";
        public static string CarImageUpdated = "Araba resmi güncellenmiştir";

        
    }
}
