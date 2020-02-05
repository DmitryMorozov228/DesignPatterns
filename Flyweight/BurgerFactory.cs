// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System.Collections.Generic;

namespace Flyweight
{
    // The Flyweight Factory creates and manages the Flyweight objects. It
    // ensures that flyweights are shared correctly. When the client requests a
    // flyweight, the factory either returns an existing instance or creates a
    // new one, if it doesn't exist yet.
    internal class BurgerFactory
    {
        private readonly Dictionary<char, Burger> _burgers = new Dictionary<char, Burger>();

        internal Burger GetBurger(char key)
        {
            Burger burger = null;
            if (_burgers.ContainsKey(key))
            {
                burger = _burgers[key];
            }
            else
            {
                switch (key)
                {
                    case 'B':
                    {
                        burger = new BaconMaster();
                        break;
                    }
                    case 'Q':
                    {
                        burger = new BbqKing();
                        break;
                    }
                }
                _burgers.Add(key, burger);
            }

            return burger;
        }
    }
}