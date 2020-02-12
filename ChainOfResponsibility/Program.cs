// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true);
            PaymentHandler bankTransferHandler = new BankTransferHandler();
            PaymentHandler moneyTransferHandler = new MoneyTransferHandler();
            bankTransferHandler.Successor = moneyTransferHandler;
            bankTransferHandler.Handle(receiver);
            Console.ReadKey();
        }
    }
}
