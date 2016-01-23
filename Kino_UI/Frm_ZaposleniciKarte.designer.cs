namespace Kino_UI
{
    partial class Frm_ZaposleniciKarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ZaposleniciKarte));
            this.dgKarte = new System.Windows.Forms.DataGridView();
            this.NazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDvorane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPopusta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrojKarata = new System.Windows.Forms.Label();
            this.lblBK = new System.Windows.Forms.Label();
            this.dateTimeOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDo = new System.Windows.Forms.DateTimePicker();
            this.cbxOd = new System.Windows.Forms.CheckBox();
            this.cbxDo = new System.Windows.Forms.CheckBox();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblKarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKarte
            // 
            this.dgKarte.AllowUserToAddRows = false;
            this.dgKarte.AllowUserToDeleteRows = false;
            this.dgKarte.AllowUserToResizeRows = false;
            this.dgKarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKarte.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivFilma,
            this.NazivDvorane,
            this.Red,
            this.Kolona,
            this.DatumVrijeme,
            this.Cijena,
            this.NazivPopusta});
            this.dgKarte.Location = new System.Drawing.Point(16, 92);
            this.dgKarte.Name = "dgKarte";
            this.dgKarte.ReadOnly = true;
            this.dgKarte.RowHeadersVisible = false;
            this.dgKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKarte.Size = new System.Drawing.Size(652, 329);
            this.dgKarte.TabIndex = 1;
            // 
            // NazivFilma
            // 
            this.NazivFilma.DataPropertyName = "NazivFilma";
            this.NazivFilma.HeaderText = "Naziv filma";
            this.NazivFilma.Name = "NazivFilma";
            this.NazivFilma.ReadOnly = true;
            // 
            // NazivDvorane
            // 
            this.NazivDvorane.DataPropertyName = "NazivDvorane";
            this.NazivDvorane.HeaderText = "Naziv dvorane";
            this.NazivDvorane.Name = "NazivDvorane";
            this.NazivDvorane.ReadOnly = true;
            // 
            // Red
            // 
            this.Red.DataPropertyName = "Red";
            this.Red.HeaderText = "Red";
            this.Red.Name = "Red";
            this.Red.ReadOnly = true;
            // 
            // Kolona
            // 
            this.Kolona.DataPropertyName = "Kolona";
            this.Kolona.HeaderText = "Broj sjedišta";
            this.Kolona.Name = "Kolona";
            this.Kolona.ReadOnly = true;
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
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // NazivPopusta
            // 
            this.NazivPopusta.DataPropertyName = "NazivPopusta";
            this.NazivPopusta.HeaderText = "Naziv popusta";
            this.NazivPopusta.Name = "NazivPopusta";
            this.NazivPopusta.ReadOnly = true;
            // 
            // lblBrojKarata
            // 
            this.lblBrojKarata.AutoSize = true;
            this.lblBrojKarata.Location = new System.Drawing.Point(13, 435);
            this.lblBrojKarata.Name = "lblBrojKarata";
            this.lblBrojKarata.Size = new System.Drawing.Size(64, 13);
            this.lblBrojKarata.TabIndex = 2;
            this.lblBrojKarata.Text = "Broj karata: ";
            // 
            // lblBK
            // 
            this.lblBK.AutoSize = true;
            this.lblBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBK.Location = new System.Drawing.Point(74, 435);
            this.lblBK.Name = "lblBK";
            this.lblBK.Size = new System.Drawing.Size(23, 13);
            this.lblBK.TabIndex = 3;
            this.lblBK.Text = "BK";
            // 
            // dateTimeOd
            // 
            this.dateTimeOd.Location = new System.Drawing.Point(63, 47);
            this.dateTimeOd.Name = "dateTimeOd";
            this.dateTimeOd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOd.TabIndex = 4;
            this.dateTimeOd.ValueChanged += new System.EventHandler(this.dateTimeOd_ValueChanged);
            // 
            // dateTimeDo
            // 
            this.dateTimeDo.Location = new System.Drawing.Point(365, 47);
            this.dateTimeDo.Name = "dateTimeDo";
            this.dateTimeDo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDo.TabIndex = 5;
            this.dateTimeDo.ValueChanged += new System.EventHandler(this.dateTimeDo_ValueChanged);
            // 
            // cbxOd
            // 
            this.cbxOd.AutoSize = true;
            this.cbxOd.Location = new System.Drawing.Point(269, 53);
            this.cbxOd.Name = "cbxOd";
            this.cbxOd.Size = new System.Drawing.Size(15, 14);
            this.cbxOd.TabIndex = 6;
            this.cbxOd.UseVisualStyleBackColor = true;
            this.cbxOd.CheckedChanged += new System.EventHandler(this.cbxOd_CheckedChanged);
            // 
            // cbxDo
            // 
            this.cbxDo.AutoSize = true;
            this.cbxDo.Location = new System.Drawing.Point(571, 53);
            this.cbxDo.Name = "cbxDo";
            this.cbxDo.Size = new System.Drawing.Size(15, 14);
            this.cbxDo.TabIndex = 7;
            this.cbxDo.UseVisualStyleBackColor = true;
            this.cbxDo.CheckedChanged += new System.EventHandler(this.cbxDo_CheckedChanged);
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(30, 52);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(27, 13);
            this.lblOd.TabIndex = 8;
            this.lblOd.Text = "Od: ";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(332, 52);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(27, 13);
            this.lblDo.TabIndex = 9;
            this.lblDo.Text = "Do: ";
            // 
            // lblKarte
            // 
            this.lblKarte.AutoSize = true;
            this.lblKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKarte.Location = new System.Drawing.Point(285, 9);
            this.lblKarte.Name = "lblKarte";
            this.lblKarte.Size = new System.Drawing.Size(47, 17);
            this.lblKarte.TabIndex = 17;
            this.lblKarte.Text = "Karte";
            // 
            // Frm_ZaposleniciKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 492);
            this.Controls.Add(this.lblKarte);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.cbxDo);
            this.Controls.Add(this.cbxOd);
            this.Controls.Add(this.dateTimeDo);
            this.Controls.Add(this.dateTimeOd);
            this.Controls.Add(this.lblBK);
            this.Controls.Add(this.lblBrojKarata);
            this.Controls.Add(this.dgKarte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Frm_ZaposleniciKarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenik - Prodate karte";
            this.Load += new System.EventHandler(this.Frm_ZaposleniciKarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDvorane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPopusta;
        private System.Windows.Forms.Label lblBrojKarata;
        private System.Windows.Forms.Label lblBK;
        private System.Windows.Forms.DateTimePicker dateTimeOd;
        private System.Windows.Forms.DateTimePicker dateTimeDo;
        private System.Windows.Forms.CheckBox cbxOd;
        private System.Windows.Forms.CheckBox cbxDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblKarte;
    }
}