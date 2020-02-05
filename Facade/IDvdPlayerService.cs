// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Facade
{
    public interface IDvdPlayerService
    {
        void On();
        void Play(string movie);
        void Stop();
        void Eject();
        void Off();
    }
}