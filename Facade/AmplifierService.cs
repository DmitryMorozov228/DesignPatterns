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
    internal class AmplifierService : IAmplifierService
    {
        private int _volume;

        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }

        public void SetDvd()
        {
            Console.WriteLine("Amplifier setting DVD palyer");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier setting surround sound on");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"Amplifier setting volume to {_volume}");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }
    }
}