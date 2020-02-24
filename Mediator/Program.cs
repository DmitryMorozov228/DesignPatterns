// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var callCenter = new CallCenter();
            var taxi = new Taxi(callCenter);
            var customer = new Customer(callCenter);
            callCenter.Taxi = taxi;
            callCenter.Customer = customer;
            customer.Send("I need a taxi.");
            taxi.Send("Sorry, I am busy.");
            Console.ReadKey();
        }
    }
}
