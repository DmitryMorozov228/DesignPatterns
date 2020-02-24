// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Mediator
{
    /// <summary>
    /// The concrete mediator class. The intertwined web of
    /// connections between individual components has been untangled
    /// and moved into the mediator.
    /// </summary>
    internal class CallCenter : Mediator
    {

        internal Taxi Taxi { get; set; }
        internal Customer Customer { get; set; }

        internal override void Send(string message, Colleague colleague)
        {
            if (colleague == Customer)
            {
                Taxi.Notify(message);
            }
            else if (colleague == Taxi)
            {
                Customer.Notify(message);
            }
        }
    }
}