// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Memento
{
    /// <summary>
    /// The Originator holds some important state that may change over time. It
    /// also defines a method for saving the state inside a memento and another
    /// method for restoring the state from it.
    /// </summary>
    internal class Car
    {
        private IMemento _carMemento;

        internal Car(IMemento carMemento)
        {
            _carMemento = carMemento;
        }

        internal void IncreaseSpeed()
        {
            _carMemento.Speed++;
            Console.WriteLine($"The speed was increased to {_carMemento.Speed}");
        }

        internal void IncreaseMileage()
        {
            _carMemento.Mileage++;
            Console.WriteLine($"The mileage was increased to {_carMemento.Mileage}");
        }

        internal IMemento SaveState()
        {
            Console.WriteLine($"Saving the state... Speed: {_carMemento.Speed}, Mileage: {_carMemento.Mileage}");
            return new CarMemento(_carMemento.Speed, _carMemento.Mileage);
        }

        internal void RestoreState(IMemento carMemento)
        {
            _carMemento = carMemento;
            Console.WriteLine($"Recovering the state... Speed: ${_carMemento.Speed}, Mileage: {_carMemento.Mileage}");
        }
    }
}