// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Interpreter
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    internal class Context
    {
        private int _output;

        public Context(string input)
        {
            Input = input;
        }

        internal string Input { get; set; }
        internal int Output { get; set; }
    }
}