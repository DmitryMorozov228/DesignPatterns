// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace ChainOfResponsibility
{
    internal class Receiver
    {
        internal bool BankTransfer { get; }
        internal bool MoneyTransfer { get; }

        internal Receiver(bool bankTransfer, bool moneyTransfer)
        {
            BankTransfer = bankTransfer;
            MoneyTransfer = moneyTransfer;
        }
    }
}