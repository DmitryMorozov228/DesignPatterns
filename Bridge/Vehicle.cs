// Developed by Softeq Development Corporation
// http://www.softeq.com
// 
namespace Bridge
{
    // abstraction in bridge pattern 
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