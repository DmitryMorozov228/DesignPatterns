// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Proxy
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    internal class RealImage : IImage
    {
        private readonly string _fileName;

        internal RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromFile();
        }

        private void LoadImageFromFile()
        {
            Console.WriteLine($"Load image from file {_fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image {_fileName}");
        }
    }
}