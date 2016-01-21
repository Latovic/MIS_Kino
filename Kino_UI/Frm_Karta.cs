using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kino_DAL;

namespace Kino_UI
{
    public partial class Frm_Karta : Form
    {
        DSKarte dsKarte = new DSKarte();
        int klijentID;
        int filmID;
        bool is3d;

        public Frm_Karta()
        {
            InitializeComponent();
        }

        private void Frm_Karte_Load(object sender, EventArgs e)
        {
            Trazi(null, null);

            DAKarte.getSveKorisnike(dsKarte.Korisnici);
            DSKarte.KorisniciRow korisnik = dsKarte.Korisnici.NewKorisniciRow();
            korisnik.Id = 0;
            korisnik.KorisnickoIme = "Odaberite ime";
            dsKarte.Korisnici.Rows.InsertAt(korisnik, 0);

            cbxZaposlenik.DataSource = dsKarte.Korisnici;
            cbxZaposlenik.ValueMember = "Id";
            cbxZaposlenik.DisplayMember = "KorisnickoIme";


            DAKarte.getSveFilmove(dsKarte.Filmovi);
            DSKarte.FilmoviRow film = dsKarte.Filmovi.NewFilmoviRow();
            film.Id = 0;
            film.Naziv = "Odaberite film";
            dsKarte.Filmovi.Rows.InsertAt(film, 0);

            cbxFilm.DataSource = dsKarte.Filmovi;
            cbxFilm.ValueMember = "Id";
            cbxFilm.DisplayMember = "Naziv";
        }

        private void Trazi(object sender, EventArgs e)
        {

            DAKarte.getKarte(dsKarte.Karte, klijentID, filmID, is3d);
            dgKarte.AutoGenerateColumns = false;
            dgKarte.DataSource = dsKarte.Karte;
            lbl_BrojKarti.Text = dsKarte.Karte.Count.ToString();
        }

        private void cbxZaposlenik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            klijentID = Convert.ToInt32(cbxZaposlenik.SelectedValue);
            Trazi(null, null);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filmID = Convert.ToInt32(cbxFilm.SelectedValue);
            Trazi(null, null);
        }

        private void cBox3D_CheckedChanged(object sender, EventArgs e)
        {
            is3d = Convert.ToBoolean(cBox3D.Checked);
            Trazi(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_KarteReport frm = new Reports.Frm_KarteReport(dsKarte.Karte);
            frm.ShowDialog();
        }
    }
}
