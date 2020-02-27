// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new DeveloperBuilder()
                .SetName()
                .SetPosition()
                .SetSalary()
                .Build();
            Console.WriteLine(employee.ToString());
            Console.ReadKey();
        }
    }
}
