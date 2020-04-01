// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Flyweight
{
    /// <summary>
    /// The Flyweight stores a common portion of the state (also called intrinsic
    /// state) that belongs to multiple real business entities. The Flyweight
    /// accepts the rest of the state (extrinsic state, unique for each entity)
    /// via its method parameters.
    /// </summary>
    internal abstract class Burger
    {
        protected string Name { get; set; }
        protected string Cheese { get; set; }
        protected string Toppings { get; set; }
        protected decimal Price { get; set; }

        internal abstract void Display(int orderTotal);
    }
}