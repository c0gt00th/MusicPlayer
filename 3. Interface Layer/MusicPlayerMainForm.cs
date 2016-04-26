using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.Brain_Layer;
using System.IO;

namespace _3.Interface_Layer
{
    public partial class MusicPlayerMainForm : Form
    {
        #region String Constants
        private const string playingPrefix = "Playing: ";
        #endregion

        private Player player = new Player();

        public MusicPlayerMainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            labelCurrentSong.Text = playingPrefix;
            btnPlay.Image = Properties.Resources.play;
        }

        private void UpdateCurrentSongLabel(string name)
        {
            var info = new FileInfo(name);
            labelCurrentSong.Text = playingPrefix + info.Name;
        }

        #region Form Events
        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            player.CurrentFile = openFileDialog1.FileName;
            UpdateCurrentSongLabel(openFileDialog1.FileName);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Play();
            SwapPlayPauseButtonImage();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            btnPlay.Image = Properties.Resources.play;
        }
        #endregion

        private void SwapPlayPauseButtonImage()
        {
            if (player.isPlaying)
            {
                btnPlay.Image = Properties.Resources.pause;
            }

            else
            {
                btnPlay.Image = Properties.Resources.play;
            }
        }
    }
}
