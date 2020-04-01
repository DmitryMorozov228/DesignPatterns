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
            var programmer = new Programmer();
            var tester = new Tester();
            var businessAnalyst = new BusinessAnalyst();

            var commands = new List<ICommand>
            {
                new AnalyzeCommand(businessAnalyst),
                new CodeCommand(programmer),
                new TestCommand(tester),
            };

            var manager = new Manager();
            manager.SetCommand(new MacroCommand(commands));
            manager.StartProject();
            manager.StopProject();

            Console.ReadKey();
        }
    }
}
