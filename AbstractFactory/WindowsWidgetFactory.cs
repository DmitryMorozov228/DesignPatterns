// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets;
using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory
{
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