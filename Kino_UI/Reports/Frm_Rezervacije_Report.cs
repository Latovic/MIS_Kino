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
    public partial class Frm_Rezervacije_Report : Form
    {
        DSRezervacije.RezervacijeDataTable Rezervacije = new DSRezervacije.RezervacijeDataTable();
        DateTime? datumOd;
        DateTime? datumDo;
        public Frm_Rezervacije_Report(DSRezervacije.RezervacijeDataTable rezervacije, DSRezervacije.KarteDataTable karte, DateTime? datumOd, DateTime? datumDo)
        {            
            InitializeComponent();
            Rezervacije = rezervacije;
            DSRezervacijeBindingSource.DataSource = rezervacije;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
        }

        private void Frm_Rezervacije_Report_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Rezervacije", bindingSource);
            if(datumOd != null)
                reportViewer.LocalReport.SetParameters(new ReportParameter("DatumOd", datumOd.Value.ToString("d-M-yyyy")));
            if (datumDo != null)
                reportViewer.LocalReport.SetParameters(new ReportParameter("DatumDo", datumDo.Value.ToString("d-M-yyyy")));
            reportViewer.LocalReport.SetParameters(new ReportParameter("Ukupno", Rezervacije.Count().ToString()));

            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
