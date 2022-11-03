using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Interfaces
{
    internal interface iPlayable
    {
        void Play();
        void Pause();
        void Stop();
        void Next();
        void Length();
    }
}
