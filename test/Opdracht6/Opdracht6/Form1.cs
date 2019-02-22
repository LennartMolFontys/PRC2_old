using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6
{
    public partial class Form1 : Form
    {
        Musicplayer player = new Musicplayer();
        private int IndexArtist = 0;
        private int IndexComboBox = 0;
        private int IndexSong = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void bAddArtist_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(nudYear.Text);
            int month = Convert.ToInt32(nudMonth.Text);
            int day = Convert.ToInt32(nudDay.Text);

            player.AddArtist(new Artist(tbArtiest.Text, new DateTime(year, month, day)));

            FillArtistComboBoxAndList();
            
        }

        private void bAddSong_Click(object sender, EventArgs e)
        {
            IndexArtist = CbArtist.SelectedIndex; 
            int year = Convert.ToInt32(nudSongYear.Text);
            
            foreach (Artist selectedArtist in player.Artists)
            {
                if (selectedArtist.Name == CbArtist.Text)
                {
                    player.Artists[IndexArtist].Add(new Song(tbSong.Text, year, selectedArtist, "testPath"));
                    IndexSong = player.Artists[IndexArtist].Songs.Count - 1;
                    player.AddSong(player.Artists[IndexArtist].Songs[IndexSong]);
                    if(tbLyrics.Text == "")
                    {
                        player.Artists[IndexArtist].Songs[IndexSong].Lyrics = "";
                    }
                    else
                    {
                        player.Artists[IndexArtist].Songs[IndexSong].Lyrics = tbLyrics.Text;
                    }
                }
            }
            FillSongsComboBox();
        }

        private void bRemovePlaylist_Click(object sender, EventArgs e)
        {
            int removeIndex = cbPlaylistName.SelectedIndex;
            if (removeIndex < 0)
            {
                MessageBox.Show("Select a playlist.");
            }
            else
            {
                player.RemovePlaylist(player.Playlists[removeIndex]);
                FillPlaylistComboBox();
                FillSongsComboBox();
                lbPlaylistSongs.Items.Clear();
            }  
        }

        public void FillArtistComboBoxAndList()
        {
            CbArtist.Items.Clear();
            lbArtists.Items.Clear();
            foreach (Artist s in player.Artists)
            {
                CbArtist.Items.Add(s.Name);
                lbArtists.Items.Add(s.Name);
            }
        }

        public void FillSongsComboBox()
        {
            cbSongs.Items.Clear();
            lbSongs.Items.Clear();
            cbSelectSong.Items.Clear();
            foreach (Song s in player.Songs)
            {
                lbSongs.Items.Add(s.Name);
                cbSelectSong.Items.Add(s.Name);
                cbSongs.Items.Add(s.Name);
            }
        }

        public void FillPlaylistComboBox()
        {
            cbSelectPlaylist.Items.Clear();
            cbPlaylistName.Items.Clear();
            lbPlaylist.Items.Clear();

            if(player.Playlists.Count == 0)
            {
                cbPlaylistName.Items.Clear();
                cbPlaylistName.Text = "";
            }
            foreach (Playlist s in player.Playlists)
            {
                lbPlaylist.Items.Add(s.Name);
                cbSelectPlaylist.Items.Add(s.Name);
                cbPlaylistName.Items.Add(s.Name);
            }
        }

        private void bPlaySong_Click(object sender, EventArgs e)
        {
            IndexComboBox = cbSelectSong.SelectedIndex;
            if (IndexComboBox < 0)
            {
                MessageBox.Show("Select a song.");
            }
            else
            { 
                player.PlaySong(player.Songs[IndexComboBox]);
                lState.Text = String.Format("{0} made by {1} is now being played \n Lyrics: {3}.", player.IsPlaying(), player.Songs[IndexComboBox].Artist.Name);
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        { 
           player.StopPlaying();
           if (player.stopPlaying)
           {
             lState.Text = "No songs are currently playing.";
           }
        }

        private void bCreatePlaylist_Click(object sender, EventArgs e)
        {
            player.AddPlaylist(new Playlist(tbPlaylist.Text));
            FillPlaylistComboBox();
            
        }

        private void bAddSongToPlaylist_Click(object sender, EventArgs e)
        {
           IndexComboBox = cbPlaylistName.SelectedIndex;
            if (IndexComboBox < 0)
            {
                MessageBox.Show("Select a song that you want to remove.");
            }
            else
            {
                player.Playlists[IndexComboBox].AddSong(player.Songs[cbSongs.SelectedIndex]);
                FillPlaylistSongs();
                FillcbPlaylistSongs();
            }
                
        }

        private void bAddAllSongs_Click(object sender, EventArgs e)
        {
            IndexComboBox = cbPlaylistName.SelectedIndex;
            if (IndexComboBox < 0)
            {
                MessageBox.Show("Please select a playlist.");
            }
            else
            {
                player.Playlists[IndexComboBox].AddSongs(player.Songs);
                foreach (Song s in player.Songs)
                {
                    lbPlaylistSongs.Items.Add(s);
                }
                FillcbPlaylistSongs();
            }
        }

        private void bRemoveSongFromPlaylist_Click(object sender, EventArgs e)
        {
            int IndexPlaylist = cbPlaylistName.SelectedIndex;
            IndexSong = cbPlaylistSongs.SelectedIndex;
            if (IndexSong < 0)
            {
                MessageBox.Show("Select a song that you want to remove.");
            }
            else
            {
                player.Playlists[IndexPlaylist].RemoveSong(player.Playlists[IndexPlaylist].Songs[IndexSong]);
                FillPlaylistSongs();
                FillcbPlaylistSongs();
            }
        }

        public void FillcbPlaylistSongs()
        {
            cbPlaylistSongs.Items.Clear();
            for (int i = 0; i < lbPlaylistSongs.Items.Count; i++)
            {
                cbPlaylistSongs.Items.Add(lbPlaylistSongs.Items[i]);
            }
        }
        public void FillPlaylistSongs()
        {
            int IndexPlayList = cbPlaylistName.SelectedIndex;

            lbPlaylistSongs.Items.Clear();
            foreach (Song s in player.Playlists[IndexPlayList].Songs)
            {
                lbPlaylistSongs.Items.Add(s);
            }
        }

        private void cbPlaylistName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPlaylistSongs();
        }

        private void bStopPlaylist_Click(object sender, EventArgs e)
        {
            player.StopPlaying();
            if (player.stopPlaying)
            {
                lState.Text = "No songs are currently playing.";
            }
        }

        private void bPlayPlaylist_Click(object sender, EventArgs e)
        {
            IndexComboBox = cbSelectPlaylist.SelectedIndex;
            if (IndexComboBox < 0)
            {
                MessageBox.Show("Select a playlist.");
            }
            else
            {
                player.PlayPlaylist(player.Playlists[IndexComboBox]);
                lState.Text = String.Format("{0} made by {1} is now being played.", player.IsPlaying(), player.IsPlaying().Artist.Name);
            }
        }
    }
}
