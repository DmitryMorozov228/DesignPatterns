// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Iterator
{
    /// <summary>
    /// The aggregate interface
    /// Returns an Iterator or another IteratorAggregate for the implementing
    /// object.
    /// </summary>
    internal abstract class StaffCollection
    {
        internal abstract Iterator CreateIterator();
        internal abstract int Count { get; }
        internal abstract object this[int index] { get; }
    }
}