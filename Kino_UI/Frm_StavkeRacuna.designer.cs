namespace Kino_UI
{
    partial class Frm_StavkeRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StavkeRacuna));
            this.dgStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrojStavki = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtSifraProizv = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtNazivProiz = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStavkeRacuna
            // 
            this.dgStavkeRacuna.AllowUserToAddRows = false;
            this.dgStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgStavkeRacuna.AllowUserToOrderColumns = true;
            this.dgStavkeRacuna.AllowUserToResizeRows = false;
            this.dgStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStavkeRacuna.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Sifra,
            this.Kolicina,
            this.Cijena});
            this.dgStavkeRacuna.Location = new System.Drawing.Point(12, 36);
            this.dgStavkeRacuna.Name = "dgStavkeRacuna";
            this.dgStavkeRacuna.ReadOnly = true;
            this.dgStavkeRacuna.RowHeadersVisible = false;
            this.dgStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStavkeRacuna.Size = new System.Drawing.Size(344, 250);
            this.dgStavkeRacuna.TabIndex = 2;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // lblBrojStavki
            // 
            this.lblBrojStavki.AutoSize = true;
            this.lblBrojStavki.Location = new System.Drawing.Point(108, 297);
            this.lblBrojStavki.Name = "lblBrojStavki";
            this.lblBrojStavki.Size = new System.Drawing.Size(35, 13);
            this.lblBrojStavki.TabIndex = 22;
            this.lblBrojStavki.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Broj proizvoda:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(194, 13);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(37, 13);
            this.lblPrezime.TabIndex = 26;
            this.lblPrezime.Text = "Šifra:";
            // 
            // txtSifraProizv
            // 
            this.txtSifraProizv.Location = new System.Drawing.Point(237, 10);
            this.txtSifraProizv.Name = "txtSifraProizv";
            this.txtSifraProizv.Size = new System.Drawing.Size(119, 20);
            this.txtSifraProizv.TabIndex = 25;
            this.txtSifraProizv.TextChanged += new System.EventHandler(this.txtSifraProizv_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(9, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(43, 13);
            this.lblIme.TabIndex = 24;
            this.lblIme.Text = "Naziv:";
            // 
            // txtNazivProiz
            // 
            this.txtNazivProiz.Location = new System.Drawing.Point(58, 10);
            this.txtNazivProiz.Name = "txtNazivProiz";
            this.txtNazivProiz.Size = new System.Drawing.Size(113, 20);
            this.txtNazivProiz.TabIndex = 23;
            this.txtNazivProiz.TextChanged += new System.EventHandler(this.txtNazivProiz_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(281, 292);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_StavkeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 319);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtSifraProizv);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtNazivProiz);
            this.Controls.Add(this.lblBrojStavki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgStavkeRacuna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_StavkeRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke računa";
            this.Load += new System.EventHandler(this.Frm_Racun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeRacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStavkeRacuna;
        private System.Windows.Forms.Label lblBrojStavki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtSifraProizv;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtNazivProiz;
        private System.Windows.Forms.Button btnPrint;
    }
}

