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
    }
}
