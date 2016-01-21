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
    public partial class Frm_Login : Form
    {
        DSMenadzeri.MenadzeriDataTable dtMenadzer = new DSMenadzeri.MenadzeriDataTable();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtMenadzer.Clear();
            if (txtKorisnickoIme.Text != "" && txtLozinka.Text != "")
            {
                int menadzer = DAMenadzeri.ProvjeraKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);

                if (menadzer != 0)
                {
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();
                    Frm_Main frm = new Frm_Main();
                    frm.Show();
                }                
            }
            else
            {
                lbl_error.Visible = true;
            }           
            
        }
    }
}
