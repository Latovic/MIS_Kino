using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAFilmovi
    {
        public static void GetFilmoviAll(DSFilmovi.FilmoviDataTable dtFilmovi)
        {
            dtFilmovi.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Filmovi_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtFilmovi);
            }
            finally
            {

            }
        }

        public static void GetFilmoviByNGRZ(DSFilmovi.FilmoviDataTable dtFilmovi, string naziv, string godina, string reziser, int zanrId)
        {
            dtFilmovi.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Filmovi_SelectByNGRZ", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (naziv != "")
                    cmd.Parameters.Add("@Naziv", SqlDbType.NVarChar).Value = naziv;
                if(godina != "")
                    cmd.Parameters.Add("@GodinaProizvodnje", SqlDbType.Int).Value = Convert.ToInt32(godina);
                if (reziser != "")
                    cmd.Parameters.Add("@Reziser", SqlDbType.NVarChar).Value = reziser;
                if (zanrId != 0)
                    cmd.Parameters.Add("@ZanrId", SqlDbType.Int).Value = zanrId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtFilmovi);
            }
            finally
            {

            }
        }

        public static void GetAllZanrovi(DSFilmovi.ZanroviDataTable dtZanrovi)
        {
            dtZanrovi.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Zanrovi_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtZanrovi);

            }
            finally
            {
                cn.Close();
            }
        }
    }
}
