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
    public partial class Frm_FilmoviReport : Form
    {
        DSFilmovi.FilmoviDataTable dtFilmovi = new DSFilmovi.FilmoviDataTable();
        string NazivOznacenogZanra;

        public Frm_FilmoviReport(DSFilmovi.FilmoviDataTable dtFilmovi, string NazivOznacenogZanra)
        {
            InitializeComponent();
            this.dtFilmovi = dtFilmovi;
            DSFilmoviBindingSource.DataSource = dtFilmovi;
            this.NazivOznacenogZanra = NazivOznacenogZanra;
        }

        private void Frm_FilmoviReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Filmovi", DSFilmoviBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            if (NazivOznacenogZanra != null)
                reportViewer.LocalReport.SetParameters(new ReportParameter("NazivZanra", NazivOznacenogZanra));
            reportViewer.LocalReport.SetParameters(new ReportParameter("Ukupno", dtFilmovi.Count().ToString()));
            this.reportViewer.RefreshReport();
        }
    }
}
