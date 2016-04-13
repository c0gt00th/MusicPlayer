using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Data_Layer.Models
{
    class Song
    {
        public string filepath { get; set; }
        public string filename { get; set; }

        public Song (string path)
        {
            var info = new FileInfo(path);
            filepath = info.FullName;
            filename = info.Name;
        }
    }
}
