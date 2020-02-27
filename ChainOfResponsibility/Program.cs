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
            var receiver = new Receiver(false, true);
            var bankTransferHandler = new BankTransferHandler();
            var moneyTransferHandler = new MoneyTransferHandler();
            bankTransferHandler.Successor = moneyTransferHandler;
            bankTransferHandler.Handle(receiver);
            Console.ReadKey();
        }
    }
}
