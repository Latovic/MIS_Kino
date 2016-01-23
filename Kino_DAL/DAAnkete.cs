using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAAnkete
    {
        public static void GetAnketeByPitanje(DSAnkete.AnketeDataTable dtAnkete, string pitanje)
        {
            dtAnkete.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Ankete_SelectByPitanje", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (pitanje != "")
                    cmd.Parameters.Add("@Pitanje", SqlDbType.NVarChar).Value = pitanje;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtAnkete);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetRezultateByAnketaID(DSAnkete.RezultatiAnketeDataTable dtRezultatiAnkete, int anketaId)
        {
            dtRezultatiAnkete.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_RezultatiAnkete_SelectByAnketaID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (anketaId != 0)
                    cmd.Parameters.Add("@AnketaID", SqlDbType.Int).Value = anketaId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRezultatiAnkete);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
