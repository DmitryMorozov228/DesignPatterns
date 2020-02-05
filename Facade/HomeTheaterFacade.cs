// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

using System;

namespace Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    internal class HomeTheaterFacade : TheaterFacade
    {
        private readonly IAmplifierService _amplifierService;
        private readonly IDvdPlayerService _dvdPlayerService;
        private readonly IProjectorService _projectorService;
        private readonly IScreenService _screenService;

        internal HomeTheaterFacade(
            IAmplifierService amplifierService, 
            IDvdPlayerService dvdPlayerService, 
            IProjectorService projectorService, 
            IScreenService screenService)
        {
            _amplifierService = amplifierService;
            _dvdPlayerService = dvdPlayerService;
            _projectorService = projectorService;
            _screenService = screenService;
        }

        internal override void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            _screenService.Down();
            _projectorService.On();
            _projectorService.WideScreenMode();
            _amplifierService.On();
            _amplifierService.SetDvd();
            _amplifierService.SetSurroundSound();
            _amplifierService.SetVolume(5);
            _dvdPlayerService.On();
            _dvdPlayerService.Play(movie);
        }

        internal override void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _screenService.Up();
            _projectorService.Off();
            _amplifierService.Off();
            _dvdPlayerService.Stop();
            _dvdPlayerService.Eject();
            _dvdPlayerService.Off();
        }
    }
}