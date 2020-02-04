// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    // Refine abstraction 2 in bridge pattern 
    internal class Car : Vehicle
    {
        internal Car(IFactory factory) : base(factory)
        {
        }

        internal override void Operation()
        {
            Console.Write("Car ");
            _factory.Operation();
        }
    }
}