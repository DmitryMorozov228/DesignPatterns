// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Iterator
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    internal abstract class Iterator
    {
        internal abstract void First();
        internal abstract void Next();
        internal abstract bool HasNext();
        internal abstract object GetCurrentItem();
    }
}