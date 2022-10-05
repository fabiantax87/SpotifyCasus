using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Client : IPlayable
    {
        private string currentlyPlaying;
        private int currentTime;
        private bool playing;
        private bool shuffle;
        private bool repeat;

        public string CurrentlyPlaying { get { return currentlyPlaying; } set { currentlyPlaying = value; } }
        public int CurrentTime { get { return currentTime; } set { currentTime = value; } }
        public bool Playing { get { return playing; } set { playing = value; } }
        public bool Shuffle { get { return shuffle; } set { shuffle = value; } }
        public bool Repeat { get { return repeat; } set { repeat = value; } }

        public Client(List<Person> personen, List<Album> albums, List<Song> songs)
        {

        }
    }
}
