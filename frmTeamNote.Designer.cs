namespace KiaOra
{
    partial class frmTeamNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamNote));
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTeamNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTeamNote = new KiaOra.vTeamNote();
            this.vTeamNoteTableAdapter = new KiaOra.vTeamNoteTableAdapters.vTeamNoteTableAdapter();
            this.t_Note = new System.Windows.Forms.TextBox();
            this.t_Rank = new System.Windows.Forms.TextBox();
            this.t_Season = new System.Windows.Forms.TextBox();
            this.l_Note = new System.Windows.Forms.Label();
            this.l_Rank = new System.Windows.Forms.Label();
            this.l_Season = new System.Windows.Forms.Label();
            this.l_Team = new System.Windows.Forms.Label();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.hbateamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vActiveTeam = new KiaOra.vActiveTeam();
            this.hba_teamTableAdapter = new KiaOra.vActiveTeamTableAdapters.hba_teamTableAdapter();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Update = new System.Windows.Forms.Button();
            this.b_Insert = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeamNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeamNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vActiveTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeam
            // 
            this.dgvTeam.AllowUserToAddRows = false;
            this.dgvTeam.AllowUserToDeleteRows = false;
            this.dgvTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTeam.AutoGenerateColumns = false;
            this.dgvTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seasonDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.teamidDataGridViewTextBoxColumn});
            this.dgvTeam.DataSource = this.vTeamNoteBindingSource;
            this.dgvTeam.Location = new System.Drawing.Point(13, 123);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.ReadOnly = true;
            this.dgvTeam.Size = new System.Drawing.Size(775, 315);
            this.dgvTeam.TabIndex = 0;
            this.dgvTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeam_CellContentClick);
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "Season";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Width = 68;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "team_name";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamnameDataGridViewTextBoxColumn.Width = 59;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            this.rankDataGridViewTextBoxColumn.Width = 58;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 55;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamidDataGridViewTextBoxColumn
            // 
            this.teamidDataGridViewTextBoxColumn.DataPropertyName = "team_id";
            this.teamidDataGridViewTextBoxColumn.HeaderText = "team_id";
            this.teamidDataGridViewTextBoxColumn.Name = "teamidDataGridViewTextBoxColumn";
            this.teamidDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamidDataGridViewTextBoxColumn.Visible = false;
            // 
            // vTeamNoteBindingSource
            // 
            this.vTeamNoteBindingSource.DataMember = "vTeamNote";
            this.vTeamNoteBindingSource.DataSource = this.vTeamNote;
            // 
            // vTeamNote
            // 
            this.vTeamNote.DataSetName = "vTeamNote";
            this.vTeamNote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vTeamNoteTableAdapter
            // 
            this.vTeamNoteTableAdapter.ClearBeforeFill = true;
            // 
            // t_Note
            // 
            this.t_Note.Location = new System.Drawing.Point(63, 89);
            this.t_Note.Name = "t_Note";
            this.t_Note.Size = new System.Drawing.Size(537, 20);
            this.t_Note.TabIndex = 4;
            // 
            // t_Rank
            // 
            this.t_Rank.Location = new System.Drawing.Point(63, 61);
            this.t_Rank.MaxLength = 4;
            this.t_Rank.Name = "t_Rank";
            this.t_Rank.Size = new System.Drawing.Size(56, 20);
            this.t_Rank.TabIndex = 3;
            // 
            // t_Season
            // 
            this.t_Season.Location = new System.Drawing.Point(63, 4);
            this.t_Season.MaxLength = 4;
            this.t_Season.Name = "t_Season";
            this.t_Season.Size = new System.Drawing.Size(56, 20);
            this.t_Season.TabIndex = 1;
            // 
            // l_Note
            // 
            this.l_Note.AutoSize = true;
            this.l_Note.Location = new System.Drawing.Point(13, 93);
            this.l_Note.Name = "l_Note";
            this.l_Note.Size = new System.Drawing.Size(33, 13);
            this.l_Note.TabIndex = 9;
            this.l_Note.Text = "Note:";
            // 
            // l_Rank
            // 
            this.l_Rank.AutoSize = true;
            this.l_Rank.Location = new System.Drawing.Point(13, 65);
            this.l_Rank.Name = "l_Rank";
            this.l_Rank.Size = new System.Drawing.Size(36, 13);
            this.l_Rank.TabIndex = 8;
            this.l_Rank.Text = "Rank:";
            // 
            // l_Season
            // 
            this.l_Season.AutoSize = true;
            this.l_Season.Location = new System.Drawing.Point(13, 8);
            this.l_Season.Name = "l_Season";
            this.l_Season.Size = new System.Drawing.Size(46, 13);
            this.l_Season.TabIndex = 7;
            this.l_Season.Text = "Season:";
            // 
            // l_Team
            // 
            this.l_Team.AutoSize = true;
            this.l_Team.Location = new System.Drawing.Point(13, 36);
            this.l_Team.Name = "l_Team";
            this.l_Team.Size = new System.Drawing.Size(37, 13);
            this.l_Team.TabIndex = 13;
            this.l_Team.Text = "Team:";
            // 
            // cb_Team
            // 
            this.cb_Team.DataSource = this.hbateamBindingSource;
            this.cb_Team.DisplayMember = "team_name";
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Location = new System.Drawing.Point(63, 32);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(236, 21);
            this.cb_Team.TabIndex = 2;
            this.cb_Team.ValueMember = "id";
            this.cb_Team.SelectedIndexChanged += new System.EventHandler(this.cb_Team_SelectedIndexChanged);
            // 
            // hbateamBindingSource
            // 
            this.hbateamBindingSource.DataMember = "hba_team";
            this.hbateamBindingSource.DataSource = this.vActiveTeam;
            // 
            // vActiveTeam
            // 
            this.vActiveTeam.DataSetName = "vActiveTeam";
            this.vActiveTeam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hba_teamTableAdapter
            // 
            this.hba_teamTableAdapter.ClearBeforeFill = true;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(713, 89);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 9;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Update
            // 
            this.b_Update.Location = new System.Drawing.Point(713, 61);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(75, 23);
            this.b_Update.TabIndex = 8;
            this.b_Update.Text = "&Update";
            this.b_Update.UseVisualStyleBackColor = true;
            this.b_Update.Click += new System.EventHandler(this.b_Update_Click);
            // 
            // b_Insert
            // 
            this.b_Insert.Location = new System.Drawing.Point(713, 31);
            this.b_Insert.Name = "b_Insert";
            this.b_Insert.Size = new System.Drawing.Size(75, 23);
            this.b_Insert.TabIndex = 7;
            this.b_Insert.Text = "&Add Note";
            this.b_Insert.UseVisualStyleBackColor = true;
            this.b_Insert.Click += new System.EventHandler(this.b_Insert_Click);
            // 
            // b_Clear
            // 
            this.b_Clear.Location = new System.Drawing.Point(713, 3);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(75, 23);
            this.b_Clear.TabIndex = 6;
            this.b_Clear.Text = "C&lear";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(631, 61);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 10;
            this.b_Delete.Text = "&Delete";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // frmTeamNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_Insert);
            this.Controls.Add(this.b_Update);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.l_Team);
            this.Controls.Add(this.t_Note);
            this.Controls.Add(this.t_Rank);
            this.Controls.Add(this.t_Season);
            this.Controls.Add(this.l_Note);
            this.Controls.Add(this.l_Rank);
            this.Controls.Add(this.l_Season);
            this.Controls.Add(this.dgvTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeamNote";
            this.Text = "EOY Team Note Maintenance";
            this.Load += new System.EventHandler(this.frmTeamNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeamNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeamNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vActiveTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeam;
        private vTeamNote vTeamNote;
        private System.Windows.Forms.BindingSource vTeamNoteBindingSource;
        private vTeamNoteTableAdapters.vTeamNoteTableAdapter vTeamNoteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox t_Note;
        private System.Windows.Forms.TextBox t_Rank;
        private System.Windows.Forms.TextBox t_Season;
        private System.Windows.Forms.Label l_Note;
        private System.Windows.Forms.Label l_Rank;
        private System.Windows.Forms.Label l_Season;
        private System.Windows.Forms.Label l_Team;
        private System.Windows.Forms.ComboBox cb_Team;
        private vActiveTeam vActiveTeam;
        private System.Windows.Forms.BindingSource hbateamBindingSource;
        private vActiveTeamTableAdapters.hba_teamTableAdapter hba_teamTableAdapter;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Update;
        private System.Windows.Forms.Button b_Insert;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b_Delete;
    }
}