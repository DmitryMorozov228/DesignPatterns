// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    public class HurtState : IState
    {
        public void Execute()
        {
            Console.WriteLine("The player is wounded.");
        }
    }
}