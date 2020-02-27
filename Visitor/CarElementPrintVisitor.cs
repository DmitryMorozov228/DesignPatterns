// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Visitor
{
    /// <summary>
    /// Concrete Visitors implement several versions of the same algorithm, which
    /// can work with all concrete component classes.
    /// </summary>
    internal class CarElementPrintVisitor : ICarElementVisitor
    {
        public void Visit(Body body)
        {
            Console.WriteLine($"Output the element: {body.Name}");
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine($"Output the element: {engine.Name}");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine($"Output the element: {wheel.Name}");
        }
    }
}