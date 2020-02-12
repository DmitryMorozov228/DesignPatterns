// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace ChainOfResponsibility
{
    internal class MoneyTransferHandler : PaymentHandler
    {
        internal override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
            {
                Console.WriteLine("Complete money transfer.");
            }
            else
            {
                Successor?.Handle(receiver);
            }
        }
    }
}