using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Interfaces
{
    internal class Car
    {
        private IMusicSystem _musicSystem;

        public void setMusicSystem(IMusicSystem obj)
        {
            _musicSystem = obj;
        }

        void startCar()
        {
            Console.WriteLine("Car Started");
        }

        public void playSong()
        {
            _musicSystem.play();
        }

        public void pauseSong()
        {
            _musicSystem.pause();
        }
    }
}
