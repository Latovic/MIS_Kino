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
using Kino_UI.Reports;

namespace Kino_UI
{
    public partial class Frm_Klijenti : Form
    {
        DSKlijenti dsKlijenti = new DSKlijenti();

        public Frm_Klijenti()
        {
            InitializeComponent();
        }

        private void Frm_Klijenti_Load(object sender, EventArgs e)
        {
            Trazi(null,null);

            DAKlijenti.GetAllOpcine(dsKlijenti.Opcine);
            DSKlijenti.OpcineRow opcina = dsKlijenti.Opcine.NewOpcineRow();
            opcina.Id = 0;
            opcina.Naziv = "Odaberite općinu";
            dsKlijenti.Opcine.Rows.InsertAt(opcina, 0);

            cbxOpcine.DataSource = dsKlijenti.Opcine;
            cbxOpcine.ValueMember = "Id";
            cbxOpcine.DisplayMember = "Naziv";

        }        

        private void btnPregledRezervacija_Click(object sender, EventArgs e)
        {
            int klijentId = Convert.ToInt32(dgKlijenti.SelectedRows[0].Cells[0].Value);
            Frm_KlijentiRezervacije frm = new Frm_KlijentiRezervacije(klijentId);
            frm.ShowDialog();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            Trazi(null,null);
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void cbxOpcine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void Trazi(object sender, EventArgs e)
        {
            DAKlijenti.GetAllKlijentiByImePrezime(dsKlijenti.Klijenti, txtIme.Text, txtPrezime.Text, txtKorisnickoIme.Text, Convert.ToInt32(cbxOpcine.SelectedValue));
            dgKlijenti.AutoGenerateColumns = false;
            dgKlijenti.DataSource = dsKlijenti.Klijenti;
            lblBrojKlijenata.Text = dsKlijenti.Klijenti.Count.ToString();            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string odabranaOpcinaNaziv;
            if (cbxOpcine.SelectedIndex != 0)
                odabranaOpcinaNaziv = cbxOpcine.Text;
            else
                odabranaOpcinaNaziv = null;
            Reports.frm_Klijenti_Report frm = new frm_Klijenti_Report(dsKlijenti.Klijenti, odabranaOpcinaNaziv);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_KlijentiRegistracije_Report frm = new frm_KlijentiRegistracije_Report();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int klijentId = Convert.ToInt32(dgKlijenti.SelectedRows[0].Cells[0].Value);
            //Frm_KlijentProfil frm = new Frm_KlijentProfil(klijentId);
            //frm.ShowDialog();
        }
    }
}
