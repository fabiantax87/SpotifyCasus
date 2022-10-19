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

        public List<Person> Friends { get { return friends; } set { friends = value; } }
        public List<Playlist> Playlists { get { return playlists; } set { playlists = value; } }

        public Person(string name)
        {
            this.name = name;
        }

        public List<Playlist> ShowPlaylists()
        {
            return playlists;
        }

        public List<Person> ShowFriends()
        {
            return friends;
        }
    }
}
