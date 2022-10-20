using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class SuperUser : Person
    {
        public SuperUser(string name) : base(name)
        {

        }

        public void CreatePlaylist(string title)
        {
            Playlist playlist = new Playlist(this, title);
            Playlists.Add(playlist);
        }

        public void RemovePlaylist(int index)
        {
            Playlists.RemoveAt(index);
        }

        public void AddFriend(Person person)
        {
            Friends.Add(person);
        }

        public void AddToPlaylist(iPlayable playable, int index)
        {
            Playlist selectedPlaylist = SelectPlaylist(index);
            selectedPlaylist.Add(playable);
        }
    }
}
