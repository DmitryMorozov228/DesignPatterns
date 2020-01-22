// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets;
using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory
{
    internal class MacOsWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MacOsButton();
        }

        public IScrollBar CreateScrollBar()
        {
            return new MacOsScrollBar();
        }
    }
}