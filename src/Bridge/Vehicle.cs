// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Bridge
{
    /// <summary>
    /// The Abstraction defines the interface for the "control" part of the two
    /// class hierarchies. It maintains a reference to an object of the
    /// Implementation hierarchy and delegates all of the real work to this
    /// object.
    /// </summary>
    abstract class Vehicle
    {
        protected IFactory _factory;

        protected Vehicle(IFactory factory)
        {
            _factory = factory;
        }

        public IFactory Factory
        {
            set => _factory = value;
        }

        internal abstract void Operation();
    }
}