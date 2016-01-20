using Kino_DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino_UI.Reports
{
    public partial class Frm_Karte_Report : Form
    {
        DSRezervacije.KarteDataTable dtKarte = new DSRezervacije.KarteDataTable();
        public Frm_Karte_Report(DSRezervacije.KarteDataTable dtKarte)
        {
            InitializeComponent();
            this.dtKarte = dtKarte;
            DSRezervacijeBindingSource.DataSource = dtKarte;
        }

        private void Frm_Karte_Report_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Karta", DSRezervacijeBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
