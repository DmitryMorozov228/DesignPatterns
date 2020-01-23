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
            var developerBuilder = new DeveloperBuilder();
            var director = new Director(developerBuilder);
            director.Construct();
            var employeeInfo = developerBuilder.Build().ToString();
            Console.WriteLine(employeeInfo);
            Console.ReadKey();
        }
    }
}
