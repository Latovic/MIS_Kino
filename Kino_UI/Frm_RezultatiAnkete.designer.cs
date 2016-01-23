namespace Kino_UI
{
    partial class Frm_RezultatiAnkete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RezultatiAnkete));
            this.dgRezultatiAnkete = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojGlasova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRezultatiAnkete = new System.Windows.Forms.Label();
            this.btnIzvjestajRezultati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezultatiAnkete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRezultatiAnkete
            // 
            this.dgRezultatiAnkete.AllowUserToAddRows = false;
            this.dgRezultatiAnkete.AllowUserToDeleteRows = false;
            this.dgRezultatiAnkete.AllowUserToResizeRows = false;
            this.dgRezultatiAnkete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRezultatiAnkete.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgRezultatiAnkete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezultatiAnkete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Pitanje,
            this.Odg,
            this.BrojGlasova});
            this.dgRezultatiAnkete.Location = new System.Drawing.Point(12, 46);
            this.dgRezultatiAnkete.Name = "dgRezultatiAnkete";
            this.dgRezultatiAnkete.ReadOnly = true;
            this.dgRezultatiAnkete.RowHeadersVisible = false;
            this.dgRezultatiAnkete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRezultatiAnkete.Size = new System.Drawing.Size(563, 353);
            this.dgRezultatiAnkete.TabIndex = 1;
            this.dgRezultatiAnkete.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRezultatiAnkete_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "OdgovorID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Pitanje
            // 
            this.Pitanje.DataPropertyName = "Pitanje";
            this.Pitanje.HeaderText = "Pitanje";
            this.Pitanje.Name = "Pitanje";
            this.Pitanje.ReadOnly = true;
            // 
            // Odg
            // 
            this.Odg.DataPropertyName = "Odg";
            this.Odg.HeaderText = "Odgovor";
            this.Odg.Name = "Odg";
            this.Odg.ReadOnly = true;
            // 
            // BrojGlasova
            // 
            this.BrojGlasova.DataPropertyName = "BrojGlasova";
            this.BrojGlasova.HeaderText = "Broj glasova";
            this.BrojGlasova.Name = "BrojGlasova";
            this.BrojGlasova.ReadOnly = true;
            // 
            // lblRezultatiAnkete
            // 
            this.lblRezultatiAnkete.AutoSize = true;
            this.lblRezultatiAnkete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezultatiAnkete.Location = new System.Drawing.Point(238, 9);
            this.lblRezultatiAnkete.Name = "lblRezultatiAnkete";
            this.lblRezultatiAnkete.Size = new System.Drawing.Size(126, 17);
            this.lblRezultatiAnkete.TabIndex = 2;
            this.lblRezultatiAnkete.Text = "Rezultati ankete";
            // 
            // btnIzvjestajRezultati
            // 
            this.btnIzvjestajRezultati.Location = new System.Drawing.Point(448, 405);
            this.btnIzvjestajRezultati.Name = "btnIzvjestajRezultati";
            this.btnIzvjestajRezultati.Size = new System.Drawing.Size(127, 23);
            this.btnIzvjestajRezultati.TabIndex = 3;
            this.btnIzvjestajRezultati.Text = "Izvještaj o rezultatima";
            this.btnIzvjestajRezultati.UseVisualStyleBackColor = true;
            this.btnIzvjestajRezultati.Click += new System.EventHandler(this.btnIzvjestajRezultati_Click);
            // 
            // Frm_RezultatiAnkete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 447);
            this.Controls.Add(this.btnIzvjestajRezultati);
            this.Controls.Add(this.lblRezultatiAnkete);
            this.Controls.Add(this.dgRezultatiAnkete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RezultatiAnkete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezultati ankete";
            this.Load += new System.EventHandler(this.Frm_RezultatiAnkete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRezultatiAnkete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRezultatiAnkete;
        private System.Windows.Forms.Label lblRezultatiAnkete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojGlasova;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button btnIzvjestajRezultati;
    }
}