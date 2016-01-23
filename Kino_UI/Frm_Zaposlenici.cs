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
    public partial class Frm_Zaposlenici : Form
    {
        DSZaposlenici dsZaposlenici = new DSZaposlenici();

        public Frm_Zaposlenici()
        {
            InitializeComponent();
        }

        private void Frm_Zaposlenici_Load(object sender, EventArgs e)
        {
            Pretraga(null, null);

            DAZaposlenici.GetAllOpcine(dsZaposlenici.Opcine);
            DSZaposlenici.OpcineRow opcina = dsZaposlenici.Opcine.NewOpcineRow();
            opcina.Id = 0;
            opcina.Naziv = "Izaberite općinu";
            dsZaposlenici.Opcine.Rows.InsertAt(opcina, 0);

            cbxOpcine.DataSource = dsZaposlenici.Opcine;
            cbxOpcine.ValueMember = "Id";
            cbxOpcine.DisplayMember = "Naziv";
        }

        private void Pretraga(object sender, EventArgs e)
        {
            DAZaposlenici.GetZaposlenikeByImePrezimeOpcina(dsZaposlenici.Zaposlenici, txtIme.Text, txtPrezime.Text, Convert.ToInt32(cbxOpcine.SelectedValue));
            dgZaposlenici.AutoGenerateColumns = false;
            dgZaposlenici.DataSource = dsZaposlenici.Zaposlenici;
            lblBZ.Text = dsZaposlenici.Zaposlenici.Count.ToString();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void cbxOpcine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void btnVidiIzdateKarte_Click(object sender, EventArgs e)
        {
            int zaposlenikId = Convert.ToInt32(dgZaposlenici.SelectedRows[0].Cells[0].Value);
            Frm_ZaposleniciKarte frm = new Frm_ZaposleniciKarte(zaposlenikId);
            frm.ShowDialog();
        }

        private void btnIzvjestajZaposlenici_Click(object sender, EventArgs e)
        {
            Reports.Frm_ZaposleniciReport frm = new Frm_ZaposleniciReport(dsZaposlenici.Zaposlenici);
            frm.Show();
        }

        private void dgZaposlenici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int zaposlenikId = Convert.ToInt32(dgZaposlenici.SelectedRows[0].Cells[0].Value);
            Frm_ZaposleniciKarte frm = new Frm_ZaposleniciKarte(zaposlenikId);
            frm.ShowDialog();
        }
    }
}
