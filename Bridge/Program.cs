// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    // Client use abstractions. 
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(new ProduceFactory());
            car.Operation();
            car.Factory = new AssembleFactory();
            car.Operation();
            var bike = new Bike(new AssembleFactory());
            bike.Operation();
            bike.Factory = new ProduceFactory();
            bike.Operation();
            Console.ReadKey();
        }
    }
}
