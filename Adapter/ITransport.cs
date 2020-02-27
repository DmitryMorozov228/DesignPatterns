// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Adapter
{
    /// <summary>
    /// The Target defines the domain-specific interface used by the client code.
    /// </summary>
    internal interface ITransport
    {
        void Drive();
    }
}