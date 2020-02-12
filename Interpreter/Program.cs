// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your roman number:");
            var romanNumber = Console.ReadLine();
            Context context = new Context(romanNumber);

            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{romanNumber} = {context.Output}");
            Console.ReadKey();
        }
    }
}
