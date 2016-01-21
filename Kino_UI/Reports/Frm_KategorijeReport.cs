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
    public partial class Frm_KategorijeReport : Form
    {
        public Frm_KategorijeReport(DSKategorije.KategorijeProizvodaDataTable dtKategorije)
        {
            InitializeComponent();
            DSKategorijeBindingSource.DataSource = dtKategorije;
        }

        private void Frm_KategorijeReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Kategorije", DSKategorijeBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
