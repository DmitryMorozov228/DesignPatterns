// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    // Concrete implementation 2 for bridge pattern 
    internal class AssembleFactory : IFactory
    {
        public void Operation()
        {
            Console.WriteLine("Assembled.");
        }
    }
}