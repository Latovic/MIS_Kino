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
    public partial class Frm_Kategorije : Form
    {
        DSKategorije dsKategorije = new DSKategorije();

        public Frm_Kategorije()
        {
            InitializeComponent();
        }

        private void Frm_Kategorije_Load(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void Trazi(object sender, EventArgs e)
        {
            DAKategorije.getKategorijeByNaziv(dsKategorije.KategorijeProizvoda, txtKategorijaNaziv.Text, txtProizvodNaziv.Text);
            dgKategorije.AutoGenerateColumns = false;
            dgKategorije.DataSource = dsKategorije.KategorijeProizvoda;
            lblBrojKategorija.Text = dsKategorije.KategorijeProizvoda.Count.ToString();
        }

        private void txtKategorijaNaziv_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void btnProizvod_Click(object sender, EventArgs e)
        {
            int kategorijaID = Convert.ToInt32(dgKategorije.SelectedRows[0].Cells[0].Value);
            Frm_Proizvodi frm = new Frm_Proizvodi(kategorijaID);
            frm.ShowDialog();
        }

        private void txtProizvodNaziv_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void dgKategorije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kategorijaID = Convert.ToInt32(dgKategorije.SelectedRows[0].Cells[0].Value);
            Frm_Proizvodi frm = new Frm_Proizvodi(kategorijaID);
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_KategorijeReport frm = new Reports.Frm_KategorijeReport(dsKategorije.KategorijeProizvoda);
            frm.ShowDialog();
        }
    }
}
