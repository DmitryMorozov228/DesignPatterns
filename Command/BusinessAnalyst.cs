// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Command
{
    // The Receiver classes contain some important business logic. They know how
    // to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.
    internal class BusinessAnalyst
    {
        internal void StartAnalyzing()
        {
            Console.WriteLine("Start analyzing...");
        }
        internal void StopAnalyzing()
        {
            Console.WriteLine("Stop analyzing...");
        }
    }
}