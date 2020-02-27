﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Visitor
{
    /// <summary>
    /// The Visitor Interface declares a set of visiting methods that correspond
    /// to component classes. The signature of a visiting method allows the
    /// visitor to identify the exact class of the component that it's dealing
    /// with.
    /// </summary>
    internal interface ICarElementVisitor
    {
        void Visit(Body body);
        void Visit(Engine engine);
        void Visit(Wheel wheel);
    }
}