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

        public SongCollection(string title)
        {
            this.title = title;
            this.playables = new List<iPlayable>();
        }

        public void Play()
        {
            int itemCount = playables.Count;
            Random rnd = new Random();
            int randomNum = rnd.Next(itemCount);
            playables[randomNum].Play();
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
