namespace Kino_UI
{
    partial class Frm_Zaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Zaposlenici));
            this.dgZaposlenici = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZaposlenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxOpcine = new System.Windows.Forms.ComboBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblBrojZaposlenika = new System.Windows.Forms.Label();
            this.lblBZ = new System.Windows.Forms.Label();
            this.lblZaposlenici = new System.Windows.Forms.Label();
            this.btnVidiIzdateKarte = new System.Windows.Forms.Button();
            this.btnIzvjestajZaposlenici = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgZaposlenici
            // 
            this.dgZaposlenici.AllowUserToAddRows = false;
            this.dgZaposlenici.AllowUserToDeleteRows = false;
            this.dgZaposlenici.AllowUserToOrderColumns = true;
            this.dgZaposlenici.AllowUserToResizeRows = false;
            this.dgZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgZaposlenici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.DatumRodjenja,
            this.DatumZaposlenja,
            this.Opcina,
            this.BrojKarata});
            this.dgZaposlenici.Location = new System.Drawing.Point(12, 81);
            this.dgZaposlenici.Name = "dgZaposlenici";
            this.dgZaposlenici.ReadOnly = true;
            this.dgZaposlenici.RowHeadersVisible = false;
            this.dgZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgZaposlenici.Size = new System.Drawing.Size(665, 401);
            this.dgZaposlenici.TabIndex = 1;
            this.dgZaposlenici.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZaposlenici_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ZaposlenikID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // DatumZaposlenja
            // 
            this.DatumZaposlenja.DataPropertyName = "DatumZaposlenja";
            this.DatumZaposlenja.HeaderText = "Datum zaposlenja";
            this.DatumZaposlenja.Name = "DatumZaposlenja";
            this.DatumZaposlenja.ReadOnly = true;
            // 
            // Opcina
            // 
            this.Opcina.DataPropertyName = "Opcina";
            this.Opcina.HeaderText = "Općina";
            this.Opcina.Name = "Opcina";
            this.Opcina.ReadOnly = true;
            // 
            // BrojKarata
            // 
            this.BrojKarata.DataPropertyName = "BrojKarata";
            this.BrojKarata.HeaderText = "Broj prodatih karata";
            this.BrojKarata.Name = "BrojKarata";
            this.BrojKarata.ReadOnly = true;
            // 
            // cbxOpcine
            // 
            this.cbxOpcine.FormattingEnabled = true;
            this.cbxOpcine.Location = new System.Drawing.Point(13, 37);
            this.cbxOpcine.Name = "cbxOpcine";
            this.cbxOpcine.Size = new System.Drawing.Size(152, 21);
            this.cbxOpcine.TabIndex = 2;
            this.cbxOpcine.SelectionChangeCommitted += new System.EventHandler(this.cbxOpcine_SelectionChangeCommitted);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(192, 41);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 13);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime: ";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(366, 41);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(50, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime: ";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(219, 38);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(141, 20);
            this.txtIme.TabIndex = 5;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(412, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(141, 20);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // lblBrojZaposlenika
            // 
            this.lblBrojZaposlenika.AutoSize = true;
            this.lblBrojZaposlenika.Location = new System.Drawing.Point(12, 500);
            this.lblBrojZaposlenika.Name = "lblBrojZaposlenika";
            this.lblBrojZaposlenika.Size = new System.Drawing.Size(90, 13);
            this.lblBrojZaposlenika.TabIndex = 7;
            this.lblBrojZaposlenika.Text = "Broj zaposlenika: ";
            // 
            // lblBZ
            // 
            this.lblBZ.AutoSize = true;
            this.lblBZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBZ.Location = new System.Drawing.Point(96, 500);
            this.lblBZ.Name = "lblBZ";
            this.lblBZ.Size = new System.Drawing.Size(23, 13);
            this.lblBZ.TabIndex = 8;
            this.lblBZ.Text = "BZ";
            // 
            // lblZaposlenici
            // 
            this.lblZaposlenici.AutoSize = true;
            this.lblZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaposlenici.Location = new System.Drawing.Point(290, 9);
            this.lblZaposlenici.Name = "lblZaposlenici";
            this.lblZaposlenici.Size = new System.Drawing.Size(91, 17);
            this.lblZaposlenici.TabIndex = 16;
            this.lblZaposlenici.Text = "Zaposlenici";
            // 
            // btnVidiIzdateKarte
            // 
            this.btnVidiIzdateKarte.Location = new System.Drawing.Point(556, 500);
            this.btnVidiIzdateKarte.Name = "btnVidiIzdateKarte";
            this.btnVidiIzdateKarte.Size = new System.Drawing.Size(121, 23);
            this.btnVidiIzdateKarte.TabIndex = 17;
            this.btnVidiIzdateKarte.Text = "Vidi izdate karte";
            this.btnVidiIzdateKarte.UseVisualStyleBackColor = true;
            this.btnVidiIzdateKarte.Click += new System.EventHandler(this.btnVidiIzdateKarte_Click);
            // 
            // btnIzvjestajZaposlenici
            // 
            this.btnIzvjestajZaposlenici.Location = new System.Drawing.Point(412, 500);
            this.btnIzvjestajZaposlenici.Name = "btnIzvjestajZaposlenici";
            this.btnIzvjestajZaposlenici.Size = new System.Drawing.Size(138, 23);
            this.btnIzvjestajZaposlenici.TabIndex = 18;
            this.btnIzvjestajZaposlenici.Text = "Izvještaj o zaposlenicima";
            this.btnIzvjestajZaposlenici.UseVisualStyleBackColor = true;
            this.btnIzvjestajZaposlenici.Click += new System.EventHandler(this.btnIzvjestajZaposlenici_Click);
            // 
            // Frm_Zaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 549);
            this.Controls.Add(this.btnIzvjestajZaposlenici);
            this.Controls.Add(this.btnVidiIzdateKarte);
            this.Controls.Add(this.lblZaposlenici);
            this.Controls.Add(this.lblBZ);
            this.Controls.Add(this.lblBrojZaposlenika);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.cbxOpcine);
            this.Controls.Add(this.dgZaposlenici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Zaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Frm_Zaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZaposlenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcina;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKarata;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.ComboBox cbxOpcine;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblBrojZaposlenika;
        private System.Windows.Forms.Label lblBZ;
        private System.Windows.Forms.Label lblZaposlenici;
        private System.Windows.Forms.Button btnVidiIzdateKarte;
        private System.Windows.Forms.Button btnIzvjestajZaposlenici;
    }
}