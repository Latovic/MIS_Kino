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
    public partial class Frm_ProjekcijeReport : Form
    {
        DSProjekcije.ProjekcijeDataTable dtProjekcije = new DSProjekcije.ProjekcijeDataTable();
        string NazivFilma;

        public Frm_ProjekcijeReport(DSProjekcije.ProjekcijeDataTable dtProjekcije, string NazivFilma)
        {
            InitializeComponent();
            this.dtProjekcije = dtProjekcije;
            DSProjekcijeBindingSource.DataSource = dtProjekcije;
            this.NazivFilma = NazivFilma;
        }

        private void Frm_ProjekcijeReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Projekcije", DSProjekcijeBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            if (NazivFilma != null)
                reportViewer.LocalReport.SetParameters(new ReportParameter("NazivFilma", NazivFilma));
            reportViewer.LocalReport.SetParameters(new ReportParameter("Ukupno", dtProjekcije.Count().ToString()));
            this.reportViewer.RefreshReport();
        }
    }
}
