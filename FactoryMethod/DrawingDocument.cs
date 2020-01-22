// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    internal class DrawingDocument : Document
    {
        public DrawingDocument()
        {
            Console.WriteLine("Drawing document");
        }
    }
}