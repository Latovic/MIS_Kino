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
                    this.DialogResult = DialogResult.OK;                         
                }                
            }
            else
            {
                lbl_error.Visible = true;
            } 
            
            if(this.DialogResult == DialogResult.OK)
            {
               
                Frm_Main frm = new Frm_Main();
                frm.ShowDialog();
                
            }          
            
        }

        private void Frm_Login_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(null,null);
        }
    }
}
