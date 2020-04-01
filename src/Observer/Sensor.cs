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
    internal abstract class Sensor
    {
        protected readonly IList<ISensorListener> Listeners;

        protected Sensor()
        {
            Listeners = new List<ISensorListener>();
        }

        internal abstract void AddListener(ISensorListener listener);
        internal abstract void RemoveListener(ISensorListener listener);
        internal abstract void NotifyListeners();
    }
}