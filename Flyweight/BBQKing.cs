// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Flyweight
{
    /// A  ConcreteFlyweight class
    internal class BbqKing : Burger
    {
        internal BbqKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        internal override void Display(int orderTotal)
        {
            Console.WriteLine($"Burger #{orderTotal}: {Name} - topped with {Cheese} cheese and {Toppings}! ${Price}");
        }
    }
}