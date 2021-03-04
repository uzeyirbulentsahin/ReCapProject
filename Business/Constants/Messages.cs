using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string EntityAdded = "Kayıt eklendi.";
        public static string EntityDeleted= "Kayıt silindi.";
        public static string EntityListed = "Kayıtlar Listelendi.";
        public static string EntityDetailListed = "Kayıtlar Listelendi.";
        public static string EntityUpdated = "Kayıt güncellendi.";
        public static string EntityCountBig5 ="Araba başına 5 resimden fazlası kabul edilemez.";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string UserRegistered="Kullanıcı kayıt edildi.";
        public static string PasswordError="Şifre Hatalı.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists="Kullanıcı zaten var.";
        public static string AccessTokenCreated="Giriş izni oluşturuldu.";
    }
}
