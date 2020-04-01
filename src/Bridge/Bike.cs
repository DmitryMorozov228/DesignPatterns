// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    /// <summary>
    /// You can extend the Abstraction without changing the Implementation
    /// classes.
    /// </summary>
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