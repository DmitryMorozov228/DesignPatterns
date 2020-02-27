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
    internal class JavaInterview : Interview
    {
        protected override void Test()
        {
            Console.WriteLine("Completing a Java test.");
        }

        protected override void Discuss()
        {
            Console.WriteLine("Discussing the test with Java Unit Lead.");
        }
    }
}