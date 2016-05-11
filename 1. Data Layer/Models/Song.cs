using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Data_Layer.Models
{
    public class Song
    {
        public int ID;
        public string Name;
        public FileInfo info;

        public Song(int id, string name, string path)
        {
            ID = id;
            Name = name;
            info = new FileInfo(path);
        }
    }
}
