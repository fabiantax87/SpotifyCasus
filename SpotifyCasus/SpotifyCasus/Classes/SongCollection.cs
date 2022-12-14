using SpotifyCasus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCasus.Classes
{
    internal class SongCollection : iPlayable
    {
        public string title;
        private List<iPlayable> playables;
        private int length;

        public List<iPlayable> Playables { get { return playables; } set { playables = value; } }

        public SongCollection(string title)
        {
            this.title = title;
            this.playables = new List<iPlayable>();
        }

        public void Play()
        {
            foreach (iPlayable playable in playables)
            {
                playable.Play();
            }
        }

        public void Pause()
        {
            Console.WriteLine("Paused: " + title);
        }

        public void Stop()
        {
            Console.WriteLine("Stopped: " + title);
        }

        public void Next()
        {
            Play();
        }

        public void Length()
        {
            Console.Write(length);
        }

        public override string ToString()
        {
            return title;
        }

        public void ShowPlayables()
        {
            foreach (iPlayable playable in playables)
            {
                Console.WriteLine(playable.ToString());
            }
        }
    }
}
