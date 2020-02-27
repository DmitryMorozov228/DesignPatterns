// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory.Widgets
{
    /// <summary>
    /// Concrete Products are created by corresponding Concrete Factories.
    /// </summary>
    internal class WindowsButton : IButton
    {
        public string Name => "Windows Button";
    }
}