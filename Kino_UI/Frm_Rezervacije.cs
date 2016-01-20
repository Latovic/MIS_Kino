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
using Kino_UI.Reports;

namespace Kino_UI
{
    public partial class Frm_Rezervacije : Form
    {
        DSRezervacije dsRezervacije = new DSRezervacije();
        public Frm_Rezervacije()
        {
            InitializeComponent();
        }

        private void Frm_Rezervacije_Load(object sender, EventArgs e)
        {
            DARezervacije.GetAllRezervacijeByKlijentID(dsRezervacije.Rezervacije,0,null,null);
            dgRezervacije.AutoGenerateColumns = false;
            dgRezervacije.DataSource = dsRezervacije.Rezervacije;
            lblBrojac.Text = dsRezervacije.Rezervacije.Count().ToString();
        }    

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime? _datumOd;
            DateTime? _datumDo;

            if (checkBoxFilterOd.Checked)
                _datumOd = datumOd.Value;
            else
                _datumOd = null;

            if (checkBoxFilterDo.Checked)
                _datumDo = datumDo.Value;
            else
                _datumDo = null;
            Frm_Rezervacije_Report frm = new Frm_Rezervacije_Report(dsRezervacije.Rezervacije, dsRezervacije.Karte, _datumOd, _datumDo);
            frm.ShowDialog();
        }

        private void datumOd_ValueChanged(object sender, EventArgs e)
        {
            if(checkBoxFilterOd.Checked)
                Trazi();
        }

        private void datumDo_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterDo.Checked)
                Trazi();
        }

        private void Trazi()
        {
            DateTime? _datumOd;
            DateTime? _datumDo;

            if (checkBoxFilterOd.Checked)
                _datumOd = datumOd.Value;
            else
                _datumOd = null;

            if (checkBoxFilterDo.Checked)
                _datumDo = datumDo.Value;
            else
                _datumDo = null;

            DARezervacije.GetAllRezervacijeByKlijentID(dsRezervacije.Rezervacije, 0, _datumOd, _datumDo);
            dgRezervacije.AutoGenerateColumns = false;
            dgRezervacije.DataSource = dsRezervacije.Rezervacije;
            lblBrojac.Text = dsRezervacije.Rezervacije.Count().ToString();
        }

        private void checkBoxFilterOd_CheckedChanged(object sender, EventArgs e)
        {
            Trazi();
        }

        private void checkBoxFilterDo_CheckedChanged(object sender, EventArgs e)
        {
            Trazi();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int rezervacijId = Convert.ToInt32(dgRezervacije.SelectedRows[0].Cells[0].Value);
            Frm_Karte frm = new Frm_Karte(rezervacijId);
            frm.ShowDialog();
        }
    }
}
