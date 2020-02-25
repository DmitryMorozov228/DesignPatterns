// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    public class HealthyState : IState
    {
        public void Execute()
        {
            Console.WriteLine("The player is healthy.");
        }
    }
}