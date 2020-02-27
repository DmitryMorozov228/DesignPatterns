// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Command
{
    /// <summary>
    /// Concrete command
    /// </summary>
    internal class TestCommand : ICommand
    {
        private readonly Tester _tester;

        public TestCommand(Tester tester)
        {
            _tester = tester;
        }

        public void Execute()
        {
            _tester.StartTesting();
        }

        public void Undo()
        {
            _tester.StopTesting();
        }
    }
}