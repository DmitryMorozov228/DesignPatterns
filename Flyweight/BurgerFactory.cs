// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// The Flyweight Factory creates and manages the Flyweight objects. It
    /// ensures that flyweights are shared correctly. When the client requests a
    /// flyweight, the factory either returns an existing instance or creates a
    /// new one, if it doesn't exist yet.
    /// Test
    /// </summary>
    internal class BurgerFactory
    {
        private readonly Dictionary<char, Burger> _burgers;

        internal BurgerFactory()
        {
            _burgers = new Dictionary<char, Burger>();
        }

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
                        burger = new BaconMaster("Bacon Master", "American", "lots of bacon", 2.39m);
                        break;
                    }
                    case 'Q':
                    {
                        burger = new BbqKing("BBQ King", "American", "Onion rings, lettuce, and BBQ sauce", 2.49m);
                        break;
                    }
                }
                _burgers.Add(key, burger);
            }

            return burger;
        }
    }
}