namespace Kino_UI
{
    partial class Frm_Karta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Karta));
            this.dgKarte = new System.Windows.Forms.DataGridView();
            this.lbl_BrojKarti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxZaposlenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFilm = new System.Windows.Forms.ComboBox();
            this.cBox3D = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeKlijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDvorane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKarte
            // 
            this.dgKarte.AllowUserToAddRows = false;
            this.dgKarte.AllowUserToDeleteRows = false;
            this.dgKarte.AllowUserToOrderColumns = true;
            this.dgKarte.AllowUserToResizeRows = false;
            this.dgKarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKarte.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.imePrezime,
            this.imePrezimeKlijenta,
            this.Naziv,
            this.KorisnickoIme,
            this.nazivDvorane,
            this.Cijena});
            this.dgKarte.Location = new System.Drawing.Point(12, 37);
            this.dgKarte.Name = "dgKarte";
            this.dgKarte.ReadOnly = true;
            this.dgKarte.RowHeadersVisible = false;
            this.dgKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKarte.Size = new System.Drawing.Size(596, 308);
            this.dgKarte.TabIndex = 2;
            this.dgKarte.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKarte_CellDoubleClick);
            // 
            // lbl_BrojKarti
            // 
            this.lbl_BrojKarti.AutoSize = true;
            this.lbl_BrojKarti.Location = new System.Drawing.Point(87, 356);
            this.lbl_BrojKarti.Name = "lbl_BrojKarti";
            this.lbl_BrojKarti.Size = new System.Drawing.Size(35, 13);
            this.lbl_BrojKarti.TabIndex = 22;
            this.lbl_BrojKarti.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Broj karti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Zaposlenik:";
            // 
            // cbxZaposlenik
            // 
            this.cbxZaposlenik.FormattingEnabled = true;
            this.cbxZaposlenik.Location = new System.Drawing.Point(90, 10);
            this.cbxZaposlenik.Name = "cbxZaposlenik";
            this.cbxZaposlenik.Size = new System.Drawing.Size(185, 21);
            this.cbxZaposlenik.TabIndex = 31;
            this.cbxZaposlenik.SelectionChangeCommitted += new System.EventHandler(this.cbxZaposlenik_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(287, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Film:";
            // 
            // cbxFilm
            // 
            this.cbxFilm.FormattingEnabled = true;
            this.cbxFilm.Location = new System.Drawing.Point(337, 10);
            this.cbxFilm.Name = "cbxFilm";
            this.cbxFilm.Size = new System.Drawing.Size(195, 21);
            this.cbxFilm.TabIndex = 33;
            this.cbxFilm.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // cBox3D
            // 
            this.cBox3D.AutoSize = true;
            this.cBox3D.Location = new System.Drawing.Point(568, 12);
            this.cBox3D.Name = "cBox3D";
            this.cBox3D.Size = new System.Drawing.Size(40, 17);
            this.cBox3D.TabIndex = 35;
            this.cBox3D.Text = "3D";
            this.cBox3D.UseVisualStyleBackColor = true;
            this.cBox3D.CheckedChanged += new System.EventHandler(this.cBox3D_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(533, 351);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            // 
            // imePrezime
            // 
            this.imePrezime.DataPropertyName = "imePrezime";
            this.imePrezime.HeaderText = "Zaposlenik";
            this.imePrezime.Name = "imePrezime";
            this.imePrezime.ReadOnly = true;
            // 
            // imePrezimeKlijenta
            // 
            this.imePrezimeKlijenta.DataPropertyName = "imePrezimeKlijenta";
            this.imePrezimeKlijenta.HeaderText = "Klijent";
            this.imePrezimeKlijenta.Name = "imePrezimeKlijenta";
            this.imePrezimeKlijenta.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "nazivFilma";
            this.Naziv.HeaderText = "Film";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "Is3D";
            this.KorisnickoIme.HeaderText = "3D";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // nazivDvorane
            // 
            this.nazivDvorane.DataPropertyName = "nazivDvorane";
            this.nazivDvorane.HeaderText = "Dvorana";
            this.nazivDvorane.Name = "nazivDvorane";
            this.nazivDvorane.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Frm_Karta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cBox3D);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxZaposlenik);
            this.Controls.Add(this.lbl_BrojKarti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgKarte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Karta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karte";
            this.Load += new System.EventHandler(this.Frm_Karte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKarte;
        private System.Windows.Forms.Label lbl_BrojKarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxZaposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilm;
        private System.Windows.Forms.CheckBox cBox3D;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDvorane;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeKlijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezime;
    }
}