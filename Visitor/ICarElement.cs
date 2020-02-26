// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Visitor
{
    /// <summary>
    /// The Element interface declares an `accept` method that should take the
    /// base visitor interface as an argument.
    /// </summary>
    public interface ICarElement
    {
        string Name { get; set; }
        void Accept(ICarElementVisitor visitor);
    }
}