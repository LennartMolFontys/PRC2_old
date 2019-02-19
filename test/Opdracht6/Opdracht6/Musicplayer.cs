using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Musicplayer
    {
        public List<Artist> Artists { get; private set; }
        public List<Song> Songs { get; private set; }
        public List<Playlist> Playlists { get; private set; }
        public bool stopPlaying { get; private set; }
        private Song CurrentSong;
        private Random nummer = new Random();

        public Musicplayer()
        {
            Artists = new List<Artist>();
            Songs = new List<Song>();
            Playlists = new List<Playlist>();
        }

        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }

        public void PlaySong(Song song)
        {
            stopPlaying = false;
            CurrentSong = song;
        }

        public void PlayPlaylist(Playlist playlist)
        {
            int i = nummer.Next(0, playlist.Songs.Count);
            CurrentSong = playlist.Songs[i];
        }

        public Song IsPlaying()
        {
            return CurrentSong;  
        }

        public void StopPlaying()
        {
            if(!stopPlaying)
            {
                stopPlaying = true;
            }
        }
    }
}
