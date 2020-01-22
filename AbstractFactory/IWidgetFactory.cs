// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory
{
    public interface IWidgetFactory
    {
        IButton CreateButton();
        IScrollBar CreateScrollBar();
    }
}