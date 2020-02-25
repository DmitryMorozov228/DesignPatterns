// Developed by Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// Subject
    /// Knows its observers. Any number of Observer objects may observe a subject.
    /// Provides a way of attaching and detaching Observer objects.
    /// </summary>
    public abstract class Sensor
    {
        private readonly IList<ISensorListener> _listeners;

        protected Sensor()
        {
            _listeners = new List<ISensorListener>();
        }

        public void AddListener(ISensorListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(ISensorListener listener)
        {
            _listeners.Remove(listener);
        }

        public void NotifyListeners()
        {
            foreach (var listener in _listeners)
            {
                listener.Update();
            }
        }
    }
}