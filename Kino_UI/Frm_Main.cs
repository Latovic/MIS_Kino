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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Klijenti frm = new Frm_Klijenti();
            frm.ShowDialog();
        }       

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            Frm_Klijenti frm = new Frm_Klijenti();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_Rezervacije frm = new Frm_Rezervacije();
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menadžerska aplikacija za pregled poslovanja kina.\n \nAutori: \n \n -Adnan Jusić IB130094\n -Almin Latović IB130074\n -Ahmed Bumbul IB130041\n \nMostar, FIT, 2016.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            Frm_Kategorije frm = new Frm_Kategorije();
            frm.ShowDialog();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            Frm_Racuni frm = new Frm_Racuni();
            frm.ShowDialog();
        }

        private void btnKarte_Click(object sender, EventArgs e)
        {
            Frm_Karta frm = new Frm_Karta();
            frm.ShowDialog();
        }

        private void btnKlijenti2_Click(object sender, EventArgs e)
        {
            Frm_Klijenti frm = new Frm_Klijenti();
            frm.ShowDialog();
        }

        private void btnRezervacije2_Click(object sender, EventArgs e)
        {
            Frm_Rezervacije frm = new Frm_Rezervacije();
            frm.ShowDialog();
        }
    }
}
