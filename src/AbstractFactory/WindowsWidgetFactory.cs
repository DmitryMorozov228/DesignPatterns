// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets;
using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// Concrete Factories produce a family of products that belong to a single
    /// variant. The factory guarantees that resulting products are compatible.
    /// Note that signatures of the Concrete Factory's methods return an abstract
    /// product, while inside the method a concrete product is instantiated.
    /// </summary>
    internal class WindowsWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IScrollBar CreateScrollBar()
        {
            return new WindowsScrollBar();
        }
    }
}