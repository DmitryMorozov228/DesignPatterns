// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Observer
{
    /// <summary>
    /// Concrete subject
    /// Stores state of interest to Concrete Observer.
    /// Sends a notification to its observers when its state changes.
    /// </summary>
    public class TemperatureSensor : Sensor
    {
        private decimal _temperature;

        public decimal Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                NotifyListeners();
            }
        }
    }
}