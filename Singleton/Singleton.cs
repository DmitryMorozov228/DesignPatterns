// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Singleton
{
    internal sealed class Singleton
    {
        static Singleton()
        {
        }

        private Singleton()
        {
            Date = DateTime.UtcNow.TimeOfDay.ToString();
        }

        public string Date { get; }

        public static Singleton Instance { get; } = new Singleton();
    }
}