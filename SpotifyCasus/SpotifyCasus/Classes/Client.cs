using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Client
    {
        public iPlayable currentlyPlaying;
        public int currentTime;
        public bool playing;
        public bool shuffle;
        public bool repeat;

        private SuperUser activeUser;
        private List<Album> allAlbums;
        private List<Song> allSongs;
        private List<Person> allUsers;

        public SuperUser ActiveUser { get { return activeUser; } set { activeUser = value; } }

        public Client(List<Person> personen, List<Album> albums, List<Song> songs)
        {
            this.allUsers = personen;
            this.allAlbums = albums;
            this.allSongs = songs;
        }

        public void ShowAllAlbums()
        {
            foreach (Album album in allAlbums)
            {
                Console.WriteLine(album.title);
            }
        }

        public void SelectAlbum(int index)
        {
            Console.WriteLine(allAlbums[index].title);
        }

        public void ShowAllSongs()
        {
            foreach (Song song in allSongs)
            {
                Console.WriteLine(song);
            }
        }

        public void SelectSong(int index)
        {
            Console.WriteLine(allSongs[index].ToString());
        }

        public void ShowAllUsers()
        {
            foreach (Person user in allUsers)
            {
                Console.WriteLine(user.name);
            }
        }

        public void SelectUser(int index)
        {
            Console.WriteLine(allUsers[index].ToString());
        }

        public void ShowUserPlaylists(Person user)
        {
            foreach (Playlist playlist in user.ShowPlaylists())
            {
                Console.WriteLine(playlist);
            }
        }

        public void SelectUserPlaylist(Person user, int index)
        {
            user.SelectPlaylist(index);
        }

        public void Play()
        {
            currentlyPlaying.Play();
        }

        public void Pause()
        {
            currentlyPlaying.Pause();
        }

        public void Stop()
        {
            currentlyPlaying.Stop();
        }

        public void NextSong()
        {
            currentlyPlaying.Next();
        }

        public void SetShuffle(bool value)
        {
            shuffle = value;
        }

        public void SetRepeat(bool value)
        {
            repeat = value;
        }

        public void CreatePlaylist(string title)
        {
            activeUser.CreatePlaylist(title);
        }

        public void ShowPlaylists()
        {
            activeUser.ShowPlaylists();
        }

        public void SelectPlaylist(int index)
        {
            activeUser.SelectPlaylist(index);
        }

        public void RemovePlaylist(int index)
        {
            activeUser.RemovePlaylist(index);
        }

        public void AddToPlaylist(iPlayable playable, int index)
        {
            activeUser.AddToPlaylist(playable, index);
        }

        public void ShowSongsInPlaylist(Playlist playlist)
        {
            playlist.ShowPlayables();
        }

        public void RemoveFromPlaylist(iPlayable playable, int index)
        {
            activeUser.RemoveFromPlaylist(playable, index);
        }

        public void ShowFriends()
        {
            activeUser.ShowFriends();
        }

        public void SelectFriend(int index)
        {
            Console.WriteLine(activeUser.Friends[index].ToString());
        }

        public void AddFriend(int index)
        {
            activeUser.AddFriend(allUsers[index]);
        }

        public void RemoveFriend(int index)
        {
            activeUser.RemoveFriend(allUsers[index]);
        }
    }
}
