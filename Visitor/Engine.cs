// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Visitor
{
    /// <summary>
    /// Each Concrete Element must implement the `Accept` method in such a way
    /// that it calls the visitor's method corresponding to the component's
    /// class.
    /// </summary>
    internal class Engine : ICarElement
    {
        internal Engine(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        /// <summary>
        /// Note that we're calling `Visit`, which matches the
        /// current class name. This way we let the visitor know the class of the
        /// component it works with.
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}