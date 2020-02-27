// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Decorator
{
    /// <summary>
    /// The base Decorator class follows the same interface as the other
    /// components. The primary purpose of this class is to define the wrapping
    /// interface for all concrete decorators. The default implementation of the
    /// wrapping code might include a field for storing a wrapped component and
    /// the means to initialize it.
    /// </summary>
    internal class Decorator : VisualComponent
    {
        private readonly VisualComponent _visualComponent;

        protected Decorator(VisualComponent visualComponent)
        {
            _visualComponent = visualComponent;
        }

        internal override void Draw()
        {
            _visualComponent.Draw();
        }

        internal override void Resize()
        {
            _visualComponent.Resize();
        }
    }
}