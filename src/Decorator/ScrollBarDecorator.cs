﻿// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Decorator
{
    /// <summary>
    /// Decorators can execute their behavior either before or after the call to
    /// a wrapped object.
    /// </summary>
    internal class ScrollBarDecorator : Decorator
    {
        internal ScrollBarDecorator(VisualComponent visualComponent) : base(visualComponent)
        {
        }

        internal override void Draw()
        {
            base.Draw();
            Console.WriteLine("Adding scrollbar to text view component.");
        }
    }
}