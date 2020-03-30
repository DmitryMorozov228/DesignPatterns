// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Memento
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the
    /// Originator's state.
    /// </summary>
    internal class CarMemento : IMemento
    {
        internal CarMemento(int speed, int mileage)
        {
            Speed = speed;
            Mileage = mileage;
        }

        public int Speed { get; set; }
        public int Mileage { get; set; }
    }
}