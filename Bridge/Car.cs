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