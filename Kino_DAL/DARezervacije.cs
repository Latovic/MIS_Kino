using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DARezervacije
    {
        public static void GetAllRezervacijeByKlijentID(DSRezervacije.RezervacijeDataTable dtRezervacije, int klijentId, DateTime? datumOd, DateTime? datumDo)
        {
            dtRezervacije.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_RezervacijeSelectByKlijentId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                if(klijentId != 0)
                    cmd.Parameters.Add("@KlijentId", SqlDbType.Int).Value = klijentId;
                if (datumOd != null)
                    cmd.Parameters.Add("@DatumOd", SqlDbType.Date).Value = datumOd;
                if(datumDo != null)
                    cmd.Parameters.Add("@DatumDo", SqlDbType.Date).Value = datumDo;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRezervacije);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetAllKarteByRezervacijaID(DSRezervacije.KarteDataTable dtKarte, int rezervacijaId)
        {
            dtKarte.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Karte_SelectByRezervacijaID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (rezervacijaId != 0)
                    cmd.Parameters.Add("@RezervacijaId", SqlDbType.Int).Value = rezervacijaId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKarte);
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
