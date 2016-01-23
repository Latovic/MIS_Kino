namespace Kino_UI
{
    partial class Frm_Ankete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ankete));
            this.dgAnkete = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOdgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPitanje = new System.Windows.Forms.Label();
            this.lblBrojAnketa = new System.Windows.Forms.Label();
            this.lblBA = new System.Windows.Forms.Label();
            this.txtPitanje = new System.Windows.Forms.TextBox();
            this.btnVidiRezultate = new System.Windows.Forms.Button();
            this.lblAnkete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnkete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAnkete
            // 
            this.dgAnkete.AllowUserToAddRows = false;
            this.dgAnkete.AllowUserToDeleteRows = false;
            this.dgAnkete.AllowUserToResizeRows = false;
            this.dgAnkete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnkete.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAnkete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnkete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Pitanje,
            this.DatumKreiranja,
            this.DatumZavrsetka,
            this.BrojOdgovora});
            this.dgAnkete.Location = new System.Drawing.Point(12, 76);
            this.dgAnkete.Name = "dgAnkete";
            this.dgAnkete.ReadOnly = true;
            this.dgAnkete.RowHeadersVisible = false;
            this.dgAnkete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnkete.Size = new System.Drawing.Size(612, 359);
            this.dgAnkete.TabIndex = 2;
            this.dgAnkete.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnkete_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "AnketaID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Pitanje
            // 
            this.Pitanje.DataPropertyName = "Pitanje";
            this.Pitanje.HeaderText = "Pitanje ankete";
            this.Pitanje.Name = "Pitanje";
            this.Pitanje.ReadOnly = true;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            // 
            // DatumZavrsetka
            // 
            this.DatumZavrsetka.DataPropertyName = "DatumZavrsetka";
            this.DatumZavrsetka.HeaderText = "Datum završetka";
            this.DatumZavrsetka.Name = "DatumZavrsetka";
            this.DatumZavrsetka.ReadOnly = true;
            // 
            // BrojOdgovora
            // 
            this.BrojOdgovora.DataPropertyName = "BrojOdgovora";
            this.BrojOdgovora.HeaderText = "Broj odgovora";
            this.BrojOdgovora.Name = "BrojOdgovora";
            this.BrojOdgovora.ReadOnly = true;
            // 
            // lblPitanje
            // 
            this.lblPitanje.AutoSize = true;
            this.lblPitanje.Location = new System.Drawing.Point(12, 40);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Size = new System.Drawing.Size(45, 13);
            this.lblPitanje.TabIndex = 3;
            this.lblPitanje.Text = "Pitanje: ";
            // 
            // lblBrojAnketa
            // 
            this.lblBrojAnketa.AutoSize = true;
            this.lblBrojAnketa.Location = new System.Drawing.Point(12, 453);
            this.lblBrojAnketa.Name = "lblBrojAnketa";
            this.lblBrojAnketa.Size = new System.Drawing.Size(67, 13);
            this.lblBrojAnketa.TabIndex = 4;
            this.lblBrojAnketa.Text = "Broj anketa: ";
            // 
            // lblBA
            // 
            this.lblBA.AutoSize = true;
            this.lblBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBA.Location = new System.Drawing.Point(74, 453);
            this.lblBA.Name = "lblBA";
            this.lblBA.Size = new System.Drawing.Size(23, 13);
            this.lblBA.TabIndex = 5;
            this.lblBA.Text = "BA";
            // 
            // txtPitanje
            // 
            this.txtPitanje.Location = new System.Drawing.Point(63, 37);
            this.txtPitanje.Name = "txtPitanje";
            this.txtPitanje.Size = new System.Drawing.Size(274, 20);
            this.txtPitanje.TabIndex = 6;
            this.txtPitanje.TextChanged += new System.EventHandler(this.txtPitanje_TextChanged);
            // 
            // btnVidiRezultate
            // 
            this.btnVidiRezultate.Location = new System.Drawing.Point(513, 453);
            this.btnVidiRezultate.Name = "btnVidiRezultate";
            this.btnVidiRezultate.Size = new System.Drawing.Size(111, 23);
            this.btnVidiRezultate.TabIndex = 7;
            this.btnVidiRezultate.Text = "Vidi rezultate ankete";
            this.btnVidiRezultate.UseVisualStyleBackColor = true;
            this.btnVidiRezultate.Click += new System.EventHandler(this.btnVidiRezultate_Click);
            // 
            // lblAnkete
            // 
            this.lblAnkete.AutoSize = true;
            this.lblAnkete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnkete.Location = new System.Drawing.Point(290, 9);
            this.lblAnkete.Name = "lblAnkete";
            this.lblAnkete.Size = new System.Drawing.Size(58, 17);
            this.lblAnkete.TabIndex = 15;
            this.lblAnkete.Text = "Ankete";
            // 
            // Frm_Ankete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 495);
            this.Controls.Add(this.lblAnkete);
            this.Controls.Add(this.btnVidiRezultate);
            this.Controls.Add(this.txtPitanje);
            this.Controls.Add(this.lblBA);
            this.Controls.Add(this.lblBrojAnketa);
            this.Controls.Add(this.lblPitanje);
            this.Controls.Add(this.dgAnkete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Ankete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ankete";
            this.Load += new System.EventHandler(this.Frm_Ankete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnkete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnkete;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Label lblBrojAnketa;
        private System.Windows.Forms.Label lblBA;
        private System.Windows.Forms.TextBox txtPitanje;
        private System.Windows.Forms.Button btnVidiRezultate;
        private System.Windows.Forms.Label lblAnkete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOdgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}