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
    public partial class Frm_RacuniReport : Form
    {
        public Frm_RacuniReport(DSRacuni.IzlaziRobeDataTable dtRacuni)
        {
            InitializeComponent();
            DSRacuniBindingSource.DataSource = dtRacuni;
        }

        private void Frm_RacuniReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Racuni", DSRacuniBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
