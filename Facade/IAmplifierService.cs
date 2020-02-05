// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Facade
{
    public interface IAmplifierService
    {
        void On();
        void SetDvd();
        void SetSurroundSound();
        void SetVolume(int volume);
        void Off();
    }
}