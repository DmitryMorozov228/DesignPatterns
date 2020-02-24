// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Mediator
{
    /// <summary>
    /// Concrete components don't talk to each other. They have only
    /// one communication channel, which is sending notifications to
    /// the mediator.
    /// </summary>
    internal class Customer : Colleague
    {
        private readonly Mediator _mediator;

        internal Customer(Mediator mediator)
        {
            _mediator = mediator;
        }

        internal override void Send(string message)
        {
            Console.WriteLine($"Customer: {message}");
            _mediator.Send(message, this);
        }

        internal override void Notify(string message)
        {
            Console.WriteLine($"Message \"{message}\" was received by customer.");
        }
    }
}