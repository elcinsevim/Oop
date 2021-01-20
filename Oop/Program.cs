using OOP1;
using System;

namespace Oop
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;

          
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            product1.ProductName = "Masa";
            //pascalcase //camelcase

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

           
            //int,doble,bool...vb değer tip-değer üstünden olur ve bağlantı kopar
            //diziler,class,abstract class,interface -ref no ile yapılır 

        }
    }
}
