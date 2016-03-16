using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class formMain : Form
    {
        private const string playingPrefix = "Playing: ";
        private MusicPlayer player = new MusicPlayer();
        private List<MusicFile> playlist;

        public formMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize ()
        {
            labelCurrentSong.Text = playingPrefix;

            playlist = new List<MusicFile>();
        }

        private void UpdateCurrentSongLabel (string name)
        {
            labelCurrentSong.Text = playingPrefix + name;
        }

        #region Form Events

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            playlist.Add(new MusicFile(openFileDialog1.FileName));

            UpdateCurrentSongLabel(playlist[0].filename);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            foreach (var song in playlist) {
                player.open(song.filepath);
                player.play();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.stop();
        }

        #endregion
    }
}
