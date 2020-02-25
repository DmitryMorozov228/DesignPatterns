// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    public class DeadState : IState
    {
        public void Execute()
        {
            Console.WriteLine("The player is dead. Game Over.");
        }
    }
}