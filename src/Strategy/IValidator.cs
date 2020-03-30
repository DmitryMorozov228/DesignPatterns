// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Strategy
{
    /// <summary>
    /// The strategy interface declares operations common to all
    /// supported versions of some algorithm. The context uses this
    /// interface to call the algorithm defined by the concrete
    /// strategies.
    /// </summary>
    public interface IValidator
    {
        void Validate();
    }
}