// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Decorator
{
    // The base Component interface defines operations that can be altered by
    // decorators.
    abstract class VisualComponent
    {
        internal abstract void Draw();
        internal abstract void Resize();
    }
}