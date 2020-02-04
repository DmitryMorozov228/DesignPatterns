// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Composite
{
    // The base Component class declares common operations for both simple and
    // complex objects of a composition.
    internal abstract class Component
    {
        protected string _name;

        protected Component(string name)
        {
            _name = name;
        }

        internal virtual void Add(Component component)
        {
        }

        internal virtual void Remove(Component component)
        {
        }

        internal virtual void Print()
        {
            Console.WriteLine(_name);
        }
    }
}