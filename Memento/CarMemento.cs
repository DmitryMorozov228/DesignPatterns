// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Memento
{
    internal class CarMemento
    {
        internal CarMemento(int speed, int mileage)
        {
            Speed = speed;
            Mileage = mileage;
        }

        internal int Speed { get; set; }
        internal int Mileage { get; set; }
    }
}