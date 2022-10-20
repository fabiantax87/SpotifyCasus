using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class SongCollection
    {
        public string title;
        private List<iPlayable> playables;

        public List<iPlayable> Playables;

        public SongCollection(string title)
        {
            this.title = title;
            this.playables = new List<iPlayable>();
        }
    }
}
