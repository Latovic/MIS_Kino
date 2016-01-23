namespace Kino_UI
{
    partial class Frm_Proizvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proizvodi));
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.KategorijaProizvodaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_BrojProizvoda = new System.Windows.Forms.Label();
            this.tbCijenaOd = new System.Windows.Forms.TrackBar();
            this.tbCijenaDo = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCijenaOd = new System.Windows.Forms.Label();
            this.lblCijenaDo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxKategorije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCijenaOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCijenaDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.AllowUserToAddRows = false;
            this.dgProizvodi.AllowUserToDeleteRows = false;
            this.dgProizvodi.AllowUserToOrderColumns = true;
            this.dgProizvodi.AllowUserToResizeRows = false;
            this.dgProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProizvodi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaProizvodaId,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.Kolicina,
            this.Opis});
            this.dgProizvodi.Location = new System.Drawing.Point(12, 96);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.ReadOnly = true;
            this.dgProizvodi.RowHeadersVisible = false;
            this.dgProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProizvodi.Size = new System.Drawing.Size(530, 266);
            this.dgProizvodi.TabIndex = 1;
            // 
            // KategorijaProizvodaId
            // 
            this.KategorijaProizvodaId.DataPropertyName = "KategorijaProizvodaId";
            this.KategorijaProizvodaId.HeaderText = "kategorija";
            this.KategorijaProizvodaId.Name = "KategorijaProizvodaId";
            this.KategorijaProizvodaId.ReadOnly = true;
            this.KategorijaProizvodaId.Visible = false;
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
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(67, 6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(113, 20);
            this.txtNaziv.TabIndex = 15;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(9, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(43, 13);
            this.lblIme.TabIndex = 16;
            this.lblIme.Text = "Naziv:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(186, 9);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(37, 13);
            this.lblPrezime.TabIndex = 18;
            this.lblPrezime.Text = "Šifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(229, 6);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(119, 20);
            this.txtSifra.TabIndex = 17;
            this.txtSifra.TextChanged += new System.EventHandler(this.txtSifra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Broj proizvoda:";
            // 
            // lbl_BrojProizvoda
            // 
            this.lbl_BrojProizvoda.AutoSize = true;
            this.lbl_BrojProizvoda.Location = new System.Drawing.Point(108, 372);
            this.lbl_BrojProizvoda.Name = "lbl_BrojProizvoda";
            this.lbl_BrojProizvoda.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojProizvoda.TabIndex = 20;
            this.lbl_BrojProizvoda.Text = "label2";
            // 
            // tbCijenaOd
            // 
            this.tbCijenaOd.Location = new System.Drawing.Point(134, 40);
            this.tbCijenaOd.Name = "tbCijenaOd";
            this.tbCijenaOd.Size = new System.Drawing.Size(176, 45);
            this.tbCijenaOd.TabIndex = 21;
            this.tbCijenaOd.ValueChanged += new System.EventHandler(this.tbCijenaOd_ValueChanged);
            // 
            // tbCijenaDo
            // 
            this.tbCijenaDo.Location = new System.Drawing.Point(366, 40);
            this.tbCijenaDo.Name = "tbCijenaDo";
            this.tbCijenaDo.Size = new System.Drawing.Size(176, 45);
            this.tbCijenaDo.TabIndex = 22;
            this.tbCijenaDo.Value = 10;
            this.tbCijenaDo.ValueChanged += new System.EventHandler(this.tbCijenaDo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(89, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Od:";
            // 
            // lblCijenaOd
            // 
            this.lblCijenaOd.AutoSize = true;
            this.lblCijenaOd.Location = new System.Drawing.Point(89, 58);
            this.lblCijenaOd.Name = "lblCijenaOd";
            this.lblCijenaOd.Size = new System.Drawing.Size(24, 13);
            this.lblCijenaOd.TabIndex = 25;
            this.lblCijenaOd.Text = "Od:";
            // 
            // lblCijenaDo
            // 
            this.lblCijenaDo.AutoSize = true;
            this.lblCijenaDo.Location = new System.Drawing.Point(336, 58);
            this.lblCijenaDo.Name = "lblCijenaDo";
            this.lblCijenaDo.Size = new System.Drawing.Size(24, 13);
            this.lblCijenaDo.TabIndex = 27;
            this.lblCijenaDo.Text = "Od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(336, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Do:";
            // 
            // cbxKategorije
            // 
            this.cbxKategorije.FormattingEnabled = true;
            this.cbxKategorije.Location = new System.Drawing.Point(421, 6);
            this.cbxKategorije.Name = "cbxKategorije";
            this.cbxKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbxKategorije.TabIndex = 29;
            this.cbxKategorije.SelectionChangeCommitted += new System.EventHandler(this.cbxKategorije_SelectionChangeCommitted_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(351, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kategorije";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(467, 367);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 408);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxKategorije);
            this.Controls.Add(this.lblCijenaDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCijenaOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCijenaDo);
            this.Controls.Add(this.tbCijenaOd);
            this.Controls.Add(this.lbl_BrojProizvoda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgProizvodi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Proizvodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Frm_Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCijenaOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCijenaDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BrojProizvoda;
        private System.Windows.Forms.TrackBar tbCijenaOd;
        private System.Windows.Forms.TrackBar tbCijenaDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCijenaOd;
        private System.Windows.Forms.Label lblCijenaDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaProizvodaId;
        private System.Windows.Forms.ComboBox cbxKategorije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
    }
}

