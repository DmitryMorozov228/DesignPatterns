// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Command
{
    /// <summary>
    /// Concrete command
    /// </summary>
    internal class CodeCommand : ICommand
    {
        private readonly Programmer _programmer;

        public CodeCommand(Programmer programmer)
        {
            _programmer = programmer;
        }

        public void Execute()
        {
            _programmer.StartCoding();
        }

        public void Undo()
        {
            _programmer.StopCoding();
        }
    }
}