using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Playlist
    {
        public string Name { get; private set; }
        public List<Song> Songs { get; private set; }

        public Playlist(string name)
        {
            this.Name = name;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddSongs(List<Song> songs)
        {
            foreach(Song s in songs)
            {
                Songs.Add(s);
            }
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
