// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace ChainOfResponsibility
{
    internal class BankTransferHandler : PaymentHandler
    {
        internal override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
            {
                Console.WriteLine("Complete bank transfer.");
            }
            else
            {
                Successor?.Handle(receiver);
            }
        }
    }
}