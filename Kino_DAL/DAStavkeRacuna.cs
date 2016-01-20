using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAStavkeRacuna
    {
        public static void getStavkeRacuna(DSStavkeRacuna.StavkeIzlazaDataTable dtStavke, int izlazID, string naziv, string sifra)
        {
            dtStavke.Clear();

            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_StavkeIzlaza", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (naziv != "")
                    cmd.Parameters.Add("@naziv", SqlDbType.NVarChar).Value = naziv;
                if (sifra != "")
                    cmd.Parameters.Add("@sifra", SqlDbType.NVarChar).Value = sifra;

                if (izlazID != 0)
                    cmd.Parameters.Add("@izlazID", SqlDbType.Int).Value = izlazID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtStavke);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
