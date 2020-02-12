// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Command
{
    // Concrete command
    internal class AnalyzeCommand : ICommand
    {
        private readonly BusinessAnalyst _businessAnalyst;

        public AnalyzeCommand(BusinessAnalyst businessAnalyst)
        {
            _businessAnalyst = businessAnalyst;
        }

        public void Execute()
        {
            _businessAnalyst.StartAnalyzing();
        }

        public void Undo()
        {
            _businessAnalyst.StopAnalyzing();
        }
    }
}