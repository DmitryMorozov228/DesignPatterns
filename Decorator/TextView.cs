// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Decorator
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    internal class TextView : VisualComponent
    {
        internal override void Draw()
        {
            Console.WriteLine("Display text view.");
        }

        internal override void Resize()
        {
            Console.WriteLine("Resize text.");
        }
    }
}