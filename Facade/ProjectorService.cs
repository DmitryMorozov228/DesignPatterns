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
    internal class ProjectorService : IProjectorService
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Project in widescreen mode");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }
    }
}