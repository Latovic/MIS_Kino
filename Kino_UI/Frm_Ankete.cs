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
    public partial class Frm_Ankete : Form
    {
        DSAnkete dsAnkete = new DSAnkete();

        public Frm_Ankete()
        {
            InitializeComponent();
        }

        private void Frm_Ankete_Load(object sender, EventArgs e)
        {
            Pretraga(null, null);
        }

        private void Pretraga(object sender, EventArgs e)
        {
            DAAnkete.GetAnketeByPitanje(dsAnkete.Ankete, txtPitanje.Text);

            dgAnkete.AutoGenerateColumns = false;
            dgAnkete.DataSource = dsAnkete.Ankete;
            lblBA.Text = dsAnkete.Ankete.Count().ToString();
        }

        private void txtPitanje_TextChanged(object sender, EventArgs e)
        {
            Pretraga(null, null);

        }

        private void btnVidiRezultate_Click(object sender, EventArgs e)
        {
            int anketaId = Convert.ToInt32(dgAnkete.SelectedRows[0].Cells[0].Value);
            Frm_RezultatiAnkete frm = new Frm_RezultatiAnkete(anketaId);
            frm.ShowDialog();
        }

        private void dgAnkete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int anketaId = Convert.ToInt32(dgAnkete.SelectedRows[0].Cells[0].Value);
            Frm_RezultatiAnkete frm = new Frm_RezultatiAnkete(anketaId);
            frm.ShowDialog();
        }
    }
}
