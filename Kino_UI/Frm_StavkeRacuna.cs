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
    public partial class Frm_StavkeRacuna : Form
    {
        DSStavkeRacuna dsStavke = new DSStavkeRacuna();
        int izlazId;

        public Frm_StavkeRacuna(int izlazID)
        {
            InitializeComponent();
            izlazId = izlazID;
        }

        private void Frm_Racun_Load(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void Trazi(object sender, EventArgs e)
        {

            DAStavkeRacuna.getStavkeRacuna(dsStavke.StavkeIzlaza, izlazId, txtNazivProiz.Text, txtSifraProizv.Text);
            dgStavkeRacuna.AutoGenerateColumns = false;
            dgStavkeRacuna.DataSource = dsStavke.StavkeIzlaza;
            lblBrojStavki.Text = dsStavke.StavkeIzlaza.Count.ToString();
        }

        private void txtNazivProiz_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void txtSifraProizv_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_StavkeRacunaReport frm = new Reports.Frm_StavkeRacunaReport(dsStavke.StavkeIzlaza);
            frm.Show();
        }
    }
}
