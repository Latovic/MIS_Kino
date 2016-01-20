namespace Kino_UI
{
    partial class Frm_KlijentiRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KlijentiRezervacije));
            this.dgRezervacije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPlacena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRezervacije = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.lblDo = new System.Windows.Forms.Label();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFilterOd = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterDo = new System.Windows.Forms.CheckBox();
            this.lblBrojac = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRezervacije
            // 
            this.dgRezervacije.AllowUserToAddRows = false;
            this.dgRezervacije.AllowUserToDeleteRows = false;
            this.dgRezervacije.AllowUserToResizeRows = false;
            this.dgRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRezervacije.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumVrijeme,
            this.isPlacena,
            this.Cijena,
            this.BrojKarata});
            this.dgRezervacije.Location = new System.Drawing.Point(11, 104);
            this.dgRezervacije.Name = "dgRezervacije";
            this.dgRezervacije.ReadOnly = true;
            this.dgRezervacije.RowHeadersVisible = false;
            this.dgRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRezervacije.Size = new System.Drawing.Size(464, 265);
            this.dgRezervacije.TabIndex = 0;
            this.dgRezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRezervacije_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // isPlacena
            // 
            this.isPlacena.DataPropertyName = "isPlacena";
            this.isPlacena.HeaderText = "Plaćena";
            this.isPlacena.Name = "isPlacena";
            this.isPlacena.ReadOnly = true;
            this.isPlacena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isPlacena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // BrojKarata
            // 
            this.BrojKarata.DataPropertyName = "BrojKarata";
            this.BrojKarata.FillWeight = 50F;
            this.BrojKarata.HeaderText = "Br. karata";
            this.BrojKarata.Name = "BrojKarata";
            this.BrojKarata.ReadOnly = true;
            // 
            // lblRezervacije
            // 
            this.lblRezervacije.AutoSize = true;
            this.lblRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezervacije.Location = new System.Drawing.Point(202, 9);
            this.lblRezervacije.Name = "lblRezervacije";
            this.lblRezervacije.Size = new System.Drawing.Size(93, 17);
            this.lblRezervacije.TabIndex = 1;
            this.lblRezervacije.Text = "Rezervacije";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(393, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 26);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(11, 78);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(200, 20);
            this.datumDo.TabIndex = 15;
            this.datumDo.ValueChanged += new System.EventHandler(this.datumDo_ValueChanged);
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(89, 62);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(19, 13);
            this.lblDo.TabIndex = 16;
            this.lblDo.Text = "do";
            // 
            // datumOd
            // 
            this.datumOd.Location = new System.Drawing.Point(11, 39);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(200, 20);
            this.datumOd.TabIndex = 14;
            this.datumOd.ValueChanged += new System.EventHandler(this.datumOd_ValueChanged);
            // 
            // checkBoxFilterOd
            // 
            this.checkBoxFilterOd.AutoSize = true;
            this.checkBoxFilterOd.Location = new System.Drawing.Point(218, 41);
            this.checkBoxFilterOd.Name = "checkBoxFilterOd";
            this.checkBoxFilterOd.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFilterOd.TabIndex = 17;
            this.checkBoxFilterOd.UseVisualStyleBackColor = true;
            this.checkBoxFilterOd.CheckedChanged += new System.EventHandler(this.checkBoxFilterOd_CheckedChanged);
            // 
            // checkBoxFilterDo
            // 
            this.checkBoxFilterDo.AutoSize = true;
            this.checkBoxFilterDo.Location = new System.Drawing.Point(218, 81);
            this.checkBoxFilterDo.Name = "checkBoxFilterDo";
            this.checkBoxFilterDo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFilterDo.TabIndex = 18;
            this.checkBoxFilterDo.UseVisualStyleBackColor = true;
            this.checkBoxFilterDo.CheckedChanged += new System.EventHandler(this.checkBoxFilterDo_CheckedChanged);
            // 
            // lblBrojac
            // 
            this.lblBrojac.AutoSize = true;
            this.lblBrojac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojac.Location = new System.Drawing.Point(12, 372);
            this.lblBrojac.Name = "lblBrojac";
            this.lblBrojac.Size = new System.Drawing.Size(43, 13);
            this.lblBrojac.TabIndex = 19;
            this.lblBrojac.Text = "Brojač";
            this.lblBrojac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(400, 375);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Frm_KlijentiRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 404);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblBrojac);
            this.Controls.Add(this.checkBoxFilterDo);
            this.Controls.Add(this.checkBoxFilterOd);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblRezervacije);
            this.Controls.Add(this.dgRezervacije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_KlijentiRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.Frm_KlijentiRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRezervacije;
        private System.Windows.Forms.Label lblRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPlacena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKarata;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.CheckBox checkBoxFilterOd;
        private System.Windows.Forms.CheckBox checkBoxFilterDo;
        private System.Windows.Forms.Label lblBrojac;
        private System.Windows.Forms.Button btnInfo;
    }
}