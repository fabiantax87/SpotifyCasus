using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Album : SongCollection
    {
        private List<Artist> artists;

        public Album(List<Artist> artists, string title) : base(title)
        {
            this.artists = artists;
        }

        public List<Artist> ShowArtists()
        {
            return artists;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
