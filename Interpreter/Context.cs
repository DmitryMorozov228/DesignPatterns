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
        public Context(string input)
        {
            Input = input;
        }

        internal string Input { get; set; }
        internal int Output { get; set; }
    }
}