using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DARacuni
    {

        public static void getRacune(DSRacuni.IzlaziRobeDataTable dtRacuni, int zaposlenikID, string imePrezime, DateTime datumOD, DateTime datumDO)
        {
            dtRacuni.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_RacuniByZaposlenikDatum", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (imePrezime != "")
                    cmd.Parameters.Add("@imePrezime", SqlDbType.NVarChar).Value = imePrezime;

                if (zaposlenikID != 0)
                    cmd.Parameters.Add("@zaposlenikID", SqlDbType.Int).Value = zaposlenikID;

                cmd.Parameters.Add("@datumOd", SqlDbType.DateTime).Value = datumOD;
                cmd.Parameters.Add("@datumDo", SqlDbType.DateTime).Value = datumDO;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRacuni);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void getSveKorisnike(DSRacuni.KorisniciDataTable dtKorisnici)
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
    }
}
