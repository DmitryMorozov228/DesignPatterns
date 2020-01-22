// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using AbstractFactory.Widgets.Interfaces;

namespace AbstractFactory.Widgets
{
    internal class MacOsScrollBar : IScrollBar
    {
        public string Name => "MacOS ScrollBar";
    }
}