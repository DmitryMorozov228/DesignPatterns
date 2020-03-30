// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var dotNetInterview = new DotNetInterview();
            var javaInterview = new JavaInterview();
            dotNetInterview.Initiate();
            Console.WriteLine();
            javaInterview.Initiate();
            Console.ReadKey();
        }
    }
}
