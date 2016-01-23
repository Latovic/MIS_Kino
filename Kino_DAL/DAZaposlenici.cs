using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAZaposlenici
    {
        public static void GetZaposlenikeByImePrezimeOpcina(DSZaposlenici.ZaposleniciDataTable dtZaposlenici, string ime, string prezime, int opcinaId)
        {
            dtZaposlenici.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Zaposlenici_SelectByImePrezimeOpcina", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (ime != "")
                    cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = ime;
                if (prezime != "")
                    cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = prezime;
                if (opcinaId != 0)
                    cmd.Parameters.Add("@OpcinaId", SqlDbType.Int).Value = opcinaId;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtZaposlenici);
            }
            finally
            {
                cn.Close();
            }
        }


        public static void GetAllOpcine(DSZaposlenici.OpcineDataTable dtOpcine)
        {
            dtOpcine.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Opcina_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOpcine);

            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetKarteByZaposlenikID(DSZaposlenici.KarteDataTable dtKarte, int zaposlenikId, DateTime? datumVrijemeOd, DateTime? datumVrijemeDo)
        {
            dtKarte.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Karte_SelectByZaposlenikID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (zaposlenikId != 0)
                    cmd.Parameters.Add("@ZaposlenikID", SqlDbType.Int).Value = zaposlenikId;
                if (datumVrijemeOd != null)
                    cmd.Parameters.Add("@DatumVrijemeOd", SqlDbType.DateTime).Value = datumVrijemeOd;
                if (datumVrijemeDo != null)
                    cmd.Parameters.Add("@DatumVrijemeDo", SqlDbType.DateTime).Value = datumVrijemeDo;

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
