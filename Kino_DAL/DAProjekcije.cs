using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAProjekcije
    {
        public static void GetProjekcijeByFilmID(DSProjekcije.ProjekcijeDataTable dtProjekcije, int filmId, DateTime? datumVrijemeOd, DateTime? datumVrijemeDo)
        {
            dtProjekcije.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Projekcije_SelectByFilmID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (filmId != 0)
                    cmd.Parameters.Add("@FilmID", SqlDbType.Int).Value = filmId;
                if (datumVrijemeOd != null)
                    cmd.Parameters.Add("@DatumVrijemeOd", SqlDbType.DateTime).Value = datumVrijemeOd;
                if (datumVrijemeDo != null)
                    cmd.Parameters.Add("@DatumVrijemeDo", SqlDbType.DateTime).Value = datumVrijemeDo;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProjekcije);
            }
            finally
            {

            }
        }
    }
}
