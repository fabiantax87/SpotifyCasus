using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Playlist : SongCollection
    {
        public Person owner;

        public Playlist(Person owner, string title) : base(title)
        {
            this.owner = owner;
        }

        public void Add(iPlayable playable)
        {
            Playables.Add(playable);
        }
    }
}
