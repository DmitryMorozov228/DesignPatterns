// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Horse();
            ITransport transport = new HorseToTransportAdapter(horse);
            transport.Drive();
            Console.ReadKey();
        }
    }
}
