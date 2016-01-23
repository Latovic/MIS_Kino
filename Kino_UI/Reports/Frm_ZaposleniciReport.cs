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
    public partial class Frm_ZaposleniciReport : Form
    { 
        DSZaposlenici.ZaposleniciDataTable dtZaposlenici = new DSZaposlenici.ZaposleniciDataTable();

        public Frm_ZaposleniciReport(DSZaposlenici.ZaposleniciDataTable dtZaposlenici)
        {
            InitializeComponent();
            this.dtZaposlenici = dtZaposlenici;
            DSZaposleniciBindingSource.DataSource = dtZaposlenici;
        }

        private void Frm_ZaposleniciReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Zaposlenici", DSZaposleniciBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.SetParameters(new ReportParameter("Ukupno", dtZaposlenici.Count().ToString()));
            this.reportViewer.RefreshReport();
        }
    }
}
