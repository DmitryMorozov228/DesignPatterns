// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Adapter
{
    internal class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("I'm riding on a horse");
        }
    }
}