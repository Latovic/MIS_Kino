namespace Kino_UI
{
    partial class Frm_Racuni
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
            this.dgRacuni = new System.Windows.Forms.DataGridView();
            this.IzlazRobeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_BrojRacuna = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.dtDatumOD = new System.Windows.Forms.DateTimePicker();
            this.dtDatumDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProizvod = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRacuni
            // 
            this.dgRacuni.AllowUserToAddRows = false;
            this.dgRacuni.AllowUserToDeleteRows = false;
            this.dgRacuni.AllowUserToOrderColumns = true;
            this.dgRacuni.AllowUserToResizeRows = false;
            this.dgRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRacuni.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IzlazRobeId,
            this.Ime,
            this.KorisnickoIme,
            this.Cijena,
            this.DatumVrijeme});
            this.dgRacuni.Location = new System.Drawing.Point(12, 80);
            this.dgRacuni.Name = "dgRacuni";
            this.dgRacuni.ReadOnly = true;
            this.dgRacuni.RowHeadersVisible = false;
            this.dgRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRacuni.Size = new System.Drawing.Size(483, 274);
            this.dgRacuni.TabIndex = 2;
            this.dgRacuni.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRacuni_CellDoubleClick);
            // 
            // IzlazRobeId
            // 
            this.IzlazRobeId.DataPropertyName = "Id";
            this.IzlazRobeId.HeaderText = "IzlazRobeId";
            this.IzlazRobeId.Name = "IzlazRobeId";
            this.IzlazRobeId.ReadOnly = true;
            this.IzlazRobeId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "imePrezime";
            this.Ime.HeaderText = "Ime prezime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijemeProdaje";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme izdavanja";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // lbl_BrojRacuna
            // 
            this.lbl_BrojRacuna.AutoSize = true;
            this.lbl_BrojRacuna.Location = new System.Drawing.Point(108, 369);
            this.lbl_BrojRacuna.Name = "lbl_BrojRacuna";
            this.lbl_BrojRacuna.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojRacuna.TabIndex = 22;
            this.lbl_BrojRacuna.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Broj računa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(272, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Korisničko ime:";
            // 
            // cbxKorisnickoIme
            // 
            this.cbxKorisnickoIme.FormattingEnabled = true;
            this.cbxKorisnickoIme.Location = new System.Drawing.Point(374, 12);
            this.cbxKorisnickoIme.Name = "cbxKorisnickoIme";
            this.cbxKorisnickoIme.Size = new System.Drawing.Size(121, 21);
            this.cbxKorisnickoIme.TabIndex = 31;
            this.cbxKorisnickoIme.SelectionChangeCommitted += new System.EventHandler(this.cbxKorisnickoIme_SelectionChangeCommitted);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(12, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(78, 13);
            this.lblIme.TabIndex = 34;
            this.lblIme.Text = "Ime prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(96, 12);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(157, 20);
            this.txtImePrezime.TabIndex = 33;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // dtDatumOD
            // 
            this.dtDatumOD.Location = new System.Drawing.Point(53, 54);
            this.dtDatumOD.Name = "dtDatumOD";
            this.dtDatumOD.Size = new System.Drawing.Size(200, 20);
            this.dtDatumOD.TabIndex = 35;
            this.dtDatumOD.Value = new System.DateTime(1970, 1, 19, 18, 9, 0, 0);
            this.dtDatumOD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtDatumDO
            // 
            this.dtDatumDO.Location = new System.Drawing.Point(292, 54);
            this.dtDatumDO.Name = "dtDatumDO";
            this.dtDatumDO.Size = new System.Drawing.Size(200, 20);
            this.dtDatumDO.TabIndex = 36;
            this.dtDatumDO.Value = new System.DateTime(2100, 1, 19, 18, 9, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(259, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Do:";
            // 
            // btnProizvod
            // 
            this.btnProizvod.Location = new System.Drawing.Point(381, 364);
            this.btnProizvod.Name = "btnProizvod";
            this.btnProizvod.Size = new System.Drawing.Size(114, 23);
            this.btnProizvod.TabIndex = 39;
            this.btnProizvod.Text = "Pregledaj stavke";
            this.btnProizvod.UseVisualStyleBackColor = true;
            this.btnProizvod.Click += new System.EventHandler(this.btnProizvod_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(292, 364);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_Racuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 391);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnProizvod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDatumDO);
            this.Controls.Add(this.dtDatumOD);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxKorisnickoIme);
            this.Controls.Add(this.lbl_BrojRacuna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRacuni);
            this.Name = "Frm_Racuni";
            this.Text = "Racuni";
            this.Load += new System.EventHandler(this.Frm_Racuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRacuni;
        private System.Windows.Forms.Label lbl_BrojRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxKorisnickoIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DateTimePicker dtDatumOD;
        private System.Windows.Forms.DateTimePicker dtDatumDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzlazRobeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.Button btnPrint;
    }
}

