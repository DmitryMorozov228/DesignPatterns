// Developed by Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;

namespace Visitor
{
    internal class Car : ICarElement
    {
        private readonly IList<ICarElement> _elements;

        internal Car(IList<ICarElement> elements)
        {
            _elements = elements;
        }

        public string Name { get; set; }

        public void Accept(ICarElementVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}