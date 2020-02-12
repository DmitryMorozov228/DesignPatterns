// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Interpreter
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Ten checks for X, XL, L and XC
    /// </remarks>
    /// </summary>
    internal class TenExpression : Expression
    {
        protected override string One()
        {
            return "X";
        }

        protected override string Four()
        {
            return "XL";
        }

        protected override string Five()
        {
            return "L";
        }

        protected override string Nine()
        {
            return "XC";
        }

        protected override int Multiplier()
        {
            return 10;
        }
    }
}