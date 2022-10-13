using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Person
    {
        public string name;
        private List<Person> friends;
        private List<Playlist> playlists;

        public List<Playlist> Playlists { get => playlists; set => playlists = value; }

        public Person(string name)
        {
            this.name = name;
        }

        public List<Playlist> ShowPlaylists()
        {
            return playlists;
        }
    }
}
