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
            Component fileSystem = new Directory("My Documents");
            Component photo = new Directory("Photo");
            Component image = new File("image.png");
            photo.Add(image);
            fileSystem.Add(photo);
            image.Print();
            fileSystem.Print();
            Console.ReadKey();
        }
    }
}
