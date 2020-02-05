// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Facade
{
    // Subsystem
    public class ProjectorService : IProjectorService
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