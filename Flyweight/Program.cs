// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;
using System.Text.RegularExpressions;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexItem = new Regex(@"^[BQ]");
            while (true)
            {
                Console.WriteLine("Please enter your slider order (use characters B, Q with no spaces). Enter \"exit\" to stop program.");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (!regexItem.IsMatch(input))
                {
                    continue;
                }

                var chars = input.ToCharArray();
                var factory = new BurgerFactory();
                var orderTotal = 0;

                // Get the slider from the factory
                foreach (var c in chars)
                {
                    orderTotal++;
                    var burger = factory.GetBurger(c);
                    burger.Display(orderTotal);
                }

                Console.ReadKey();
            }
        }
    }
}
