// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace State
{
    /// <summary>
    /// The base State class declares methods that all Concrete State should
    /// implement.
    /// </summary>
    internal abstract class State
    {
        internal abstract void Execute();
    }
}