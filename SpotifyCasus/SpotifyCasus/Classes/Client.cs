﻿using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Client
    {
        public string currentlyPlaying;
        public int currentTime;
        public bool playing;
        public bool shuffle;
        public bool repeat;

        private SuperUser activeUser;
        private List<Person> allUsers;
        private List<Song> allSongs;

        public SuperUser ActiveUser { get { return activeUser; } set { activeUser = value; } }

        public Client(List<Person> personen, List<Album> albums, List<Song> songs)
        {
            this.allUsers = personen;
        }

        public void ShowAllUsers()
        {
            foreach (Person user in allUsers)
            {
                Console.WriteLine(user.name);
            }
        }

        public void CreatePlaylist(string title)
        {
            activeUser.CreatePlaylist(title);
        }

        public void RemovePlaylist(int index)
        {
            activeUser.RemovePlaylist(index);
        }

        public void ShowPlaylists()
        {
            List<Playlist> playlists = activeUser.ShowPlaylists();
            foreach(Playlist playlist in playlists)
            {
                Console.WriteLine(playlist.title);
            }
        }

        public void AddFriend(int index)
        {
            activeUser.Friends.Add(allUsers[index]);
        }

        public void ShowFriends()
        {
            List<Person> friends = activeUser.ShowFriends();
            foreach (Person friend in friends)
            {
                Console.WriteLine(friend.name);
            }
        }

        public void AddToPlaylist(iPlayable playable, int index)
        {
            activeUser.AddToPlaylist(playable, index);
        }

        public void RemoveFromPlaylist(iPlayable playable, int index)
        {
            activeUser.RemoveFromPlaylist(playable, index);
        }
    }
}
