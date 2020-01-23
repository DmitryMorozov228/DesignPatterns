// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Adapter
{
    internal class HorseToTransportAdapter : ITransport
    {
        private readonly IAnimal _animal;

        public HorseToTransportAdapter(IAnimal animal)
        {
            _animal = animal;
        }

        public void Drive()
        {
            _animal.Move();
        }
    }
}