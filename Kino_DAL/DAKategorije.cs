using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAKategorije
    {
        public static void getKategorijeByNaziv(DSKategorije.KategorijeProizvodaDataTable dtKategorije, string nazivKategorije, string nazivProizvoda)
        {
            dtKategorije.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_KategorijeByNaziv333", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (nazivKategorije != "")
                    cmd.Parameters.Add("@naziv", SqlDbType.NVarChar).Value = nazivKategorije;

                if (nazivProizvoda != "")
                    cmd.Parameters.Add("@nazivProizvoda", SqlDbType.NVarChar).Value = nazivProizvoda;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKategorije);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
