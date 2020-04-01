// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    /// <summary>
    /// Each Concrete Implementation corresponds to a specific platform and
    /// implements the Implementation interface using that platform's API.
    /// </summary>
    internal class ProduceFactory : IFactory
    {
        public void Operation()
        {
            Console.WriteLine("Produced.");
        }
    }
}