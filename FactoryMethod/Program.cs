// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawingApplication = new Application<DrawingDocument>();
            drawingApplication.CreateDocument();
            var textApplication = new Application<TextDocument>();
            textApplication.CreateDocument();
            Console.ReadLine();
        }
    }
}
