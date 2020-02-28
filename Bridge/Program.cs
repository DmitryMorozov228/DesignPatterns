// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Bridge
{
    /// <summary>
    /// Except for the initialization phase, where an Abstraction object gets
    /// linked with a specific Implementation object, the client code should
    /// only depend on the Abstraction class. This way the client code can
    /// support any abstraction-implementation combination.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(new AssembleFactory());
            car.Operation();
            car.Factory = new ProduceFactory();
            car.Operation();
            var bike = new Bike(new AssembleFactory());
            bike.Operation();
            bike.Factory = new ProduceFactory();
            bike.Operation();
            Console.ReadKey();
        }
    }
}
