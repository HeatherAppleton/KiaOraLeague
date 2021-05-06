namespace KiaOra
{
    partial class frmResultsMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultsMaintenance));
            this.b_Close = new System.Windows.Forms.Button();
            this.dgvDraw = new System.Windows.Forms.DataGridView();
            this.dgvScoresheet = new System.Windows.Forms.DataGridView();
            this.b_update = new System.Windows.Forms.Button();
            this.b_deletePairing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresheet)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Close
            // 
            this.b_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Close.Location = new System.Drawing.Point(1080, 61);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(87, 23);
            this.b_Close.TabIndex = 4;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // dgvDraw
            // 
            this.dgvDraw.AllowUserToAddRows = false;
            this.dgvDraw.AllowUserToDeleteRows = false;
            this.dgvDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDraw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDraw.Enabled = false;
            this.dgvDraw.Location = new System.Drawing.Point(4, 100);
            this.dgvDraw.Name = "dgvDraw";
            this.dgvDraw.ReadOnly = true;
            this.dgvDraw.Size = new System.Drawing.Size(1163, 84);
            this.dgvDraw.TabIndex = 0;
            this.dgvDraw.TabStop = false;
            // 
            // dgvScoresheet
            // 
            this.dgvScoresheet.AllowUserToAddRows = false;
            this.dgvScoresheet.AllowUserToDeleteRows = false;
            this.dgvScoresheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScoresheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoresheet.Location = new System.Drawing.Point(4, 191);
            this.dgvScoresheet.Name = "dgvScoresheet";
            this.dgvScoresheet.Size = new System.Drawing.Size(1163, 198);
            this.dgvScoresheet.TabIndex = 1;
            this.dgvScoresheet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoresheet_CellEndEdit);
            // 
            // b_update
            // 
            this.b_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_update.Location = new System.Drawing.Point(1080, 5);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(87, 23);
            this.b_update.TabIndex = 2;
            this.b_update.Text = "&Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_deletePairing
            // 
            this.b_deletePairing.Location = new System.Drawing.Point(1080, 33);
            this.b_deletePairing.Name = "b_deletePairing";
            this.b_deletePairing.Size = new System.Drawing.Size(87, 23);
            this.b_deletePairing.TabIndex = 3;
            this.b_deletePairing.Text = "&Delete Pairing";
            this.b_deletePairing.UseVisualStyleBackColor = true;
            this.b_deletePairing.Click += new System.EventHandler(this.b_deletePairing_Click);
            // 
            // frmResultsMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 401);
            this.Controls.Add(this.b_deletePairing);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.dgvScoresheet);
            this.Controls.Add(this.dgvDraw);
            this.Controls.Add(this.b_Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResultsMaintenance";
            this.Text = "Results Maintenance";
            this.Load += new System.EventHandler(this.frmResultsMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoresheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.DataGridView dgvDraw;
        private System.Windows.Forms.DataGridView dgvScoresheet;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_deletePairing;
    }
}