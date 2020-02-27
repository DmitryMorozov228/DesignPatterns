// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Decorator
{
    /// <summary>
    /// Concrete Decorators call the wrapped object and alter its result in some
    /// way.
    /// </summary>
    internal class BorderDecorator : Decorator
    {
        private readonly int _width;

        internal BorderDecorator(VisualComponent visualComponent, int borderWidth) : base(visualComponent)
        {
            _width = borderWidth;
        }

        internal override void Draw()
        {
            base.Draw();
            DrawBorder(_width);
        }

        private void DrawBorder(int width)
        {
            Console.WriteLine($"Adding border with width: {_width}");
        }
    }
}