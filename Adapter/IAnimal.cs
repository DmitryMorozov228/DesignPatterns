// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Adapter
{
    /// <summary>
    /// The Adaptee contains some useful behavior, but its interface is
    /// incompatible with the existing client code. The Adaptee needs some
    /// adaptation before the client code can use it.
    /// </summary>
    internal interface IAnimal
    {
        void Move();
    }
}