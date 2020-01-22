// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Prototype
{
    internal class Rectangle : Figure
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        internal int Width { get; }
        internal int Height { get; }


        internal override Figure Clone()
        {
            return (Figure) MemberwiseClone();
        }
    }
}