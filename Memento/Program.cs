// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var carMemento = new CarMemento(50, 1000);
            var car = new Car(carMemento);
            var carInfo = new CarInfo();
            car.IncreaseSpeed();
            carInfo.Info = car.SaveState();
            car.IncreaseMileage();
            car.RestoreState(carInfo.Info);
            car.IncreaseMileage();
            Console.ReadKey();
        }
    }
}
