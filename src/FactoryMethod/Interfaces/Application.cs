// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace FactoryMethod.Interfaces
{
    /// <summary>
    /// The Creator class declares the factory method that is supposed to return
    /// an object of a Product class. The Creator's subclasses usually provide
    /// the implementation of this method.
    /// </summary>
    internal abstract class Application
    {
        /// <summary>
        /// Creator without default implementation of factory method.
        /// Note that the Creator may also provide some default implementation of
        /// the factory method.
        /// </summary>
        /// <returns></returns>
        internal abstract Document CreateDocument();
    }

    // Creator with default implementation of factory method
    //internal class Application
    //{
    //    internal virtual Document CreateDocument()
    //    {
    //        return new DrawingDocument();
    //    }
    //}

    //// Factory method with generic type
    //internal class Application<T> where T : class, new()
    //{
    //    internal T CreateDocument()
    //    {
    //        return new T();
    //    }
    //}
}