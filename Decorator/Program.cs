// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            var textView = new ScrollBarDecorator(new BorderDecorator(new TextView(), 4));
            textView.Draw();
            Console.ReadKey();
        }
    }
}
