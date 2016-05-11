using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Data_Layer
{
    class SQLHandler
    {
        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"1.Data Layer\\MusicPlayer.mdf\";Integrated Security=True");
    }
}
