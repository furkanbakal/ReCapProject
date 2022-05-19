using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba başarıyla eklendi.";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string BrandAdded = "Marka Başarıyla eklendi.";
        public static string BrandDeleted = "Marka Başarıyla silindi.";
        public static string BrandUpdated = "Marka Başarıyla güncellendi.";
        public static string ColorAdded = "Renk başarıyla eklendi";
        public static string ColorDeleted = "Renk başarıyla silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";
        public static string CarPriceError = "HATA! Aracın günlük fiyatı 0'dan büyük olmalı";
        public static string CarNameError = "HATA! Araç açıklaması minimum 2 karakter olmalıdır!";
        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserDeleted = "Kullanıcı başarıyla silindi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";
        public static string RentalAdded = "Kiralama başarıyla eklendi";
        public static string RentalDeleted = "Kiralama başarıyla silindi";
        public static string RentalUpdated = "Kiralama başarıyla güncellendi";
        public static string ReturnDateInvalid = "Kiralama başarısız! Araç müsait değil.";
        public static string AuthorizationDenied = "Erişim yetkiniz yok! ";
        public static string UserRegistered = "Kullanıcı kayıt işlemi başarılı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Giriş işlemi başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
        public static string AccessTokenCreated = "Kullanıcı tokeni oluşturuldu.";
    }
}
