using System;
using System.Collections.Generic;

namespace MyFlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop shop = new FlowerShop();

            List<IColorfulFlower> mothersDay = shop.makeMothersDayBouquet();


            foreach (IColorfulFlower flower in mothersDay){
                Console.WriteLine(flower);
            }
        }
    }
}
