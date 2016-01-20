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
    public partial class frm_KlijentiRegistracije_Report : Form
    {
        DSKlijenti dsKlijenti = new DSKlijenti();
        public frm_KlijentiRegistracije_Report()
        {
            InitializeComponent();
        }

        private void frm_KlijentiRegistracije_Report_Load(object sender, EventArgs e)
        {
            DAKlijenti.SelectRegistracije(dsKlijenti.Registracije);
            DSKlijentiBindingSource.DataSource = dsKlijenti.Registracije;
           ReportDataSource rds = new ReportDataSource("Registracije", DSKlijentiBindingSource);

            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
