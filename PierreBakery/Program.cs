using System;
using PierreBakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------Welcome To Pierre's Bakery---------------");
            Console.WriteLine("+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_\n");
            Console.WriteLine("The cost of bread is $5.00 and a Pastry is $2.00");
            Console.WriteLine("Bread is Buy 2, get 1 free and Pastry is Buy 3, get 1 free\n");
            Console.WriteLine("*************************************************************\n");
            Console.WriteLine("Please enter a number for how many loaves of bread you would like to order:");
            int breadAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for how many pastries you would like to order:");
            int pastryAmount = int.Parse(Console.ReadLine());
            Bread bread = new Bread(breadAmount);
            Pastry pastry = new Pastry(pastryAmount);
            Console.WriteLine($"Your bread Total: {bread.breadPrice(breadAmount)}.");
            Console.WriteLine($"Your pastry Total: {pastry.pastryPrice(pastryAmount)}.");
            Console.WriteLine($"Your Total: {bread.breadPrice(breadAmount) + pastry.pastryPrice(pastryAmount)}\n");
            Console.WriteLine("Thanks for SHOPPING!!!");






        }

    }
}