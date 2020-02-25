// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Observer
{
    /// <summary>
    /// Observer
    /// Defines an updating interface for objects that should be notified of changes in a subject.
    /// </summary>
    public interface ISensorListener
    {
        void Update();
    }
}