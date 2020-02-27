// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// The client class works with factories and products only through abstract
    /// types: AbstractFactory and AbstractProduct. This lets you pass any
    /// factory or product subclass to the client code without breaking it.
    /// </summary>
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