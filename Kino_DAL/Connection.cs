using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.db_MISConnectionString);
            cn.Open();
            return cn;
        }
    }
}
