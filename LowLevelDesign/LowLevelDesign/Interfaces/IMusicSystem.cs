using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Interfaces
{
    internal interface IMusicSystem
    {
        void play();
        void pause();
        void forward(int duration);
        void rewind(int duration);

        void setVolume(int level);
    }
}
