using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Album : SongCollection
    {
        public string title;
        private List<Artist> artists;
        private List<Song> songs;

        public Album(List<Artist> artists, string title, List<Song> songs) : base(title)
        {
            this.title = title;
            this.artists = artists;
            this.songs = songs;
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
