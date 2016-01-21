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
    public partial class Frm_ProizvodiReport : Form
    {
        DSProizvodi proizvodi = new DSProizvodi();

        public Frm_ProizvodiReport(DSProizvodi.ProizvodiDataTable dtProizvodi)
        {
            InitializeComponent();
            DSProizvodiBindingSource.DataSource = dtProizvodi;
        }

        private void Frm_ProizvodiReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Proizvodi", DSProizvodiBindingSource);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
