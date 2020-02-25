// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Hit(3);
            player.Hit(6);
            player.Hit(12);
            Console.ReadKey();
        }
    }
}
