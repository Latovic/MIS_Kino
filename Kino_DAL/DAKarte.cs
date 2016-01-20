using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAKarte
    {
        public static void getKarte(DSKarte.KarteDataTable dtKarte, int klijentID, int filmID, bool is3d)
        {
            dtKarte.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Karte", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (klijentID != 0)
                    cmd.Parameters.Add("@klijentID", SqlDbType.Int).Value = klijentID;

                if (filmID != 0)
                    cmd.Parameters.Add("@filmID", SqlDbType.Int).Value = filmID;

                if (is3d != false)
                    cmd.Parameters.Add("@is3d", SqlDbType.Bit).Value = is3d;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKarte);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void getSveKorisnike(DSKarte.KorisniciDataTable dtKorisnici)
        {
            dtKorisnici.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Korisnici", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKorisnici);

            }
            finally
            {
                cn.Close();
            }
        }

        public static void getSveFilmove(DSKarte.FilmoviDataTable dtFilmovi)
        {
            dtFilmovi.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Filmovi", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtFilmovi);

            }
            finally
            {
                cn.Close();
            }
        }
    }
}
