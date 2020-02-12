// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System.Collections.Generic;

namespace Command
{
    internal class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public MacroCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}