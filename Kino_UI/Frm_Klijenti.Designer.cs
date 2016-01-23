namespace Kino_UI
{
    partial class Frm_Klijenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Klijenti));
            this.dgKlijenti = new System.Windows.Forms.DataGridView();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cbxOpcine = new System.Windows.Forms.ComboBox();
            this.lblBrojKlijenata = new System.Windows.Forms.Label();
            this.btnPregledRezervacija = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblOpcina = new System.Windows.Forms.Label();
            this.lblKlijenti = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKlijenti
            // 
            this.dgKlijenti.AllowUserToAddRows = false;
            this.dgKlijenti.AllowUserToDeleteRows = false;
            this.dgKlijenti.AllowUserToOrderColumns = true;
            this.dgKlijenti.AllowUserToResizeRows = false;
            this.dgKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKlijenti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentId,
            this.Ime,
            this.Prezime,
            this.Email,
            this.KorisnickoIme,
            this.DatumRegistracije,
            this.BrojRezervacija});
            this.dgKlijenti.Location = new System.Drawing.Point(12, 77);
            this.dgKlijenti.Name = "dgKlijenti";
            this.dgKlijenti.ReadOnly = true;
            this.dgKlijenti.RowHeadersVisible = false;
            this.dgKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKlijenti.Size = new System.Drawing.Size(682, 415);
            this.dgKlijenti.TabIndex = 0;
            this.dgKlijenti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKlijenti_CellContentDoubleClick);
            // 
            // KlijentId
            // 
            this.KlijentId.DataPropertyName = "Id";
            this.KlijentId.HeaderText = "KlijentId";
            this.KlijentId.Name = "KlijentId";
            this.KlijentId.ReadOnly = true;
            this.KlijentId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.FillWeight = 66.70072F;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.FillWeight = 59.605F;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 176.8533F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.FillWeight = 66.5133F;
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // DatumRegistracije
            // 
            this.DatumRegistracije.DataPropertyName = "DatumRegistracije";
            this.DatumRegistracije.FillWeight = 70.89108F;
            this.DatumRegistracije.HeaderText = "Datum registracije";
            this.DatumRegistracije.Name = "DatumRegistracije";
            this.DatumRegistracije.ReadOnly = true;
            // 
            // BrojRezervacija
            // 
            this.BrojRezervacija.DataPropertyName = "BrojRezervacija";
            this.BrojRezervacija.FillWeight = 57.15229F;
            this.BrojRezervacija.HeaderText = "Rezervacija";
            this.BrojRezervacija.Name = "BrojRezervacija";
            this.BrojRezervacija.ReadOnly = true;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(39, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(9, 39);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(145, 40);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(195, 37);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(109, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // cbxOpcine
            // 
            this.cbxOpcine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpcine.FormattingEnabled = true;
            this.cbxOpcine.Location = new System.Drawing.Point(562, 37);
            this.cbxOpcine.Name = "cbxOpcine";
            this.cbxOpcine.Size = new System.Drawing.Size(132, 21);
            this.cbxOpcine.TabIndex = 6;
            this.cbxOpcine.SelectionChangeCommitted += new System.EventHandler(this.cbxOpcine_SelectionChangeCommitted);
            // 
            // lblBrojKlijenata
            // 
            this.lblBrojKlijenata.AutoSize = true;
            this.lblBrojKlijenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojKlijenata.Location = new System.Drawing.Point(12, 503);
            this.lblBrojKlijenata.Name = "lblBrojKlijenata";
            this.lblBrojKlijenata.Size = new System.Drawing.Size(29, 13);
            this.lblBrojKlijenata.TabIndex = 7;
            this.lblBrojKlijenata.Text = "Broj";
            // 
            // btnPregledRezervacija
            // 
            this.btnPregledRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledRezervacija.Location = new System.Drawing.Point(610, 498);
            this.btnPregledRezervacija.Name = "btnPregledRezervacija";
            this.btnPregledRezervacija.Size = new System.Drawing.Size(84, 23);
            this.btnPregledRezervacija.TabIndex = 8;
            this.btnPregledRezervacija.Text = "Rezervacije";
            this.btnPregledRezervacija.UseVisualStyleBackColor = true;
            this.btnPregledRezervacija.Click += new System.EventHandler(this.btnPregledRezervacija_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(529, 498);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(310, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(394, 37);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(112, 20);
            this.txtKorisnickoIme.TabIndex = 10;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // lblOpcina
            // 
            this.lblOpcina.AutoSize = true;
            this.lblOpcina.Location = new System.Drawing.Point(512, 42);
            this.lblOpcina.Name = "lblOpcina";
            this.lblOpcina.Size = new System.Drawing.Size(44, 13);
            this.lblOpcina.TabIndex = 12;
            this.lblOpcina.Text = "Općina:";
            // 
            // lblKlijenti
            // 
            this.lblKlijenti.AutoSize = true;
            this.lblKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKlijenti.Location = new System.Drawing.Point(331, 9);
            this.lblKlijenti.Name = "lblKlijenti";
            this.lblKlijenti.Size = new System.Drawing.Size(57, 17);
            this.lblKlijenti.TabIndex = 13;
            this.lblKlijenti.Text = "Klijenti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Izvještaj o registracijama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Klijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKlijenti);
            this.Controls.Add(this.lblOpcina);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPregledRezervacija);
            this.Controls.Add(this.lblBrojKlijenata);
            this.Controls.Add(this.cbxOpcine);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgKlijenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Klijenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.Frm_Klijenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKlijenti;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cbxOpcine;
        private System.Windows.Forms.Label lblBrojKlijenata;
        private System.Windows.Forms.Button btnPregledRezervacija;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblOpcina;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija;
        private System.Windows.Forms.Label lblKlijenti;
        private System.Windows.Forms.Button button1;
    }
}