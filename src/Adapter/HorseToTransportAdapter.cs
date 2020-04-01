// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Adapter
{
    /// <summary>
    /// The Adapter makes the Adaptee's interface compatible with the Target's
    /// interface.
    /// </summary>
    internal class HorseToTransportAdapter : ITransport
    {
        private readonly IAnimal _animal;

        internal HorseToTransportAdapter(IAnimal animal)
        {
            _animal = animal;
        }

        public void Drive()
        {
            _animal.Move();
        }
    }
}