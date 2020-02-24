// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Memento
{
    internal class Car
    {
        private CarMemento _carMemento;

        internal Car(CarMemento carMemento)
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

        internal CarMemento SaveState()
        {
            Console.WriteLine($"Saving the state... Speed: {_carMemento.Speed}, Mileage: {_carMemento.Mileage}");
            return new CarMemento(_carMemento.Speed, _carMemento.Mileage);
        }

        internal void RestoreState(CarMemento carMemento)
        {
            _carMemento = carMemento;
            Console.WriteLine($"Recovering the state... Speed: ${_carMemento.Speed}, Mileage: {_carMemento.Mileage}");
        }
    }
}