// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Facade.Interfaces
{
    internal interface IDvdPlayerService
    {
        void On();
        void Play(string movie);
        void Stop();
        void Eject();
        void Off();
    }
}