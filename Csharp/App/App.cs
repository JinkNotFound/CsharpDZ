using System;
using System.Collections.Generic;
using Domain;
using Service;

namespace App
{
    class App
    {
        static void Main()
        {
            Console.WriteLine("Hello");

            Product item1 = new Product(100.0, 1, "lays");
            Product item2 = new Product(80.0, 2, "nuts");
            Product item3 = new Product(40.0, 3, "mars");
            Product item4 = new Bottle(14.5, 4, "Cola", 0.5f);
            Product item5 = new Bottle(20.5, 5, "Mineral", 0.5f);
            Product item6 = new HotDrink(34.99, 6, "Tea", 0.5f, 75);
            Product item7 = new HotDrink(37.99, 7, "Coffee", 0.5f, 80);


            List<Product> products = new List<Product>
            {
                item1,
                item2,
                item3,
                item4,
                item5,
                item6,
                item7
            };

            Holder hold = new Holder();
            CoinDispenser coin = new CoinDispenser();
            Display display = new Display();
            VendingMachine vendingMachine = new VendingMachine(hold, coin, display, products);

            foreach (Product prod in vendingMachine.GetProductList())
            {
                Console.WriteLine(prod);
            }
        }
    }
}
