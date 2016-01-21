using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAMenadzeri
    {
        public static int ProvjeraKorisnika(string username, string password)
        {
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ProvjeraKorisnika", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (username != "")
                    cmd.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar).Value = username;
                if (password != "")
                    cmd.Parameters.Add("@Lozinka", SqlDbType.NVarChar).Value = password;
                int ret = Convert.ToInt32(cmd.ExecuteScalar());

                return ret;

            }
            finally
            {
                cn.Close();
            }
        }
    }
}
