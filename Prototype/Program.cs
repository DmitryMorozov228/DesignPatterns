// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(40, 50);
            var clonedRectangle = (Rectangle) rectangle.Clone();
            Console.WriteLine($"Rectangle size: width - {rectangle.Width}, height - {rectangle.Height}");
            Console.WriteLine($"Cloned rectangle size: width - {clonedRectangle.Width}, height - {clonedRectangle.Height}");
            Console.ReadKey();
        }
    }
}
