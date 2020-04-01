// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    /// <summary>
    /// The Context defines the interface of interest to clients. It also
    /// maintains a reference to an instance of a State subclass, which
    /// represents the current state of the Context.
    /// </summary>
    internal class Player
    {
        private State _state;

        internal Player()
        {
            _state = new HealthyState();
        }

        internal void Hit(int bullets)
        {
            Console.WriteLine("Bullets hits to the player: " + bullets);
            if (bullets < 5)
            {
                _state = new HealthyState();
            }
            if (bullets >= 5 && bullets < 10)
            {
                _state = new HurtState();
            }
            if (bullets >= 10)
            {
                _state = new DeadState();
            }

            _state.Execute();
        }
    }
}