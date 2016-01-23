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
    public partial class Frm_Projekcije : Form
    {
        int filmId;
        DSProjekcije dsProjekcije = new DSProjekcije();

        public Frm_Projekcije(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;
        }

        private void Pretraga()
        {
            DateTime? datumVrijemeOd;
            DateTime? datumVrijemeDo;

            if (cbxOd.Checked)
                datumVrijemeOd = dateTimeOd.Value;
            else
                datumVrijemeOd = null;

            if (cbxDo.Checked)
                datumVrijemeDo = dateTimeDo.Value;
            else
                datumVrijemeDo = null;

            DAProjekcije.GetProjekcijeByFilmID(dsProjekcije.Projekcije, filmId, datumVrijemeOd, datumVrijemeDo);
            dgProjekcije.AutoGenerateColumns = false;
            dgProjekcije.DataSource = dsProjekcije.Projekcije;
            lblBP.Text = dsProjekcije.Projekcije.Count().ToString();
        }

        private void dateTimeOd_ValueChanged(object sender, EventArgs e)
        {
            if (cbxOd.Checked)
                Pretraga();
        }

        private void dateTimeDo_ValueChanged(object sender, EventArgs e)
        {
            if (cbxDo.Checked)
                Pretraga();
        }

        private void cbxOd_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();

        }

        private void cbxDo_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();

        }

        private void Frm_Projekcije_Load(object sender, EventArgs e)
        {
            DAProjekcije.GetProjekcijeByFilmID(dsProjekcije.Projekcije, filmId, null, null);
            dgProjekcije.AutoGenerateColumns = false;
            dgProjekcije.DataSource = dsProjekcije.Projekcije;
            lblBP.Text = dsProjekcije.Projekcije.Count().ToString();
        }

        private void btnIzvjestajProjekcije_Click(object sender, EventArgs e)
        {
            string NazivFilma = dgProjekcije.SelectedRows[0].Cells[1].Value.ToString();
            Reports.Frm_ProjekcijeReport frm = new Frm_ProjekcijeReport(dsProjekcije.Projekcije, NazivFilma);
            frm.Show();
        }

        private void dgProjekcije_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string NazivFilma = dgProjekcije.SelectedRows[0].Cells[1].Value.ToString();
            Reports.Frm_ProjekcijeReport frm = new Frm_ProjekcijeReport(dsProjekcije.Projekcije, NazivFilma);
            frm.Show();
        }
    }
}
