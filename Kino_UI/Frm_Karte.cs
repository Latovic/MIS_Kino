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
    public partial class Frm_Karte : Form
    {
        DSRezervacije.KarteDataTable dtKarte = new DSRezervacije.KarteDataTable();
        int rezervacijaId;
        public Frm_Karte(int rezervacijaId)
        {
            InitializeComponent();
            this.rezervacijaId = rezervacijaId;
        }

        private void Frm_Karte_Load(object sender, EventArgs e)
        {
            DARezervacije.GetAllKarteByRezervacijaID(dtKarte, rezervacijaId);
            txtNazivFilma.Text = dtKarte[0].NazivFilma.ToString();
            txtDvoranaNaziv.Text = dtKarte[0].Dvorana.ToString();
            txtVrijeme.Text = dtKarte[0].VrijemeProjekcije.ToString();
            txtDrzava.Text = dtKarte[0].Drzava.ToString();
            txtCijena.Text = dtKarte[0].CijenaProjekcije.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Karte_Report frm = new Frm_Karte_Report(dtKarte);
            frm.ShowDialog();
        }
    }
}
