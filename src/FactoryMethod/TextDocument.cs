// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    /// <summary>
    /// Concrete Products provide various implementations of the Product
    /// interface.
    /// </summary>
    internal class TextDocument : Document
    {
        public TextDocument()
        {
            Console.WriteLine("Text document");
        }
    }
}