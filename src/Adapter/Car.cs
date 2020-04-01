// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Adapter
{
    internal class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("I'm driving a car.");
        }
    }
}