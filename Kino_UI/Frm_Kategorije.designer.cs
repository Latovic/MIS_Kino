namespace Kino_UI
{
    partial class Frm_Kategorije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Kategorije));
            this.dgKategorije = new System.Windows.Forms.DataGridView();
            this.KategorijaProizvodaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrojKategorija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategorijaNaziv = new System.Windows.Forms.TextBox();
            this.btnProizvod = new System.Windows.Forms.Button();
            this.txtProizvodNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKategorije
            // 
            this.dgKategorije.AllowUserToAddRows = false;
            this.dgKategorije.AllowUserToDeleteRows = false;
            this.dgKategorije.AllowUserToOrderColumns = true;
            this.dgKategorije.AllowUserToResizeRows = false;
            this.dgKategorije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKategorije.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaProizvodaId,
            this.Naziv,
            this.BrojProizvoda});
            this.dgKategorije.Location = new System.Drawing.Point(12, 77);
            this.dgKategorije.Name = "dgKategorije";
            this.dgKategorije.ReadOnly = true;
            this.dgKategorije.RowHeadersVisible = false;
            this.dgKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKategorije.Size = new System.Drawing.Size(359, 265);
            this.dgKategorije.TabIndex = 2;
            this.dgKategorije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKategorije_CellDoubleClick);
            // 
            // KategorijaProizvodaId
            // 
            this.KategorijaProizvodaId.DataPropertyName = "Id";
            this.KategorijaProizvodaId.HeaderText = "KategorijaProizvodaId";
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
            // BrojProizvoda
            // 
            this.BrojProizvoda.DataPropertyName = "BrojProizvoda";
            this.BrojProizvoda.HeaderText = "Broj proizvoda";
            this.BrojProizvoda.Name = "BrojProizvoda";
            this.BrojProizvoda.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj kategorija:";
            // 
            // lblBrojKategorija
            // 
            this.lblBrojKategorija.AutoSize = true;
            this.lblBrojKategorija.Location = new System.Drawing.Point(107, 361);
            this.lblBrojKategorija.Name = "lblBrojKategorija";
            this.lblBrojKategorija.Size = new System.Drawing.Size(35, 13);
            this.lblBrojKategorija.TabIndex = 6;
            this.lblBrojKategorija.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv kategorije:";
            // 
            // txtKategorijaNaziv
            // 
            this.txtKategorijaNaziv.Location = new System.Drawing.Point(125, 20);
            this.txtKategorijaNaziv.Name = "txtKategorijaNaziv";
            this.txtKategorijaNaziv.Size = new System.Drawing.Size(136, 20);
            this.txtKategorijaNaziv.TabIndex = 8;
            this.txtKategorijaNaziv.TextChanged += new System.EventHandler(this.txtKategorijaNaziv_TextChanged);
            // 
            // btnProizvod
            // 
            this.btnProizvod.Location = new System.Drawing.Point(257, 356);
            this.btnProizvod.Name = "btnProizvod";
            this.btnProizvod.Size = new System.Drawing.Size(114, 23);
            this.btnProizvod.TabIndex = 9;
            this.btnProizvod.Text = "Pregledaj proizvode";
            this.btnProizvod.UseVisualStyleBackColor = true;
            this.btnProizvod.Click += new System.EventHandler(this.btnProizvod_Click);
            // 
            // txtProizvodNaziv
            // 
            this.txtProizvodNaziv.Location = new System.Drawing.Point(125, 51);
            this.txtProizvodNaziv.Name = "txtProizvodNaziv";
            this.txtProizvodNaziv.Size = new System.Drawing.Size(136, 20);
            this.txtProizvodNaziv.TabIndex = 11;
            this.txtProizvodNaziv.TextChanged += new System.EventHandler(this.txtProizvodNaziv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Naziv proizvoda:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(176, 356);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_Kategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 398);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtProizvodNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProizvod);
            this.Controls.Add(this.txtKategorijaNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBrojKategorija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgKategorije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Kategorije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorije proizvoda";
            this.Load += new System.EventHandler(this.Frm_Kategorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKategorije;
        private System.Windows.Forms.Label lblBrojKategorija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategorijaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaProizvodaId;
        private System.Windows.Forms.Button btnProizvod;
        private System.Windows.Forms.TextBox txtProizvodNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
    }
}

