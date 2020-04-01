// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Strategy
{
    /// <summary>
    /// Concrete strategies implement the algorithm while following
    /// the base strategy interface. The interface makes them
    /// interchangeable in the context.
    /// </summary>
    public class RangeValidator : IValidator
    {
        public void Validate()
        {
            Console.WriteLine("This validator is used to check range validation.");
        }
    }
}