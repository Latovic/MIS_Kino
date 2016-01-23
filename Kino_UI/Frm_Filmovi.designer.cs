namespace Kino_UI
{
    partial class Frm_Filmovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filmovi));
            this.dgFilmovi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlavniGlumci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reziser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProjekcija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblReziser = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtReziser = new System.Windows.Forms.TextBox();
            this.cbxZanrovi = new System.Windows.Forms.ComboBox();
            this.lblBrojFilmova = new System.Windows.Forms.Label();
            this.lblBF = new System.Windows.Forms.Label();
            this.btnPregledProjekcija = new System.Windows.Forms.Button();
            this.lblFilmovi = new System.Windows.Forms.Label();
            this.btnIzvjestajFilmovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFilmovi
            // 
            this.dgFilmovi.AllowUserToAddRows = false;
            this.dgFilmovi.AllowUserToDeleteRows = false;
            this.dgFilmovi.AllowUserToOrderColumns = true;
            this.dgFilmovi.AllowUserToResizeRows = false;
            this.dgFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFilmovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Opis,
            this.GlavniGlumci,
            this.GodinaProizvodnje,
            this.Reziser,
            this.Drzava,
            this.Trajanje,
            this.ProsjecnaOcjena,
            this.BrojProjekcija});
            this.dgFilmovi.Location = new System.Drawing.Point(24, 76);
            this.dgFilmovi.Name = "dgFilmovi";
            this.dgFilmovi.ReadOnly = true;
            this.dgFilmovi.RowHeadersVisible = false;
            this.dgFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFilmovi.Size = new System.Drawing.Size(686, 422);
            this.dgFilmovi.TabIndex = 1;
            this.dgFilmovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFilmovi_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "FilmID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // GlavniGlumci
            // 
            this.GlavniGlumci.DataPropertyName = "GlavniGlumci";
            this.GlavniGlumci.HeaderText = "Glavni glumci";
            this.GlavniGlumci.Name = "GlavniGlumci";
            this.GlavniGlumci.ReadOnly = true;
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.DataPropertyName = "GodinaProizvodnje";
            this.GodinaProizvodnje.HeaderText = "Godina izlaska";
            this.GodinaProizvodnje.Name = "GodinaProizvodnje";
            this.GodinaProizvodnje.ReadOnly = true;
            // 
            // Reziser
            // 
            this.Reziser.DataPropertyName = "Reziser";
            this.Reziser.HeaderText = "Režiser";
            this.Reziser.Name = "Reziser";
            this.Reziser.ReadOnly = true;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Država";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // Trajanje
            // 
            this.Trajanje.DataPropertyName = "Trajanje";
            this.Trajanje.HeaderText = "Trajanje";
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            // 
            // BrojProjekcija
            // 
            this.BrojProjekcija.DataPropertyName = "BrojProjekcija";
            this.BrojProjekcija.HeaderText = "Broj projekcija";
            this.BrojProjekcija.Name = "BrojProjekcija";
            this.BrojProjekcija.ReadOnly = true;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(168, 43);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(61, 13);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv filma:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(347, 43);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(79, 13);
            this.lblGodina.TabIndex = 3;
            this.lblGodina.Text = "Godina izlaska:";
            // 
            // lblReziser
            // 
            this.lblReziser.AutoSize = true;
            this.lblReziser.Location = new System.Drawing.Point(548, 44);
            this.lblReziser.Name = "lblReziser";
            this.lblReziser.Size = new System.Drawing.Size(45, 13);
            this.lblReziser.TabIndex = 4;
            this.lblReziser.Text = "Režiser:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(235, 40);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(109, 20);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(432, 41);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(110, 20);
            this.txtGodina.TabIndex = 6;
            this.txtGodina.TextChanged += new System.EventHandler(this.txtGodina_TextChanged);
            // 
            // txtReziser
            // 
            this.txtReziser.Location = new System.Drawing.Point(599, 41);
            this.txtReziser.Name = "txtReziser";
            this.txtReziser.Size = new System.Drawing.Size(111, 20);
            this.txtReziser.TabIndex = 7;
            this.txtReziser.TextChanged += new System.EventHandler(this.txtReziser_TextChanged);
            // 
            // cbxZanrovi
            // 
            this.cbxZanrovi.FormattingEnabled = true;
            this.cbxZanrovi.Location = new System.Drawing.Point(24, 40);
            this.cbxZanrovi.Name = "cbxZanrovi";
            this.cbxZanrovi.Size = new System.Drawing.Size(138, 21);
            this.cbxZanrovi.TabIndex = 8;
            this.cbxZanrovi.SelectionChangeCommitted += new System.EventHandler(this.cbxZanrovi_SelectionChangeCommitted);
            // 
            // lblBrojFilmova
            // 
            this.lblBrojFilmova.AutoSize = true;
            this.lblBrojFilmova.Location = new System.Drawing.Point(21, 512);
            this.lblBrojFilmova.Name = "lblBrojFilmova";
            this.lblBrojFilmova.Size = new System.Drawing.Size(67, 13);
            this.lblBrojFilmova.TabIndex = 9;
            this.lblBrojFilmova.Text = "Broj filmova: ";
            // 
            // lblBF
            // 
            this.lblBF.AutoSize = true;
            this.lblBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBF.Location = new System.Drawing.Point(85, 512);
            this.lblBF.Name = "lblBF";
            this.lblBF.Size = new System.Drawing.Size(22, 13);
            this.lblBF.TabIndex = 10;
            this.lblBF.Text = "BF";
            // 
            // btnPregledProjekcija
            // 
            this.btnPregledProjekcija.Location = new System.Drawing.Point(583, 512);
            this.btnPregledProjekcija.Name = "btnPregledProjekcija";
            this.btnPregledProjekcija.Size = new System.Drawing.Size(127, 23);
            this.btnPregledProjekcija.TabIndex = 11;
            this.btnPregledProjekcija.Text = "Vidi projekcije";
            this.btnPregledProjekcija.UseVisualStyleBackColor = true;
            this.btnPregledProjekcija.Click += new System.EventHandler(this.btnPregledProjekcija_Click);
            // 
            // lblFilmovi
            // 
            this.lblFilmovi.AutoSize = true;
            this.lblFilmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilmovi.Location = new System.Drawing.Point(317, 9);
            this.lblFilmovi.Name = "lblFilmovi";
            this.lblFilmovi.Size = new System.Drawing.Size(58, 17);
            this.lblFilmovi.TabIndex = 14;
            this.lblFilmovi.Text = "Filmovi";
            // 
            // btnIzvjestajFilmovi
            // 
            this.btnIzvjestajFilmovi.Location = new System.Drawing.Point(458, 512);
            this.btnIzvjestajFilmovi.Name = "btnIzvjestajFilmovi";
            this.btnIzvjestajFilmovi.Size = new System.Drawing.Size(119, 23);
            this.btnIzvjestajFilmovi.TabIndex = 15;
            this.btnIzvjestajFilmovi.Text = "Izvještaj o filmovima";
            this.btnIzvjestajFilmovi.UseVisualStyleBackColor = true;
            this.btnIzvjestajFilmovi.Click += new System.EventHandler(this.btnIzvjestajFilmovi_Click);
            // 
            // Frm_Filmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 554);
            this.Controls.Add(this.btnIzvjestajFilmovi);
            this.Controls.Add(this.lblFilmovi);
            this.Controls.Add(this.btnPregledProjekcija);
            this.Controls.Add(this.lblBF);
            this.Controls.Add(this.lblBrojFilmova);
            this.Controls.Add(this.cbxZanrovi);
            this.Controls.Add(this.txtReziser);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblReziser);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dgFilmovi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Filmovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.Frm_Filmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFilmovi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblReziser;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtReziser;
        private System.Windows.Forms.ComboBox cbxZanrovi;
        private System.Windows.Forms.Label lblBrojFilmova;
        private System.Windows.Forms.Label lblBF;
        private System.Windows.Forms.Button btnPregledProjekcija;
        private System.Windows.Forms.Label lblFilmovi;
        private System.Windows.Forms.Button btnIzvjestajFilmovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProjekcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reziser;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaProizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlavniGlumci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}