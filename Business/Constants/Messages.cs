using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants//sabitler
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 adaet ürün bulunabilir ";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün bulunmaktadır ";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için teni ürün eklenemiyor";
    }
}
