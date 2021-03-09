using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //USER MESSAGES
        public static string UserAdded = "User added";
        public static string UserDeleted = "User deleted";
        public static string UserListed = "User listed";
        public static string UserUpdated = "User Updated";
        
        //PRODUCT MESSAGES
        public static string ProductAdded = "Product added";
        public static string ProductNameInValid = "Product name is invalid";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductListed = "Product Listed";

        //RENTAL MESSAGES
        public static string RentalAdded = "Rental added";
        public static string RentalDeleted = "Rental deleted";
        public static string RentalUpdated = "Rental updated";
        public static string RentalListed = "Rental listed";

        //CarImageMessages
        internal static string CarImageLimitExceed = "Bir arabanın en fazla 5 resmi olabilir";
    }
}
