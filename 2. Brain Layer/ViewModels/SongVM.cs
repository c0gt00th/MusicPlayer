using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Data_Layer.Models;
using System.IO;

namespace _2.Brain_Layer.ViewModels
{
    public class SongVM
    {
        public string Name;
        public string Path;
        public FileInfo Info;

        public SongVM(Song song)
        {
            
        }

        public SongVM(string path)
        {
            if (path == null) { throw new ArgumentNullException("Brain.SongVM.path - Line 22");  }
            Info = new FileInfo(path);
            Name = Info.Name;
            Path = Info.FullName;
        }
    }
}
