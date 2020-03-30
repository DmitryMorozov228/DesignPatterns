// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Observer
{
    /// <summary>
    /// Concrete subject
    /// Stores state of interest to Concrete Observer.
    /// Sends a notification to its observers when its state changes.
    /// </summary>
    internal class TemperatureSensor : Sensor
    {
        private decimal _temperature;

        internal decimal Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                NotifyListeners();
            }
        }

        internal override void AddListener(ISensorListener listener)
        {
            Listeners.Add(listener);
        }

        internal override void RemoveListener(ISensorListener listener)
        {
            Listeners.Remove(listener);
        }

        internal override void NotifyListeners()
        {
            foreach (var listener in Listeners)
            {
                listener.Update();
            }
        }
    }
}