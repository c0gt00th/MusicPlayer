using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Brain_Layer
{
    public class Player
    {
        #region Private Variables
        [DllImport("winmm.dll")]
        private static extern long mciSendString (string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);
        
        #endregion

        #region Public Variables
        public string CurrentFile { get; set; }
        public bool isPlaying;
        #endregion

        public Player ()
        {
            
        }

        public void Play()
        {
            if (String.IsNullOrEmpty(CurrentFile))
            {
                throw new NotImplementedException();
            }

            string command;
            command = "open \"" + CurrentFile + "\" type MPEGVideo alias file";
            mciSendString(command, null, 0, 0);

            if (isPlaying)
            {
                command = "stop file";
                mciSendString(command, null, 0, 0);
            }

            else
            {
                command = "play file";
                mciSendString(command, null, 0, 0);
            }

            isPlaying = !isPlaying;
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = !isPlaying;
            }

            string command = "stop file";
            mciSendString(command, null, 0, 0);

            command = "close file";
            mciSendString(command, null, 0, 0);
        }
    }
}
