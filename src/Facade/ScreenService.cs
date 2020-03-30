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
    internal class ScreenService : IScreenService
    {
        public void Down()
        {
            Console.WriteLine("Screen going down");
        }

        public void Up()
        {
            Console.WriteLine("Screen going up");
        }
    }
}