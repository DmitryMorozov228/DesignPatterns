// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    internal class TextDocument : Document
    {
        public TextDocument()
        {
            Console.WriteLine("Text document");
        }
    }
}