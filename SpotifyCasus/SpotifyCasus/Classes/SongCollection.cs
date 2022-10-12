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
        private string title;
        private List<iPlayable> playables;

        public string Title { get { return title; } set { title = value; } }

        public SongCollection(string title)
        {
            this.title = title;
            this.playables = new List<iPlayable>();
        }
    }
}
