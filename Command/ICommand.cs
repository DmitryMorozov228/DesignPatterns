// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Command
{
    /// <summary>
    /// The Command abstract class
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}