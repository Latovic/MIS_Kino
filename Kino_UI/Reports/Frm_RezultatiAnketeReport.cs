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
    public partial class Frm_RezultatiAnketeReport : Form
    {
        DSAnkete.RezultatiAnketeDataTable dtRezultatiAnkete = new DSAnkete.RezultatiAnketeDataTable();
        string PitanjeAnkete;

        public Frm_RezultatiAnketeReport(DSAnkete.RezultatiAnketeDataTable dtRezultatiAnkete, string PitanjeAnkete)
        {
            InitializeComponent();
            this.dtRezultatiAnkete = dtRezultatiAnkete;
            DSAnketeBindingSource.DataSource = dtRezultatiAnkete;
            this.PitanjeAnkete = PitanjeAnkete;
        }

        private void Frm_RezultatiAnketeReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("RezultatiAnkete", DSAnketeBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            if (PitanjeAnkete != null)
                reportViewer.LocalReport.SetParameters(new ReportParameter("PitanjeAnkete", PitanjeAnkete));
            reportViewer.LocalReport.SetParameters(new ReportParameter("Ukupno", dtRezultatiAnkete.Count().ToString()));
            this.reportViewer.RefreshReport();
        }
    }
}
