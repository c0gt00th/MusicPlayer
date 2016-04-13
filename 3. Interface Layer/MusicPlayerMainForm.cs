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

namespace _3.Interface_Layer
{
    public partial class MusicPlayerMainForm : Form
    {
        private const string playingPrefix = "Playing: ";
        private Player player = new Player();

        public MusicPlayerMainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            labelCurrentSong.Text = playingPrefix;
        }

        private void UpdateCurrentSongLabel(string name)
        {
            labelCurrentSong.Text = playingPrefix + name;
        }

        #region Form Events

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            player.open(openFileDialog1.FileName);
            UpdateCurrentSongLabel(openFileDialog1.FileName);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.stop();
        }

        #endregion
    }
}
