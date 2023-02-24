using System;
using PierreBakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------Welcome To Pierres Bakery---------------");
            Console.WriteLine("+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_");
            Console.WriteLine("Bread is Buy 2, get 1 free and Pastry is Buy 3, get 1 free");
            Console.WriteLine("Please enter a number for how many loaves of bread you would like to order:");
            int breadAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for how many pastries you would like to order:");
            int pastryAmount = int.Parse(Console.ReadLine());
            Bread bread = new Bread(breadAmount);
           // Console.WriteLine($"      Your selected bread amount is: {bread.breadPrice(breadAmount)}.");
            // Pastry pastry = new Pastry();
            // Console.WriteLine($"      Your selected pastry amount is: {pastry.pastryPrice}.");
            





        }

    }
}