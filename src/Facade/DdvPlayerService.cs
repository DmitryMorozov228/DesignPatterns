// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using Facade.Interfaces;

namespace Facade
{
    /// <summary>
    /// The Subsystem can accept requests either from the facade or client
    /// directly. In any case, to the Subsystem, the Facade is yet another
    /// client, and it's not a part of the Subsystem.
    /// </summary>
    internal class DdvPlayerService : IDvdPlayerService
    {
        private string _movie;

        public void On()
        {
            Console.WriteLine("DVD player on");
        }

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine($"DVD player playing {_movie}");
        }

        public void Stop()
        {
            Console.WriteLine($"DVD player stopped \"{_movie}\"");
        }

        public void Eject()
        {
            Console.WriteLine("DVD player eject");
        }

        public void Off()
        {
            Console.WriteLine("DVD player off");
        }
    }
}