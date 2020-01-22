// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory
{
    internal class Widget
    {
        private readonly IButton _button;
        private readonly IScrollBar _scrollBar;

        public Widget(IWidgetFactory widgetFactory)
        {
            _button = widgetFactory.CreateButton();
            _scrollBar = widgetFactory.CreateScrollBar();
        }

        public string ButtonName => _button.Name;
        public string ScrollBarName => _scrollBar.Name;
    }
}