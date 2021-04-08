using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Eklendi.";
   
        public static string Listed = "Listelendi.";

        public static string Deleted = "Silindi";

        public static string Updated = "Güncellendi.";
        public static string CarImageLimitExceeded="Resim Limiti Aşıldı.";
        public static string CarCheckImageLimited="Resim limiti aşıldı.";
        public static string CarImageDeleted="Araba Resim silindi";
        public static string CarImageAdded="Araba Resim Eklendi";
        public static string ImageLimitExceeded="Resim Limiti aşıldı";
        public static string CarImageUpdated = "Car resmi güncellendi.";
        public static string AuthorizationDenied ="Yetkin bulunmadı.";
        public static string CarCountOfBrandError="Marka Hatası.";
        public static string CarNameAlreadyExists="Araba ismi zaten var";
        public static string BrandLimitExceded="Marka limiti aşıldı";
    }
}
