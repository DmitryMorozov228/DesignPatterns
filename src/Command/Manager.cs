﻿// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Command
{
    /// <summary>
    /// The Invoker is associated with one or several commands. It sends a
    /// request to the command.
    /// </summary>
    internal class Manager
    {
        private ICommand _command;

        internal void SetCommand(ICommand command)
        {
            _command = command;
        }

        internal void StartProject()
        {
            _command?.Execute();
        }

        internal void StopProject()
        {
            _command?.Undo();
        }
    }
}