// Developed by Softeq Development Corporation
// http://www.softeq.com

using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    /// <summary>
    /// Concrete Creators override the factory method in order to change the
    /// resulting product's type.
    /// </summary>
    internal class TextApplication : Application
    {
        internal override Document CreateDocument()
        {
            return new TextDocument();
        }
    }
}