// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Facade
{
    // Subsystem
    public class ScreenService : IScreenService
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