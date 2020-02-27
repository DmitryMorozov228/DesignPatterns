// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace AbstractFactory.Widgets.Interfaces
{
    /// <summary>
    /// Each distinct product of a product family should have a base interface.
    /// All variants of the product must implement this interface.
    /// </summary>
    public interface IButton
    {
        string Name { get; }
    }
}