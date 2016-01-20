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
    public partial class frm_Klijenti_Report : Form
    {
        DSKlijenti.KlijentiDataTable dtKlijenti = new DSKlijenti.KlijentiDataTable();
        string nazivOpcine;
        public frm_Klijenti_Report(DSKlijenti.KlijentiDataTable dtKlijenti, string nazivOpcine)
        {
            InitializeComponent();
            this.dtKlijenti = dtKlijenti;
            DSKlijentiBindingSource.DataSource = dtKlijenti;
            this.nazivOpcine = nazivOpcine;
        }

        private void frm_Klijenti_Report_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Klijenti", DSKlijentiBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            if(nazivOpcine != null)
                reportViewer.LocalReport.SetParameters(new ReportParameter("NazivOpcine", nazivOpcine));
            reportViewer.LocalReport.SetParameters(new ReportParameter("Ukupno", dtKlijenti.Count().ToString()));
            this.reportViewer.RefreshReport();
        }
    }
}
