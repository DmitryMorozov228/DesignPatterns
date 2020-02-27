// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory.Widgets
{
    /// <summary>
    /// Concrete Products are created by corresponding Concrete Factories.
    /// </summary>
    internal class WindowsScrollBar : IScrollBar
    {
        public string Name => "Windows ScrollBar";
    }
}