namespace Kino_UI
{
    partial class Frm_Projekcije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Projekcije));
            this.dgProjekcije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDvorane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAktivna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPremijera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPretprodaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isZaDjecu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDomaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDo = new System.Windows.Forms.DateTimePicker();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.cbxOd = new System.Windows.Forms.CheckBox();
            this.cbxDo = new System.Windows.Forms.CheckBox();
            this.lblBrojProjekcija = new System.Windows.Forms.Label();
            this.lblBP = new System.Windows.Forms.Label();
            this.lblProjekcije = new System.Windows.Forms.Label();
            this.btnIzvjestajProjekcije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProjekcije
            // 
            this.dgProjekcije.AllowUserToAddRows = false;
            this.dgProjekcije.AllowUserToDeleteRows = false;
            this.dgProjekcije.AllowUserToResizeRows = false;
            this.dgProjekcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProjekcije.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjekcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NazivFilma,
            this.DatumVrijeme,
            this.Cijena,
            this.NazivDvorane,
            this.BrojKarata,
            this.isAktivna,
            this.isPremijera,
            this.isPretprodaja,
            this.isZaDjecu,
            this.isDomaci});
            this.dgProjekcije.Location = new System.Drawing.Point(12, 87);
            this.dgProjekcije.Name = "dgProjekcije";
            this.dgProjekcije.ReadOnly = true;
            this.dgProjekcije.RowHeadersVisible = false;
            this.dgProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProjekcije.Size = new System.Drawing.Size(702, 308);
            this.dgProjekcije.TabIndex = 1;
            this.dgProjekcije.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProjekcije_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ProjekcijaID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NazivFilma
            // 
            this.NazivFilma.DataPropertyName = "NazivFilma";
            this.NazivFilma.HeaderText = "Naziv filma";
            this.NazivFilma.Name = "NazivFilma";
            this.NazivFilma.ReadOnly = true;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme početka";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // NazivDvorane
            // 
            this.NazivDvorane.DataPropertyName = "NazivDvorane";
            this.NazivDvorane.HeaderText = "Naziv dvorane";
            this.NazivDvorane.Name = "NazivDvorane";
            this.NazivDvorane.ReadOnly = true;
            // 
            // BrojKarata
            // 
            this.BrojKarata.DataPropertyName = "BrojKarata";
            this.BrojKarata.HeaderText = "Broj prodatih karata";
            this.BrojKarata.Name = "BrojKarata";
            this.BrojKarata.ReadOnly = true;
            // 
            // isAktivna
            // 
            this.isAktivna.DataPropertyName = "isAktivna";
            this.isAktivna.HeaderText = "Aktivna";
            this.isAktivna.Name = "isAktivna";
            this.isAktivna.ReadOnly = true;
            // 
            // isPremijera
            // 
            this.isPremijera.DataPropertyName = "isPremijera";
            this.isPremijera.HeaderText = "Premijera";
            this.isPremijera.Name = "isPremijera";
            this.isPremijera.ReadOnly = true;
            // 
            // isPretprodaja
            // 
            this.isPretprodaja.DataPropertyName = "isPretprodaja";
            this.isPretprodaja.HeaderText = "Pretprodaja";
            this.isPretprodaja.Name = "isPretprodaja";
            this.isPretprodaja.ReadOnly = true;
            // 
            // isZaDjecu
            // 
            this.isZaDjecu.DataPropertyName = "isZaDjecu";
            this.isZaDjecu.HeaderText = "Za djecu";
            this.isZaDjecu.Name = "isZaDjecu";
            this.isZaDjecu.ReadOnly = true;
            // 
            // isDomaci
            // 
            this.isDomaci.DataPropertyName = "isDomaci";
            this.isDomaci.HeaderText = "Domaći";
            this.isDomaci.Name = "isDomaci";
            this.isDomaci.ReadOnly = true;
            // 
            // dateTimeOd
            // 
            this.dateTimeOd.Location = new System.Drawing.Point(43, 37);
            this.dateTimeOd.Name = "dateTimeOd";
            this.dateTimeOd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOd.TabIndex = 2;
            this.dateTimeOd.ValueChanged += new System.EventHandler(this.dateTimeOd_ValueChanged);
            // 
            // dateTimeDo
            // 
            this.dateTimeDo.Location = new System.Drawing.Point(319, 37);
            this.dateTimeDo.Name = "dateTimeDo";
            this.dateTimeDo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDo.TabIndex = 3;
            this.dateTimeDo.ValueChanged += new System.EventHandler(this.dateTimeDo_ValueChanged);
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(13, 42);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 13);
            this.lblOd.TabIndex = 4;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(289, 40);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 13);
            this.lblDo.TabIndex = 5;
            this.lblDo.Text = "Do:";
            // 
            // cbxOd
            // 
            this.cbxOd.AutoSize = true;
            this.cbxOd.Location = new System.Drawing.Point(250, 39);
            this.cbxOd.Name = "cbxOd";
            this.cbxOd.Size = new System.Drawing.Size(15, 14);
            this.cbxOd.TabIndex = 6;
            this.cbxOd.UseVisualStyleBackColor = true;
            this.cbxOd.CheckedChanged += new System.EventHandler(this.cbxOd_CheckedChanged);
            // 
            // cbxDo
            // 
            this.cbxDo.AutoSize = true;
            this.cbxDo.Location = new System.Drawing.Point(526, 39);
            this.cbxDo.Name = "cbxDo";
            this.cbxDo.Size = new System.Drawing.Size(15, 14);
            this.cbxDo.TabIndex = 7;
            this.cbxDo.UseVisualStyleBackColor = true;
            this.cbxDo.CheckedChanged += new System.EventHandler(this.cbxDo_CheckedChanged);
            // 
            // lblBrojProjekcija
            // 
            this.lblBrojProjekcija.AutoSize = true;
            this.lblBrojProjekcija.Location = new System.Drawing.Point(13, 411);
            this.lblBrojProjekcija.Name = "lblBrojProjekcija";
            this.lblBrojProjekcija.Size = new System.Drawing.Size(79, 13);
            this.lblBrojProjekcija.TabIndex = 8;
            this.lblBrojProjekcija.Text = "Broj projekcija: ";
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBP.Location = new System.Drawing.Point(89, 411);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(36, 13);
            this.lblBP.TabIndex = 9;
            this.lblBP.Text = "lblBP";
            // 
            // lblProjekcije
            // 
            this.lblProjekcije.AutoSize = true;
            this.lblProjekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjekcije.Location = new System.Drawing.Point(301, 9);
            this.lblProjekcije.Name = "lblProjekcije";
            this.lblProjekcije.Size = new System.Drawing.Size(79, 17);
            this.lblProjekcije.TabIndex = 15;
            this.lblProjekcije.Text = "Projekcije";
            // 
            // btnIzvjestajProjekcije
            // 
            this.btnIzvjestajProjekcije.Location = new System.Drawing.Point(581, 411);
            this.btnIzvjestajProjekcije.Name = "btnIzvjestajProjekcije";
            this.btnIzvjestajProjekcije.Size = new System.Drawing.Size(133, 23);
            this.btnIzvjestajProjekcije.TabIndex = 16;
            this.btnIzvjestajProjekcije.Text = "Izvještaj o projekcijama";
            this.btnIzvjestajProjekcije.UseVisualStyleBackColor = true;
            this.btnIzvjestajProjekcije.Click += new System.EventHandler(this.btnIzvjestajProjekcije_Click);
            // 
            // Frm_Projekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 476);
            this.Controls.Add(this.btnIzvjestajProjekcije);
            this.Controls.Add(this.lblProjekcije);
            this.Controls.Add(this.lblBP);
            this.Controls.Add(this.lblBrojProjekcija);
            this.Controls.Add(this.cbxDo);
            this.Controls.Add(this.cbxOd);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.dateTimeDo);
            this.Controls.Add(this.dateTimeOd);
            this.Controls.Add(this.dgProjekcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Projekcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekcije";
            this.Load += new System.EventHandler(this.Frm_Projekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProjekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProjekcije;
        private System.Windows.Forms.DateTimePicker dateTimeOd;
        private System.Windows.Forms.DateTimePicker dateTimeDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.CheckBox cbxOd;
        private System.Windows.Forms.CheckBox cbxDo;
        private System.Windows.Forms.Label lblBrojProjekcija;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKarata;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDomaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn isZaDjecu;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPretprodaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPremijera;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAktivna;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDvorane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label lblProjekcije;
        private System.Windows.Forms.Button btnIzvjestajProjekcije;
    }
}