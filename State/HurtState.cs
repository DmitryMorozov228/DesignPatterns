// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    /// <summary>
    /// Concrete State implement various behaviors, associated with a state of
    /// the Context.
    /// </summary>
    internal class HurtState : State
    {
        internal override void Execute()
        {
            Console.WriteLine("The player is wounded.");
        }
    }
}