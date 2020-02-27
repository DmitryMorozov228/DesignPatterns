// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Decorator
{
    /// <summary>
    /// The base Component interface defines operations that can be altered by
    /// decorators.
    /// </summary>
    internal abstract class VisualComponent
    {
        internal abstract void Draw();
        internal abstract void Resize();
    }
}