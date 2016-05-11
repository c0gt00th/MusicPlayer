using _1.Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Brain_Layer.ViewModels
{
    public class PlaylistVM
    {
        public List<SongVM> Songs { get; set; }
        public SongVM CurrentSong { get; set; }

        public PlaylistVM()
        {
            Songs = new List<SongVM>();
        }

        public PlaylistVM(Playlist newPlaylist)
        {

        }

        public void AddSong(string path)
        {
            var newSong = new SongVM(path);
            Songs.Add(newSong);
        }

        public void AddSong(SongVM newSong)
        {
            Songs.Add(newSong);
        }

        public void SetCurrentSong()
        {
            if (Songs.Count == 1)
            {
                CurrentSong = Songs[0];
            }
        }
    }
}
