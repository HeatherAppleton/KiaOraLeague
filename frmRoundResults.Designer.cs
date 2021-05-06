namespace KiaOra
{
    partial class frmRoundResults
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoundResults));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.roundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinfallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hbavRoundResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRoundResult = new KiaOra.vRoundResult();
            this.hba_v_RoundResultsTableAdapter = new KiaOra.vRoundResultTableAdapters.hba_v_RoundResultsTableAdapter();
            this.b_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbavRoundResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRoundResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roundDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn,
            this.pinfallDataGridViewTextBoxColumn});
            this.dgvResults.DataSource = this.hbavRoundResultsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResults.Location = new System.Drawing.Point(13, 41);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(477, 491);
            this.dgvResults.TabIndex = 0;
            // 
            // roundDataGridViewTextBoxColumn
            // 
            this.roundDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.roundDataGridViewTextBoxColumn.DataPropertyName = "Round";
            this.roundDataGridViewTextBoxColumn.HeaderText = "Round";
            this.roundDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.roundDataGridViewTextBoxColumn.Name = "roundDataGridViewTextBoxColumn";
            this.roundDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundDataGridViewTextBoxColumn.Width = 64;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Width = 59;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointsDataGridViewTextBoxColumn.Width = 61;
            // 
            // pinfallDataGridViewTextBoxColumn
            // 
            this.pinfallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pinfallDataGridViewTextBoxColumn.DataPropertyName = "Pinfall";
            this.pinfallDataGridViewTextBoxColumn.HeaderText = "Pinfall";
            this.pinfallDataGridViewTextBoxColumn.Name = "pinfallDataGridViewTextBoxColumn";
            this.pinfallDataGridViewTextBoxColumn.ReadOnly = true;
            this.pinfallDataGridViewTextBoxColumn.Width = 60;
            // 
            // hbavRoundResultsBindingSource
            // 
            this.hbavRoundResultsBindingSource.DataMember = "hba_v_RoundResults";
            this.hbavRoundResultsBindingSource.DataSource = this.vRoundResult;
            // 
            // vRoundResult
            // 
            this.vRoundResult.DataSetName = "vRoundResult";
            this.vRoundResult.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hba_v_RoundResultsTableAdapter
            // 
            this.hba_v_RoundResultsTableAdapter.ClearBeforeFill = true;
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(414, 13);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 23);
            this.b_close.TabIndex = 1;
            this.b_close.Text = "&Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // frmRoundResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 538);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.dgvResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoundResults";
            this.Text = "Round Results";
            this.Load += new System.EventHandler(this.frmRoundResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbavRoundResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRoundResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private vRoundResult vRoundResult;
        private System.Windows.Forms.BindingSource hbavRoundResultsBindingSource;
        private vRoundResultTableAdapters.hba_v_RoundResultsTableAdapter hba_v_RoundResultsTableAdapter;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinfallDataGridViewTextBoxColumn;
    }
}