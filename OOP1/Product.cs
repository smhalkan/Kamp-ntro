using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //snippet - hazır kodlar demek . tab tab tuşuna iki kere basıldığında hızlıca tanımlar
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitsInStock { get; set; }


        //CRUD operasyonları e ticaret sitelerinde ürün ekleme silme güncelleme vb operasyonlarıdır.
    }
}
