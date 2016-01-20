using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_DAL
{
    public class DAKlijenti
    {
        public static void GetAllKlijentiByImePrezime(DSKlijenti.KlijentiDataTable dtKlijenti, string ime, string prezime, string korisnickoIme, int opcinaId)
        {
            dtKlijenti.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Klijenti_SelectByImePrezime", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (ime != "")
                    cmd.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = ime;
                if (prezime != "")
                    cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar).Value = prezime;
                if (korisnickoIme != "")
                    cmd.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar).Value = korisnickoIme;
                if (opcinaId != 0)
                    cmd.Parameters.Add("@OpcinaId", SqlDbType.Int).Value = opcinaId;
                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKlijenti);
            }
            finally
            {
                cn.Close();
            }
        }        

        public static void GetAllOpcine(DSKlijenti.OpcineDataTable dtOpcine)
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

        public static void SelectRegistracije(DSKlijenti.RegistracijeDataTable dtRegistracije)
        {
            dtRegistracije.Clear();
            SqlConnection cn = Connection.GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Klijenti_RegistrovaniByGodinaMjesec", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRegistracije);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
