using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Data_Layer.Models
{
    class Song
    {
        private int id;
        private string name;
        private FileInfo info;
        
        public Song(string path)
        {
            info = new FileInfo(path);
        }

        public Song(int id, string name, string path)
        {
            this.id = id;
            this.name = name;
            info = new FileInfo(path);
        }
    }
}
