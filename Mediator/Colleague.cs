// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Mediator
{
    /// <summary>
    /// Components communicate with a mediator using the mediator
    /// interface. Thanks to that, you can use the same components in
    /// other contexts by linking them with different mediator
    /// objects.
    /// </summary>
    internal abstract class Colleague
    {
        internal abstract void Send(string message);
        internal abstract void Notify(string message);
    }
}