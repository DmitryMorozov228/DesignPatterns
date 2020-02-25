// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatureSensor = new TemperatureSensor();
            var heater = new Heater(temperatureSensor, 50);
            var airConditioner = new AirConditioner(temperatureSensor, 20);
            temperatureSensor.Temperature = 30;
            Console.WriteLine($"IsHeating: {heater.IsHeating}");
            Console.WriteLine($"IsCooling: {airConditioner.IsCooling}");
            temperatureSensor.Temperature = 10;
            Console.WriteLine($"IsHeating: {heater.IsHeating}");
            Console.WriteLine($"IsCooling: {airConditioner.IsCooling}");
            temperatureSensor.Temperature = 60;
            Console.WriteLine($"IsHeating: {heater.IsHeating}");
            Console.WriteLine($"IsCooling: {airConditioner.IsCooling}");
            Console.ReadKey();
        }
    }
}
