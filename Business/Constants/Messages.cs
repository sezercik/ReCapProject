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
        public static string CarDeleted = "Araba Kaldırıldı";
        public static string CarListedById = "Araba Getirildi";
        public static string CarDetailsListed = "Araba Detayları Getirildi";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarsListedByBrand = "Arabalar Markaya Göre Listelendi";
        public static string CarsListedByColor = "Arabalar Renge Göre Listelendi";
        public static string CarNameAndPriceError = "Araba ismi minimum 2 karakter olmalı ve Günlük Fiyatı sıfırdan büyük olmalı";

        //Brand Strings
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Detayları Güncellendi";
        public static string BrandDeleted = "Marka Kaldırıldı";
        public static string BrandListedById = "Marka Getirildi";
        public static string BrandsListed = "Markalar Listelendi";

        //Color Strings
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorUpdated = "Renk Detayları Güncellendi";
        public static string ColorDeleted = "Renk Kaldırıldı";
        public static string ColorListedById = "Renk Getirildi";
        public static string ColorsListed = "Renk Listelendi";

    }
}
