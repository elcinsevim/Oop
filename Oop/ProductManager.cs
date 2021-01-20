using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ürünle ilgili operasyon ekleme,silme,listeme vb.
    {
        //encapsulation
        public void Add( Product product)
        {
            Console.WriteLine(product.ProductName+"eklendi");
        }
        public void Updata(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }
        //void -bir bilgiye ihtiyaç yoksa 


        
          
            //void git yap bitir ama eğer sonucta cıkan değere ihtiyacın varsa int kullanırsın
        
    }
}
