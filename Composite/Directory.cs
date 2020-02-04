// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using System.Collections.Generic;

namespace Composite
{
    // The Composite class represents the complex components that may have
    // children. Usually, the Composite objects delegate the actual work to
    // their children and then "sum-up" the result.
    internal class Directory : Component
    {
        private readonly List<Component> _components = new List<Component>();

        internal Directory(string name) : base(name)
        {
        }

        internal override void Add(Component component)
        {
            _components.Add(component);
        }

        internal override void Remove(Component component)
        {
            _components.Remove(component);
        }

        internal override void Print()
        {
            Console.WriteLine($"Node: {_name}");
            Console.WriteLine("Subnodes:");
            foreach (Component c in _components)
            {
                c.Print();
            }
        }
    }
}