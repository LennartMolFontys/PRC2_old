namespace Opdracht6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAddArtist = new System.Windows.Forms.Button();
            this.tbArtiest = new System.Windows.Forms.TextBox();
            this.tbSong = new System.Windows.Forms.TextBox();
            this.bRemovePlaylist = new System.Windows.Forms.Button();
            this.cbSongs = new System.Windows.Forms.ComboBox();
            this.bPlaySong = new System.Windows.Forms.Button();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLyrics = new System.Windows.Forms.TextBox();
            this.CbArtist = new System.Windows.Forms.ComboBox();
            this.bAddSong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSongYear = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bRemoveSongFromPlaylist = new System.Windows.Forms.Button();
            this.bAddSongToPlaylist = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPlaylistSongs = new System.Windows.Forms.ListBox();
            this.cbPlaylistSongs = new System.Windows.Forms.ComboBox();
            this.bAddAllSongs = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPlaylistName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bCreatePlaylist = new System.Windows.Forms.Button();
            this.tbPlaylist = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.Artists = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.lState = new System.Windows.Forms.Label();
            this.cbSelectSong = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSelectPlaylist = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddArtist
            // 
            this.bAddArtist.Location = new System.Drawing.Point(74, 74);
            this.bAddArtist.Name = "bAddArtist";
            this.bAddArtist.Size = new System.Drawing.Size(100, 23);
            this.bAddArtist.TabIndex = 0;
            this.bAddArtist.Text = "Add";
            this.bAddArtist.UseVisualStyleBackColor = true;
            this.bAddArtist.Click += new System.EventHandler(this.bAddArtist_Click);
            // 
            // tbArtiest
            // 
            this.tbArtiest.Location = new System.Drawing.Point(74, 19);
            this.tbArtiest.Name = "tbArtiest";
            this.tbArtiest.Size = new System.Drawing.Size(100, 20);
            this.tbArtiest.TabIndex = 1;
            this.tbArtiest.Text = "Jeffrey";
            // 
            // tbSong
            // 
            this.tbSong.Location = new System.Drawing.Point(74, 53);
            this.tbSong.Name = "tbSong";
            this.tbSong.Size = new System.Drawing.Size(100, 20);
            this.tbSong.TabIndex = 2;
            this.tbSong.Text = "Halelujah";
            // 
            // bRemovePlaylist
            // 
            this.bRemovePlaylist.Location = new System.Drawing.Point(207, 19);
            this.bRemovePlaylist.Name = "bRemovePlaylist";
            this.bRemovePlaylist.Size = new System.Drawing.Size(75, 23);
            this.bRemovePlaylist.TabIndex = 3;
            this.bRemovePlaylist.Text = "Remove";
            this.bRemovePlaylist.UseVisualStyleBackColor = true;
            this.bRemovePlaylist.Click += new System.EventHandler(this.bRemovePlaylist_Click);
            // 
            // cbSongs
            // 
            this.cbSongs.FormattingEnabled = true;
            this.cbSongs.Location = new System.Drawing.Point(166, 60);
            this.cbSongs.Name = "cbSongs";
            this.cbSongs.Size = new System.Drawing.Size(113, 21);
            this.cbSongs.TabIndex = 4;
            // 
            // bPlaySong
            // 
            this.bPlaySong.Location = new System.Drawing.Point(18, 64);
            this.bPlaySong.Name = "bPlaySong";
            this.bPlaySong.Size = new System.Drawing.Size(75, 23);
            this.bPlaySong.TabIndex = 5;
            this.bPlaySong.Text = "Play";
            this.bPlaySong.UseVisualStyleBackColor = true;
            this.bPlaySong.Click += new System.EventHandler(this.bPlaySong_Click);
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(74, 48);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(23, 20);
            this.tbDay.TabIndex = 6;
            this.tbDay.Text = "20";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(130, 48);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(44, 20);
            this.tbYear.TabIndex = 8;
            this.tbYear.Text = "2000";
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(103, 48);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(23, 20);
            this.tbMonth.TabIndex = 9;
            this.tbMonth.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbDay);
            this.groupBox1.Controls.Add(this.bAddArtist);
            this.groupBox1.Controls.Add(this.tbArtiest);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthdate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artist name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbLyrics);
            this.groupBox2.Controls.Add(this.CbArtist);
            this.groupBox2.Controls.Add(this.bAddSong);
            this.groupBox2.Controls.Add(this.tbSong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSongYear);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 225);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Song";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Artist name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lyrics:";
            // 
            // tbLyrics
            // 
            this.tbLyrics.Location = new System.Drawing.Point(74, 105);
            this.tbLyrics.Multiline = true;
            this.tbLyrics.Name = "tbLyrics";
            this.tbLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLyrics.Size = new System.Drawing.Size(163, 80);
            this.tbLyrics.TabIndex = 10;
            // 
            // CbArtist
            // 
            this.CbArtist.FormattingEnabled = true;
            this.CbArtist.Location = new System.Drawing.Point(74, 25);
            this.CbArtist.Name = "CbArtist";
            this.CbArtist.Size = new System.Drawing.Size(102, 21);
            this.CbArtist.TabIndex = 9;
            // 
            // bAddSong
            // 
            this.bAddSong.Location = new System.Drawing.Point(74, 191);
            this.bAddSong.Name = "bAddSong";
            this.bAddSong.Size = new System.Drawing.Size(100, 23);
            this.bAddSong.TabIndex = 0;
            this.bAddSong.Text = "Add";
            this.bAddSong.UseVisualStyleBackColor = true;
            this.bAddSong.Click += new System.EventHandler(this.bAddSong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Song name:";
            // 
            // tbSongYear
            // 
            this.tbSongYear.Location = new System.Drawing.Point(74, 79);
            this.tbSongYear.Name = "tbSongYear";
            this.tbSongYear.Size = new System.Drawing.Size(44, 20);
            this.tbSongYear.TabIndex = 8;
            this.tbSongYear.Text = "2005";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(470, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 369);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Playlist";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bRemoveSongFromPlaylist);
            this.groupBox5.Controls.Add(this.bAddSongToPlaylist);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lbPlaylistSongs);
            this.groupBox5.Controls.Add(this.bRemovePlaylist);
            this.groupBox5.Controls.Add(this.cbPlaylistSongs);
            this.groupBox5.Controls.Add(this.bAddAllSongs);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cbPlaylistName);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbSongs);
            this.groupBox5.Location = new System.Drawing.Point(9, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 267);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit playlist";
            // 
            // bRemoveSongFromPlaylist
            // 
            this.bRemoveSongFromPlaylist.Location = new System.Drawing.Point(180, 239);
            this.bRemoveSongFromPlaylist.Name = "bRemoveSongFromPlaylist";
            this.bRemoveSongFromPlaylist.Size = new System.Drawing.Size(99, 23);
            this.bRemoveSongFromPlaylist.TabIndex = 22;
            this.bRemoveSongFromPlaylist.Text = "Remove";
            this.bRemoveSongFromPlaylist.UseVisualStyleBackColor = true;
            this.bRemoveSongFromPlaylist.Click += new System.EventHandler(this.bRemoveSongFromPlaylist_Click);
            // 
            // bAddSongToPlaylist
            // 
            this.bAddSongToPlaylist.Location = new System.Drawing.Point(166, 87);
            this.bAddSongToPlaylist.Name = "bAddSongToPlaylist";
            this.bAddSongToPlaylist.Size = new System.Drawing.Size(113, 23);
            this.bAddSongToPlaylist.TabIndex = 21;
            this.bAddSongToPlaylist.Text = "Add";
            this.bAddSongToPlaylist.UseVisualStyleBackColor = true;
            this.bAddSongToPlaylist.Click += new System.EventHandler(this.bAddSongToPlaylist_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Remove song:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Songs in playlist:";
            // 
            // lbPlaylistSongs
            // 
            this.lbPlaylistSongs.FormattingEnabled = true;
            this.lbPlaylistSongs.Location = new System.Drawing.Point(9, 63);
            this.lbPlaylistSongs.Name = "lbPlaylistSongs";
            this.lbPlaylistSongs.Size = new System.Drawing.Size(90, 199);
            this.lbPlaylistSongs.TabIndex = 19;
            // 
            // cbPlaylistSongs
            // 
            this.cbPlaylistSongs.FormattingEnabled = true;
            this.cbPlaylistSongs.Location = new System.Drawing.Point(180, 212);
            this.cbPlaylistSongs.Name = "cbPlaylistSongs";
            this.cbPlaylistSongs.Size = new System.Drawing.Size(99, 21);
            this.cbPlaylistSongs.TabIndex = 18;
            // 
            // bAddAllSongs
            // 
            this.bAddAllSongs.Location = new System.Drawing.Point(105, 147);
            this.bAddAllSongs.Name = "bAddAllSongs";
            this.bAddAllSongs.Size = new System.Drawing.Size(179, 23);
            this.bAddAllSongs.TabIndex = 16;
            this.bAddAllSongs.Text = "Add all songs from musicplayer";
            this.bAddAllSongs.UseVisualStyleBackColor = true;
            this.bAddAllSongs.Click += new System.EventHandler(this.bAddAllSongs_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Select playlist:";
            // 
            // cbPlaylistName
            // 
            this.cbPlaylistName.FormattingEnabled = true;
            this.cbPlaylistName.Location = new System.Drawing.Point(88, 20);
            this.cbPlaylistName.Name = "cbPlaylistName";
            this.cbPlaylistName.Size = new System.Drawing.Size(113, 21);
            this.cbPlaylistName.TabIndex = 14;
            this.cbPlaylistName.SelectedIndexChanged += new System.EventHandler(this.cbPlaylistName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add song:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bCreatePlaylist);
            this.groupBox4.Controls.Add(this.tbPlaylist);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(9, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 74);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create new playlist";
            // 
            // bCreatePlaylist
            // 
            this.bCreatePlaylist.Location = new System.Drawing.Point(80, 43);
            this.bCreatePlaylist.Name = "bCreatePlaylist";
            this.bCreatePlaylist.Size = new System.Drawing.Size(101, 23);
            this.bCreatePlaylist.TabIndex = 16;
            this.bCreatePlaylist.Text = "Create";
            this.bCreatePlaylist.UseVisualStyleBackColor = true;
            this.bCreatePlaylist.Click += new System.EventHandler(this.bCreatePlaylist_Click);
            // 
            // tbPlaylist
            // 
            this.tbPlaylist.Location = new System.Drawing.Point(80, 19);
            this.tbPlaylist.Name = "tbPlaylist";
            this.tbPlaylist.Size = new System.Drawing.Size(100, 20);
            this.tbPlaylist.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Playlist name:";
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(6, 168);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(161, 108);
            this.lbSongs.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbPlaylist);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.lbArtists);
            this.groupBox6.Controls.Add(this.lbSongs);
            this.groupBox6.Controls.Add(this.Artists);
            this.groupBox6.Location = new System.Drawing.Point(277, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 411);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Musicplayer";
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.Location = new System.Drawing.Point(9, 297);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(161, 108);
            this.lbPlaylist.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = " playlist";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Songs";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(6, 36);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(161, 108);
            this.lbArtists.TabIndex = 15;
            // 
            // Artists
            // 
            this.Artists.AutoSize = true;
            this.Artists.Location = new System.Drawing.Point(6, 20);
            this.Artists.Name = "Artists";
            this.Artists.Size = new System.Drawing.Size(35, 13);
            this.Artists.TabIndex = 14;
            this.Artists.Text = "Artists";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(100, 64);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 15;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(301, 520);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(152, 13);
            this.lState.TabIndex = 16;
            this.lState.Text = "No songs are currently playing.";
            this.lState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectSong
            // 
            this.cbSelectSong.FormattingEnabled = true;
            this.cbSelectSong.Location = new System.Drawing.Point(18, 31);
            this.cbSelectSong.Name = "cbSelectSong";
            this.cbSelectSong.Size = new System.Drawing.Size(158, 21);
            this.cbSelectSong.TabIndex = 17;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbSelectSong);
            this.groupBox7.Controls.Add(this.bPlaySong);
            this.groupBox7.Controls.Add(this.bStop);
            this.groupBox7.Location = new System.Drawing.Point(32, 421);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(196, 113);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PlaySong";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.cbSelectPlaylist);
            this.groupBox8.Location = new System.Drawing.Point(560, 421);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Size = new System.Drawing.Size(196, 113);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "PlayPlaylist";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSelectPlaylist
            // 
            this.cbSelectPlaylist.FormattingEnabled = true;
            this.cbSelectPlaylist.Location = new System.Drawing.Point(22, 31);
            this.cbSelectPlaylist.Name = "cbSelectPlaylist";
            this.cbSelectPlaylist.Size = new System.Drawing.Size(158, 21);
            this.cbSelectPlaylist.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 719);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddArtist;
        private System.Windows.Forms.TextBox tbArtiest;
        private System.Windows.Forms.TextBox tbSong;
        private System.Windows.Forms.Button bRemovePlaylist;
        private System.Windows.Forms.ComboBox cbSongs;
        private System.Windows.Forms.Button bPlaySong;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSongYear;
        private System.Windows.Forms.Button bAddSong;
        private System.Windows.Forms.ComboBox CbArtist;
        private System.Windows.Forms.TextBox tbLyrics;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPlaylist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bCreatePlaylist;
        private System.Windows.Forms.ComboBox cbPlaylistName;
        private System.Windows.Forms.ComboBox cbPlaylistSongs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bAddAllSongs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.Label Artists;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Button bRemoveSongFromPlaylist;
        private System.Windows.Forms.Button bAddSongToPlaylist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbPlaylistSongs;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.ComboBox cbSelectSong;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSelectPlaylist;
    }
}

