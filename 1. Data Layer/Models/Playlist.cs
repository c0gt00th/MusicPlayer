using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Data_Layer.Models
{
    class Playlist
    {
        public List<Song> Songs { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
