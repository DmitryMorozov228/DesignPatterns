// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Thread(() =>
            {
                Singleton singleton1 = Singleton.Instance;
                Console.WriteLine(singleton1.Date);
            })).Start();

            Singleton singleton2 = Singleton.Instance;
            Console.WriteLine(singleton2.Date);
            Console.ReadKey();
        }
    }
}
