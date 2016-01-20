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
    public partial class Frm_Login : Form
    {
        //DSKorisnici.KorisniksDataTable dtKorisnik = new DSKorisnici.KorisniksDataTable();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //dtKorisnik.Clear();
            //if (txt_user.Text != "" && txt_pass.Text != "")
            //{
            //    int ver = DAKorisnici.ProvjeraKorisnika(txt_user.Text, txt_pass.Text);


            //    if (ver != 0)
            //    {
            //        this.DialogResult = DialogResult.OK;
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    lbl_error.Visible = true;
            //}
            Frm_Main frm = new Frm_Main();            
            frm.Show();
            
        }
    }
}
