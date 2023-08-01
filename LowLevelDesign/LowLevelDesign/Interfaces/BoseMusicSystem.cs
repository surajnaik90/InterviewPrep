using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Interfaces
{
    internal class BoseMusicSystem : IMusicSystem
    {
        public void forward(int duration)
        {
            Console.WriteLine("BOSE forwarded it");
        }

        public void pause()
        {
            Console.WriteLine("BOSE paused it");
        }

        public void play()
        {
            Console.WriteLine("BOSE played it");
        }

        public void rewind(int duration)
        {
            Console.WriteLine("BOSE rewinded it");
        }

        public void setVolume(int level)
        {
            Console.WriteLine("BOSE set volume");
        }
    }
}
