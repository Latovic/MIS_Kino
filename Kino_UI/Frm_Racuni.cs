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
    public partial class Frm_Racuni : Form
    {
        DSRacuni dsRacuni = new DSRacuni();
        int zaposlenikID;

        public Frm_Racuni()
        {
            InitializeComponent();
        }

        private void Frm_Racuni_Load(object sender, EventArgs e)
        {
            Trazi(null, null);

            DARacuni.getSveKorisnike(dsRacuni.Korisnici);
            DSRacuni.KorisniciRow korisnik = dsRacuni.Korisnici.NewKorisniciRow();
            korisnik.Id = 0;
            korisnik.KorisnickoIme = "Odaberite ime";
            dsRacuni.Korisnici.Rows.InsertAt(korisnik, 0);

            cbxKorisnickoIme.DataSource = dsRacuni.Korisnici;
            cbxKorisnickoIme.ValueMember = "Id";
            cbxKorisnickoIme.DisplayMember = "KorisnickoIme";
        }

        private void Trazi(object sender, EventArgs e)
        {
            DARacuni.getRacune(dsRacuni.IzlaziRobe, zaposlenikID, txtImePrezime.Text, dtDatumOD.Value, dtDatumDO.Value);
            dgRacuni.AutoGenerateColumns = false;
            dgRacuni.DataSource = dsRacuni.IzlaziRobe;
            lbl_BrojRacuna.Text = dsRacuni.IzlaziRobe.Count.ToString();
        }

        private void cbxKorisnickoIme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            zaposlenikID = Convert.ToInt32(cbxKorisnickoIme.SelectedValue);
            Trazi(null, null);
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void btnProizvod_Click(object sender, EventArgs e)
        {
            int izlazID = Convert.ToInt32(dgRacuni.SelectedRows[0].Cells[0].Value);
            Frm_StavkeRacuna frm = new Frm_StavkeRacuna(izlazID);
            frm.ShowDialog();
        }

        private void dgRacuni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int izlazID = Convert.ToInt32(dgRacuni.SelectedRows[0].Cells[0].Value);
            Frm_StavkeRacuna frm = new Frm_StavkeRacuna(izlazID);
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_RacuniReport frm = new Reports.Frm_RacuniReport(dsRacuni.IzlaziRobe);
            frm.ShowDialog();
        }
    }
}
