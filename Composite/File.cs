// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Composite
{

    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.
    internal class File : Component
    {
        internal File(string name) : base(name)
        {
        }
    }
}