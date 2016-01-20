using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAProizvodi
    {
        public static void getSveProizvodeByNazivSifra(DSProizvodi.ProizvodiDataTable dtProizvodi, string naziv, string sifra, int cijenaOd, int cijenaDo, int kategorijaID)
        {
            dtProizvodi.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Proizvodi_SelectByNazivSifra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (naziv != "")
                    cmd.Parameters.Add("@naziv", SqlDbType.NVarChar).Value = naziv;
                if (sifra != "")
                    cmd.Parameters.Add("@sifra", SqlDbType.NVarChar).Value = sifra;

                cmd.Parameters.Add("@cijenaOd", SqlDbType.Real).Value = cijenaOd;
                cmd.Parameters.Add("@cijenaDo", SqlDbType.Real).Value = cijenaDo;
                if (kategorijaID != 0)
                    cmd.Parameters.Add("@kategorijaId", SqlDbType.Int).Value = kategorijaID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProizvodi);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void getSveKategorije(DSProizvodi.KategorijeProizvodaDataTable dtKategorije)
        {
            dtKategorije.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Kategorije_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
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
