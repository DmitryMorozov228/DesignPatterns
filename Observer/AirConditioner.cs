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
    public class AirConditioner : ISensorListener
    {
        private readonly TemperatureSensor _temperatureSensor;

        public AirConditioner(TemperatureSensor temperatureSensor, decimal minCoolingTemperature)
        {
            MinCoolingTemperature = minCoolingTemperature;
            _temperatureSensor = temperatureSensor;
            _temperatureSensor.AddListener(this);
        }

        private decimal MinCoolingTemperature { get; }
        public bool IsCooling { get; set; }

        public void Update()
        {
            IsCooling = _temperatureSensor.Temperature > MinCoolingTemperature;
        }
    }
}