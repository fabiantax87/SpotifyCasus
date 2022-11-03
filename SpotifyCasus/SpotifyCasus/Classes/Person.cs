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
        internal List<Person> friends;
        private List<Playlist> playlists;

        public List<Person> Friends { get { return friends; } set { friends = value; } }
        public List<Playlist> Playlists { get { return playlists; } set { playlists = value; } }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowFriends()
        {
            foreach (Person friend in friends)
            {
                Console.WriteLine(friend.name);
            }
        }

        public void ShowPlaylists()
        {
            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine(playlist.title);
            }
        }

        public Playlist SelectPlaylist(int index)
        {
            return playlists[index];
        }

        public override string ToString()
        {
            string friendsString = "";
            string playlistsString = "";

            foreach (Person person in friends)
            {
                friendsString += person.name + ", ";
            }

            foreach (Playlist playlist in playlists)
            {
                playlistsString += playlist.title + ", ";
            }

            return name + " | " + friendsString + " | " + playlistsString;
        }
    }
}
