// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Observer
{
    /// <summary>
    /// Concrete Observer
    /// Maintains a reference to the Concrete Subject.
    /// Stores state that should stay consistent with the Subject's.
    /// Implements the Observer updating interface to keep its state consistent with the subject's.
    /// </summary>
    internal class Heater : ISensorListener
    {
        private readonly TemperatureSensor _temperatureSensor;

        public Heater(TemperatureSensor temperatureSensor, decimal maxHeatingTemperature)
        {
            MaxHeatingTemperature = maxHeatingTemperature;
            _temperatureSensor = temperatureSensor;
            _temperatureSensor.AddListener(this);
        }

        private decimal MaxHeatingTemperature { get; }
        public bool IsHeating { get; private set; }

        public void Update()
        {
            IsHeating = _temperatureSensor.Temperature < MaxHeatingTemperature;
        }
    }
}