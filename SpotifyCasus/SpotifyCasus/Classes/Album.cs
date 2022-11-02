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

        public void ShowArtists()
        {
            foreach (Artist artist in artists)
            {
                Console.WriteLine(artist.ToString());
            }
        }

        public override string ToString()
        {
            string artistsString = "";

            foreach (Artist artist in artists)
            {
                artistsString += artist.Name + ", ";
            }

            return title + " | " + artistsString;
        }
    }
}
