// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Interpreter
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// One checks for I, II, III, IV, V, VI, VI, VII, VIII, IX
    /// </remarks>
    /// </summary>
    internal class OneExpression : Expression
    {
        protected override string One()
        {
            return "I";
        }

        protected override string Four()
        {
            return "IV";

        }

        protected override string Five()
        {
            return "V";

        }

        protected override string Nine()
        {
            return "IX";

        }

        protected override int Multiplier()
        {
            return 1;
        }
    }
}