// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawingApplication = new DrawingApplication();
            drawingApplication.CreateDocument();
            var textApplication = new TextApplication();
            textApplication.CreateDocument();
            Console.ReadKey();
        }
    }
}
