// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new RangeValidator());
            context.Validate();
            context = new Context(new RequiredFieldValidator());
            context.Validate();
            Console.ReadKey();
        }
    }
}
