// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Composite
{
    /// <summary>
    /// The base Component class declares common operations for both simple and
    /// complex objects of a composition.
    /// </summary>

    internal abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }

        internal virtual void Add(Component component)
        {
        }

        internal virtual void Remove(Component component)
        {
        }

        internal virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}