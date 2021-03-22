using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
       
        public static string UserAdded = "User added";
        public static string UserDeleted = "User deleted";
        public static string UserListed = "User listed";
        public static string UserUpdated = "User Updated";
        
       
        public static string ProductAdded = "Product added";
        public static string ProductNameInValid = "Product name is invalid";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductListed = "Product Listed";

      
        public static string RentalAdded = "Rental added";
        public static string RentalDeleted = "Rental deleted";
        public static string RentalUpdated = "Rental updated";
        public static string RentalListed = "Rental listed";

        
        public static string CarImageLimitExceed = "Bir arabanın en fazla 5 resmi olabilir";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Paralo hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Access Token Oluşturuldu.";
    }
}
