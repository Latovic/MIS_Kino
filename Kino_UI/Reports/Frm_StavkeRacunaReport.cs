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
    public partial class Frm_StavkeRacunaReport : Form
    {
        DSStavkeRacuna stavke = new DSStavkeRacuna();

        public Frm_StavkeRacunaReport(DSStavkeRacuna.StavkeIzlazaDataTable dtStavkeRacuna)
        {
            InitializeComponent();
            DSStavkeRacunaBindingSource.DataSource = dtStavkeRacuna;
        }

        private void Frm_StavkeRacunaReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("StavkeRacuna", DSStavkeRacunaBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
