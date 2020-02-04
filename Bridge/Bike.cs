// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    // Refine abstraction 1 in bridge pattern 
    internal class Bike : Vehicle
    {
        internal Bike(IFactory factory) : base(factory)
        {
        }

        internal override void Operation()
        {
            Console.Write("Bike ");
            _factory.Operation();
        }
    }
}