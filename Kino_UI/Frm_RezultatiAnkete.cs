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
    public partial class Frm_RezultatiAnkete : Form
    {
        int anketaId;
        DSAnkete dsAnkete = new DSAnkete();

        public Frm_RezultatiAnkete(int anketaId)
        {
            InitializeComponent();
            this.anketaId = anketaId;
        }

        public Frm_RezultatiAnkete()
        {
            InitializeComponent();
        }

        private void Frm_RezultatiAnkete_Load(object sender, EventArgs e)
        {
            DAAnkete.GetRezultateByAnketaID(dsAnkete.RezultatiAnkete, anketaId);
            dgRezultatiAnkete.AutoGenerateColumns = false;
            dgRezultatiAnkete.DataSource = dsAnkete.RezultatiAnkete;
        }

        private void btnIzvjestajRezultati_Click(object sender, EventArgs e)
        {
            string PitanjeAnkete = dgRezultatiAnkete.SelectedRows[0].Cells[1].Value.ToString();
            Reports.Frm_RezultatiAnketeReport frm = new Frm_RezultatiAnketeReport(dsAnkete.RezultatiAnkete, PitanjeAnkete);
            frm.Show();
        }

        private void dgRezultatiAnkete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string PitanjeAnkete = dgRezultatiAnkete.SelectedRows[0].Cells[1].Value.ToString();
            Reports.Frm_RezultatiAnketeReport frm = new Frm_RezultatiAnketeReport(dsAnkete.RezultatiAnkete, PitanjeAnkete);
            frm.Show();
        }
    }
}
