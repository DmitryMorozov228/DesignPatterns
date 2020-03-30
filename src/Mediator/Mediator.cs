// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Mediator
{
    /// <summary>
    /// The mediator interface declares a method used by components
    /// to notify the mediator about various events. The mediator may
    /// react to these events and pass the execution to other
    /// components.
    /// </summary>
    internal abstract class Mediator
    {
        internal abstract void Send(string message, Colleague colleague);
    }
}