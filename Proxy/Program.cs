// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var image1 = new ProxyImage("1.txt");
            image1.Display();
            Console.ReadKey();
        }
    }
}
