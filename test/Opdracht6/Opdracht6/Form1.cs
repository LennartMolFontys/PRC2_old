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
        public Form1()
        {
            InitializeComponent();

        }

        private void bAddArtist_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(tbYear.Text);
            int month = Convert.ToInt32(tbMonth.Text);
            int day = Convert.ToInt32(tbDay.Text);

            player.AddArtist(new Artist(tbArtiest.Text, new DateTime(year, month, day)));
            foreach (Artist s in player.Artists)
            {
                MessageBox.Show(s.ToString());
            }
            FillArtistComboBox();
            
        }

        private void bAddSong_Click(object sender, EventArgs e)
        {
            int index = CbArtist.SelectedIndex;
            int year = Convert.ToInt32(tbSongYear.Text);
            
            foreach (Artist selectedArtist in player.Artists)
            {
                if (selectedArtist.Name == CbArtist.Text)
                {
                    player.Artists[index].Add(new Song(tbSong.Text, year, selectedArtist, "testPath"));
                    int i = player.Artists[index].Songs.Count - 1;
                    player.AddSong(player.Artists[index].Songs[i]);
                }
            }
            lbSongs.Items.Add(tbSong.Text);
            CbArtist.Items.Clear();
            FillSongsComboBox();
        }

        private void bRemovePlaylist_Click(object sender, EventArgs e)
        {
            player.RemovePlaylist(player.Playlists[cbPlaylistName.SelectedIndex]);
            FillPlaylistComboBox();
        }

        public void FillArtistComboBox()
        {
            foreach(Artist s in player.Artists)
            {
                CbArtist.Items.Add(s.Name);
            }
        }

        public void FillSongsComboBox()
        {
            foreach(Song s in player.Songs)
            {
                cbSelect.Items.Add(s.Name);
                cbSongs.Items.Add(s.Name);
            }
        }

        public void FillPlaylistComboBox()
        {
            if(player.Playlists.Count == 0)
            {
                cbPlaylistName.Items.Clear();
                cbPlaylistName.Text = "";
            }
            foreach (Playlist s in player.Playlists)
            {
                cbPlaylistName.Items.Add(s.Name);
            }
        }

        private void bPlaySong_Click(object sender, EventArgs e)
        {
            player.PlaySong(player.Songs[cbSelect.SelectedIndex]);
            lState.Text = String.Format("{0} made by {1} is now being played.", player.IsPlaying(), player.Songs[cbSelect.SelectedIndex].Artist.Name);
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
           player.Playlists[cbPlaylistName.SelectedIndex].AddSong(player.Songs[cbSongs.SelectedIndex]);

           lbPlaylistSongs.Items.Clear();
           foreach(Song s in player.Playlists[cbPlaylistName.SelectedIndex].Songs)
           {
                lbPlaylistSongs.Items.Add(s);
           }
        }

        private void bAddAllSongs_Click(object sender, EventArgs e)
        {

        }
    }
}
