// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Memento
{
    /// <summary>
    /// The Caretaker doesn't depend on the Concrete Memento class. Therefore, it
    /// doesn't have access to the originator's state, stored inside the memento.
    /// It works with all mementos via the base Memento interface.
    /// </summary>
    internal class CarInfo
    {
        internal IMemento Info { get; set; }
    }
}