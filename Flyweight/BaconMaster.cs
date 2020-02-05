// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Flyweight
{
    /// A  ConcreteFlyweight class
    internal class BaconMaster : Burger
    {
        internal BaconMaster()
        {
            Name = "Bacon Master";
            Cheese = "American";
            Toppings = "lots of bacon";
            Price = 2.39m;
        }

        internal override void Display(int orderTotal)
        {
            Console.WriteLine($"Burger #{orderTotal}: {Name} - topped with {Cheese} cheese and {Toppings}! ${Price}");
        }
    }
}