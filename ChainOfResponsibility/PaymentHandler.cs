// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace ChainOfResponsibility
{
    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    internal abstract class PaymentHandler
    {
        internal PaymentHandler Successor { get; set; }
        internal abstract void Handle(Receiver receiver);
    }
}