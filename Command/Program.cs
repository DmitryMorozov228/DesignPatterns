// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            Tester tester = new Tester();
            BusinessAnalyst businessAnalyst = new BusinessAnalyst();

            List<ICommand> _commands = new List<ICommand>
            {
                new AnalyzeCommand(businessAnalyst),
                new CodeCommand(programmer),
                new TestCommand(tester),
            };

            Manager manager = new Manager();
            manager.SetCommand(new MacroCommand(_commands));
            manager.StartProject();
            manager.StopProject();

            Console.ReadLine();
        }
    }
}
