﻿namespace Kino_UI.Reports
{
    partial class Frm_ProjekcijeReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DSProjekcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DSProjekcijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DSProjekcijeBindingSource
            // 
            this.DSProjekcijeBindingSource.DataMember = "Projekcije";
            this.DSProjekcijeBindingSource.DataSource = typeof(Kino_DAL.DSProjekcije);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Projekcije";
            reportDataSource1.Value = this.DSProjekcijeBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Kino_UI.Reports.rptProjekcije.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(506, 384);
            this.reportViewer.TabIndex = 0;
            // 
            // Frm_ProjekcijeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 384);
            this.Controls.Add(this.reportViewer);
            this.Name = "Frm_ProjekcijeReport";
            this.Text = "Izvještaj o projekcijama filma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ProjekcijeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSProjekcijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource DSProjekcijeBindingSource;
    }
}