// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace TemplateMethod
{
    /// <summary>
    /// Concrete classes have to implement all abstract operations of the base
    /// class. They can also override some operations with a default
    /// implementation.
    /// </summary>
    internal class DotNetInterview : Interview
    {
        protected override void Start()
        {
            Console.WriteLine("Start a .NET interview.");
        }

        protected override void Finish()
        {
            Console.WriteLine("Finish a .NET interview.");
        }

        protected override void Test()
        {
            Console.WriteLine("Completing a .NET test.");
        }

        protected override void Discuss()
        {
            Console.WriteLine("Discussing the test with .NET Unit Lead.");
        }
    }
}