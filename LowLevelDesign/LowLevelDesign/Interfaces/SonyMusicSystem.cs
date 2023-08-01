using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Interfaces
{
    internal class SonyMusicSystem : IMusicSystem
    {
        public void forward(int duration)
        {
            Console.WriteLine("SONY forwarded it");
        }

        public void pause()
        {
            Console.WriteLine("SONY paused it");
        }

        public void play()
        {
            Console.WriteLine("SONY played it");
        }

        public void rewind(int duration)
        {
            Console.WriteLine("SONY rewinded it");
        }

        public void setVolume(int level)
        {
            Console.WriteLine("SONY set volume");
        }
    }
}
