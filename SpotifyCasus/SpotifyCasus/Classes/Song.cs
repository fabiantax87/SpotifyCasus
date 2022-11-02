using SpotifyCasus.Enums;
using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class Song : iPlayable
    {
        private string title;
        private List<Artist> artists;
        private Genre songGenre;

        public string Title { get { return title; } set { title = value; } }
        public List<Artist> Artists { get { return artists; } set { artists = value; } }
        public Genre SongGenre { get { return songGenre; } set { songGenre = value; } }

        private int length;

        public Song(string title, List<Artist> artists, int length, Genre songGenre)
        {
            this.title = title;
            this.artists = artists;
            this.length = length;
            this.songGenre = songGenre;
        }

        public override string ToString()
        {
            return title + " | " + songGenre + " | " + length;
        }

        public void Play()
        {
            Console.WriteLine("Currently playing: " + title);
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }
    }
}
