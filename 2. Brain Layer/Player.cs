using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _2.Brain_Layer.ViewModels;
using _3.Interface_Layer;
using _4.MCI;

namespace _2.Brain_Layer
{
    public class Player
    {
        #region Private Variables
        private MusicPlayerMainForm mainForm;
        private PlaylistVM currentPlaylist;
        private SongVM currentSong;
        private bool isPlaying;
        #endregion

        public Player ()
        {
            mainForm = new MusicPlayerMainForm();
            currentPlaylist = new PlaylistVM();
            isPlaying = false;
            InitializeEvents();

            mainForm.ShowDialog();
        }

        private void InitializeEvents()
        {
            mainForm.OpenSong += mainForm_OpenSong;
            mainForm.PlayPauseSong += mainForm_PlayPauseSong;
            mainForm.StopSong += mainForm_StopSong;
        }

        #region Event Methods
        private void mainForm_OpenSong(object sender, EventArgs e)
        {
            var result = mainForm.OpenNewSong();

            if (result != null)
            {
                currentPlaylist.AddSong(result);
                currentPlaylist.SetCurrentSong();
                currentSong = currentPlaylist.CurrentSong;

                mainForm.UpdateCurrentSongLabel(currentPlaylist.CurrentSong.Name);
            }
        }

        private void mainForm_PlayPauseSong(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                try
                {
                    if (!isPlaying)
                    {
                        MCIController.SetCurrentSong(currentSong.Path);
                        MCIController.PlayCurrentSong();
                    }

                    else
                    {
                        MCIController.PauseCurrentSong();
                    }

                    isPlaying = !isPlaying;
                    mainForm.SwapPlayPauseButtonImage();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void mainForm_StopSong(object sender, EventArgs e)
        {
            isPlaying = false;
            MCIController.StopCurrentSong();
        }
        #endregion

        public void PlayRandom()
        {

        }
    }
}
