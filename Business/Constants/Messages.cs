using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç durumu güncellendi";

        public static string CarImageAdded = "Araç resmi başarıyla yüklendi";
        public static string CarImageDeleted = "Araç resmi başarıyla silindi";
        public static string CarImageUpdated = "Araç resmi başarıyla güncellendi";

        public static string UserAlreadyExist = "Kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
    }
}
