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


        /// <summary>
        /// The Singleton's instance is stored in a static field. There there are
        /// multiple ways to initialize this field, all of them have various pros
        /// and cons. In this example we'll show the simplest of these ways,
        /// which, however, doesn't work really well in multithreaded program.
        /// </summary>
        public static Singleton Instance { get; } = new Singleton();
    }
}