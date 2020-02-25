// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Strategy
{
    public class RangeValidator : IValidator
    {
        public void Validate()
        {
            Console.WriteLine("This validator is used for range validation.");
        }
    }
}