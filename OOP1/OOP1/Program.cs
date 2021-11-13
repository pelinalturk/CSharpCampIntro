using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product {Id=1,CategoryId= 2,ProductName= "Masa" , UnitInStock=3, UnitPrice=500};
            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
    }
}
