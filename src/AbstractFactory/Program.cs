// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var windowsWidget = new Widget(new WindowsWidgetFactory());
            Console.WriteLine($"Button name: {windowsWidget.ButtonName}");
            Console.WriteLine($"ScrollBar name: {windowsWidget.ScrollBarName}");
            var macOsWidget = new Widget(new MacOsWidgetFactory());
            Console.WriteLine($"Button name: {macOsWidget.ButtonName}");
            Console.WriteLine($"ScrollBar name: {macOsWidget.ScrollBarName}");
            Console.ReadKey();
        }
    }
}
