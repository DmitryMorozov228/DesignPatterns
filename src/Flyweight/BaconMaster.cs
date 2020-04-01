// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Flyweight
{
    /// <summary>
    /// A  ConcreteFlyweight class
    /// </summary>
    internal class BaconMaster : Burger
    {
        internal BaconMaster(string name, string cheese, string toppings, decimal price)
        {
            Name = name;
            Cheese = cheese;
            Toppings = toppings;
            Price = price;
        }

        internal override void Display(int orderTotal)
        {
            Console.WriteLine($"Burger #{orderTotal}: {Name} - topped with {Cheese} cheese and {Toppings}! ${Price}");
        }
    }
}