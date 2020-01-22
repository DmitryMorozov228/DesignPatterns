// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace FactoryMethod.Interfaces
{
    // Creator without default implementation of factory method
    //internal abstract class Application
    //{
    //    internal abstract Document CreateDocument();
    //}

    // Creator with default implementation of factory method
    //internal class Application
    //{
    //    internal virtual Document CreateDocument()
    //    {
    //        return new DrawingDocument();
    //    }
    //}

    // Factory method with generic type
    internal class Application<T> where T : class, new()
    {
        internal T CreateDocument()
        {
            return new T();
        }
    }
}