using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class MusicFile
    {
        public string filepath { get; set; }
        public string filename { get; set; }

        public MusicFile(string path)
        {
            var info = new FileInfo(path);
            filepath = info.FullName;
            filename = info.Name;
        }
    }
}
