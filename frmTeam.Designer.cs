namespace KiaOra
{
    partial class frmTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeam));
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundwinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDataSet = new KiaOra.teamDataSet();
            this.t_teamName = new System.Windows.Forms.TextBox();
            this.l_teamName = new System.Windows.Forms.Label();
            this.b_insert = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_ClearWinners = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeam
            // 
            this.dgvTeam.AllowUserToAddRows = false;
            this.dgvTeam.AllowUserToDeleteRows = false;
            this.dgvTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTeam.AutoGenerateColumns = false;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn,
            this.roundwinnerDataGridViewTextBoxColumn,
            this.activeflagDataGridViewTextBoxColumn});
            this.dgvTeam.DataMember = "hba_team";
            this.dgvTeam.DataSource = this.teamDataSetBindingSource;
            this.dgvTeam.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTeam.Location = new System.Drawing.Point(11, 80);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.Size = new System.Drawing.Size(507, 593);
            this.dgvTeam.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "team_name";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "Team Name";
            this.teamnameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.teamnameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // roundwinnerDataGridViewTextBoxColumn
            // 
            this.roundwinnerDataGridViewTextBoxColumn.DataPropertyName = "round_winner";
            this.roundwinnerDataGridViewTextBoxColumn.HeaderText = "Round Winner";
            this.roundwinnerDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.roundwinnerDataGridViewTextBoxColumn.Name = "roundwinnerDataGridViewTextBoxColumn";
            // 
            // activeflagDataGridViewTextBoxColumn
            // 
            this.activeflagDataGridViewTextBoxColumn.DataPropertyName = "active_flag";
            this.activeflagDataGridViewTextBoxColumn.HeaderText = "Active";
            this.activeflagDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.activeflagDataGridViewTextBoxColumn.Name = "activeflagDataGridViewTextBoxColumn";
            // 
            // teamDataSetBindingSource
            // 
            this.teamDataSetBindingSource.DataSource = this.teamDataSet;
            this.teamDataSetBindingSource.Position = 0;
            // 
            // teamDataSet
            // 
            this.teamDataSet.DataSetName = "teamDataSet";
            this.teamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_teamName
            // 
            this.t_teamName.Location = new System.Drawing.Point(83, 13);
            this.t_teamName.MaxLength = 30;
            this.t_teamName.Name = "t_teamName";
            this.t_teamName.Size = new System.Drawing.Size(215, 20);
            this.t_teamName.TabIndex = 1;
            // 
            // l_teamName
            // 
            this.l_teamName.AutoSize = true;
            this.l_teamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_teamName.Location = new System.Drawing.Point(11, 17);
            this.l_teamName.Name = "l_teamName";
            this.l_teamName.Size = new System.Drawing.Size(68, 13);
            this.l_teamName.TabIndex = 2;
            this.l_teamName.Text = "Team Name:";
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(338, 13);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(85, 23);
            this.b_insert.TabIndex = 3;
            this.b_insert.Text = "&Add Team";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(338, 43);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(85, 23);
            this.b_update.TabIndex = 4;
            this.b_update.Text = "&Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_ClearWinners
            // 
            this.b_ClearWinners.Location = new System.Drawing.Point(433, 13);
            this.b_ClearWinners.Name = "b_ClearWinners";
            this.b_ClearWinners.Size = new System.Drawing.Size(85, 23);
            this.b_ClearWinners.TabIndex = 5;
            this.b_ClearWinners.Text = "&Reset Winners";
            this.b_ClearWinners.UseVisualStyleBackColor = true;
            this.b_ClearWinners.Click += new System.EventHandler(this.b_ClearWinners_Click);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(433, 43);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(85, 23);
            this.b_Close.TabIndex = 6;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // frmTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(529, 685);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_ClearWinners);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.l_teamName);
            this.Controls.Add(this.t_teamName);
            this.Controls.Add(this.dgvTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeam";
            this.Text = "Team Maintenance";
            this.Load += new System.EventHandler(this.frmTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.BindingSource teamDataSetBindingSource;
        private teamDataSet teamDataSet;
        private System.Windows.Forms.TextBox t_teamName;
        private System.Windows.Forms.Label l_teamName;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundwinnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button b_ClearWinners;
        private System.Windows.Forms.Button b_Close;
    }
}

