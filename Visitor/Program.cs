// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(new List<ICarElement>
            {
                new Body("Body"),
                new Engine("Engine"),
                new Wheel("Wheel")
            });
            car.Accept(new CarElementRepairVisitor());
            car.Accept(new CarElementPrintVisitor());
            Console.ReadKey();
        }
    }
}
