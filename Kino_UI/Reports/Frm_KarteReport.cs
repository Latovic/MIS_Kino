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
using Microsoft.Reporting.WinForms;

namespace Kino_UI.Reports
{
    public partial class Frm_KarteReport : Form
    {
        DSKarte karte = new DSKarte();
        public Frm_KarteReport(DSKarte.KarteDataTable dtKarte)
        {
            InitializeComponent();
            DSKarteBindingSource.DataSource = dtKarte;
        }

        private void Frm_KarteReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Karte", DSKarteBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
