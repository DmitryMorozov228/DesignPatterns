// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Strategy
{
    internal class Context
    {
        private readonly IValidator _validator;

        internal Context(IValidator validator)
        {
            _validator = validator;
        }

        internal void Validate()
        {
            _validator.Validate();
        }
    }
}