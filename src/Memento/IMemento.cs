// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Memento
{
    /// <summary>
    /// The Memento interface provides a way to retrieve the memento's metadata.
    /// However, it doesn't expose the Originator's state.
    /// </summary>
    public interface IMemento
    {
        int Speed { get; set; }
        int Mileage { get; set; }
    }
}