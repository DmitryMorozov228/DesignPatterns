// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileSystem = new Directory("My Documents");
            var photo = new Directory("Photo");
            var image = new File("image.png");
            photo.Add(image);
            fileSystem.Add(photo);
            image.Print();
            fileSystem.Print();
            Console.ReadKey();
        }
    }
}
