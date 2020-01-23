// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeBuilder()
                .SetName("Chen Kim")
                .SetPosition(".NET Developer")
                .SetSalary(20)
                .Build();

            Console.WriteLine(employee.ToString());
        }
    }
}
