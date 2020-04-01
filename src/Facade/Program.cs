// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code works with complex subsystems through a simple
            // interface provided by the Facade. When a facade manages the lifecycle
            // of the subsystem, the client might not even know about the existence
            // of the subsystem. This approach lets you keep the complexity under
            // control.
            var homeTheaterFacade = new HomeTheaterFacade(
                new AmplifierService(),
                new DdvPlayerService(), 
                new ProjectorService(), 
                new ScreenService());

            homeTheaterFacade.WatchMovie("Joker");
            homeTheaterFacade.EndMovie();
            Console.ReadKey();
        }
    }
}
