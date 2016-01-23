using Kino_DAL;
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
    public partial class Frm_ZaposleniciKarte : Form
    {
        int zaposlenikId;
        DSZaposlenici dsZaposlenici = new DSZaposlenici();

        public Frm_ZaposleniciKarte(int zaposlenikId)
        {
            InitializeComponent();
            this.zaposlenikId = zaposlenikId;
        }

        private void Frm_ZaposleniciKarte_Load(object sender, EventArgs e)
        {
            DAZaposlenici.GetKarteByZaposlenikID(dsZaposlenici.Karte, zaposlenikId, null, null);
            dgKarte.AutoGenerateColumns = false;
            dgKarte.DataSource = dsZaposlenici.Karte;
            lblBK.Text = dsZaposlenici.Karte.Count().ToString();
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

            DAZaposlenici.GetKarteByZaposlenikID(dsZaposlenici.Karte, zaposlenikId, datumVrijemeOd, datumVrijemeDo);
            dgKarte.AutoGenerateColumns = false;
            dgKarte.DataSource = dsZaposlenici.Karte;
            lblBK.Text = dsZaposlenici.Karte.Count().ToString();
        }


        private void dateTimeOd_ValueChanged(object sender, EventArgs e)
        {
            if (cbxDo.Checked)
                Pretraga();
        }

        private void dateTimeDo_ValueChanged(object sender, EventArgs e)
        {
            if (cbxOd.Checked)
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
    }
}
