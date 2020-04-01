// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Command
{
    /// <summary>
    /// The Command interface declares a methods for executing a command.
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}