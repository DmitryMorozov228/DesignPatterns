// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace State
{
    internal class Player
    {
        private IState _state;

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