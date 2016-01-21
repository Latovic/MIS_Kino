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
    public partial class Frm_Proizvodi : Form
    {
        DSProizvodi dsProizvodi = new DSProizvodi();
        int kategorijaId;

        public Frm_Proizvodi(int kategorijaID)
        {
            InitializeComponent();
            kategorijaId = kategorijaID;
        }

        
        private void Frm_Proizvodi_Load(object sender, EventArgs e)
        {
            Trazi(null, null);

            DAProizvodi.getSveKategorije(dsProizvodi.KategorijeProizvoda);
            DSProizvodi.KategorijeProizvodaRow Kategorija = dsProizvodi.KategorijeProizvoda.NewKategorijeProizvodaRow();
            Kategorija.Id = 0;
            Kategorija.Naziv = "------";
            dsProizvodi.KategorijeProizvoda.Rows.InsertAt(Kategorija, 0);

            cbxKategorije.DataSource = dsProizvodi.KategorijeProizvoda;
            cbxKategorije.ValueMember = "Id";
            cbxKategorije.DisplayMember = "Naziv";
            cbxKategorije.SelectedValue = kategorijaId;
        }

        private void Trazi(object sender, EventArgs e)
        {
            
            DAProizvodi.getSveProizvodeByNazivSifra(dsProizvodi.Proizvodi, txtNaziv.Text, txtSifra.Text, tbCijenaOd.Value, tbCijenaDo.Value, kategorijaId);
            dgProizvodi.AutoGenerateColumns = false;
            dgProizvodi.DataSource = dsProizvodi.Proizvodi;
            lbl_BrojProizvoda.Text = dsProizvodi.Proizvodi.Count.ToString();
            lblCijenaOd.Text = tbCijenaOd.Value.ToString();
            lblCijenaDo.Text = tbCijenaDo.Value.ToString();
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        } 

        private void cbxKategorije_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void tbCijenaOd_ValueChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void tbCijenaDo_ValueChanged(object sender, EventArgs e)
        {
            Trazi(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int kategorijaProizvodaID = Convert.ToInt32(dgProizvodi.SelectedRows[0].Cells[0].Value);

            //Frm_Kategorije frm = new Frm_Kategorije(kategorijaProizvodaID);
            //frm.Show();
        }

        private void cbxKategorije_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            kategorijaId = Convert.ToInt32(cbxKategorije.SelectedValue);
            Trazi(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_ProizvodiReport frm = new Reports.Frm_ProizvodiReport(dsProizvodi.Proizvodi);
            frm.Show();
        }
    }
}
