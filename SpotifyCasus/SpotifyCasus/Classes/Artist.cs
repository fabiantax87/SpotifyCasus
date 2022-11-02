using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Artist
    {
        private string name;
        private List<Song> songs;
        private List<Album> albums;

        public string Name { get { return name; } set { name = value; } }

        public Artist(string name)
        {
            this.name = name;
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public override string ToString()
        {
            return "Name: " + name;
        }
    }
}