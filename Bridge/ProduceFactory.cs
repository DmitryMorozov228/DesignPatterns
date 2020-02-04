// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    // Concrete implementation 1 for bridge pattern 
    internal class ProduceFactory : IFactory
    {
        public void Operation()
        {
            Console.WriteLine("Produced.");
        }
    }
}