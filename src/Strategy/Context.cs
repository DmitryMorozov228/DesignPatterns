// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Strategy
{
    /// <summary>
    /// The context defines the interface of interest to clients.
    /// </summary>
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