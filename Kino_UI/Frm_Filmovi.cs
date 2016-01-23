using Kino_DAL;
using Kino_UI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino_UI
{
    public partial class Frm_Filmovi : Form
    {
        DSFilmovi dsFilmovi = new DSFilmovi();

        public Frm_Filmovi()
        {
            InitializeComponent();
        }

        private void Frm_Filmovi_Load(object sender, EventArgs e)
        {
            Pretraga(null, null);

            DAFilmovi.GetAllZanrovi(dsFilmovi.Zanrovi);
            DSFilmovi.ZanroviRow zanr = dsFilmovi.Zanrovi.NewZanroviRow();
            zanr.Id = 0;
            zanr.Naziv = "Izaberite žanr";
            dsFilmovi.Zanrovi.Rows.InsertAt(zanr, 0);

            cbxZanrovi.DataSource = dsFilmovi.Zanrovi;
            cbxZanrovi.ValueMember = "Id";
            cbxZanrovi.DisplayMember = "Naziv";
        }


        private void Pretraga(object sender, EventArgs e)
        {
            DAFilmovi.GetFilmoviByNGRZ(dsFilmovi.Filmovi, txtNaziv.Text, txtGodina.Text, txtReziser.Text, Convert.ToInt32(cbxZanrovi.SelectedValue));

            dgFilmovi.AutoGenerateColumns = false;
            dgFilmovi.DataSource = dsFilmovi.Filmovi;
            lblBF.Text = dsFilmovi.Filmovi.Count().ToString();
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void txtGodina_TextChanged(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void txtReziser_TextChanged(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void cbxZanrovi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void btnPregledProjekcija_Click(object sender, EventArgs e)
        {
            int filmId = Convert.ToInt32(dgFilmovi.SelectedRows[0].Cells[0].Value);
            Frm_Projekcije frm = new Frm_Projekcije(filmId);
            frm.ShowDialog();
        }

        private void btnIzvjestajFilmovi_Click(object sender, EventArgs e)
        {
            string NazivOznacenogZanra;
            if (cbxZanrovi.SelectedIndex != 0)
                NazivOznacenogZanra = cbxZanrovi.Text;
            else
                NazivOznacenogZanra = null;
            Reports.Frm_FilmoviReport frm = new Frm_FilmoviReport(dsFilmovi.Filmovi, NazivOznacenogZanra);
            frm.Show();
        }

        private void dgFilmovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int filmId = Convert.ToInt32(dgFilmovi.SelectedRows[0].Cells[0].Value);
            Frm_Projekcije frm = new Frm_Projekcije(filmId);
            frm.ShowDialog();
        }
    }
}
