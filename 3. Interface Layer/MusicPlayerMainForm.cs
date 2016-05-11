using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3.Interface_Layer
{
    public partial class MusicPlayerMainForm : Form
    {
        #region String Constants
        private const string playingPrefix = "Playing: ";
        private bool isPaused;
        #endregion

        #region Events
        public event EventHandler OpenSong;
        public event EventHandler PlayPauseSong;
        public event EventHandler StopSong;
        #endregion

        public MusicPlayerMainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            labelCurrentSong.Text = playingPrefix;
            btnPlay.Image = Properties.Resources.play;
            isPaused = false;
        }

        public void UpdateCurrentSongLabel(string name)
        {
            labelCurrentSong.Text = playingPrefix + name;
        }

        #region Open
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (OpenSong != null)
            {
                OpenSong(sender, e);
            }
        }

        public string OpenNewSong()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }

            return null;
        }
        #endregion

        #region Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (PlayPauseSong != null)
            {
                PlayPauseSong(sender, e);
            }
        }

        public void SwapPlayPauseButtonImage()
        {
            if (isPaused)
            {
                btnPlay.Image = Properties.Resources.play;
            }

            else
            {
                btnPlay.Image = Properties.Resources.pause;
            }

            isPaused = !isPaused;
        }
        #endregion

        #region Stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (StopSong != null)
            {
                StopSong(sender, e);
            }

            btnPlay.Image = Properties.Resources.play;
        }
        #endregion

        
    }
}
