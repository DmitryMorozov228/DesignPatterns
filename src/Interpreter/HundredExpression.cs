// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Interpreter
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Hundred checks C, CD, D or CM
    /// </remarks>
    /// </summary>
    internal class HundredExpression : Expression
    {
        protected override string One()
        {
            return "C";
        }

        protected override string Four()
        {
            return "CD";
        }

        protected override string Five()
        {
            return "D";
        }

        protected override string Nine()
        {
            return "CM";
        }

        protected override int Multiplier()
        {
            return 100;
        }
    }
}