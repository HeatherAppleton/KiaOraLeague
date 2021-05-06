namespace KiaOra
{
    partial class frmBowlerNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBowlerNote));
            this.dgvBowler = new System.Windows.Forms.DataGridView();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bowlernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bowleridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBowlerNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vBowlerNote = new KiaOra.vBowlerNote();
            this.vBowlerNoteTableAdapter = new KiaOra.vBowlerNoteTableAdapters.vBowlerNoteTableAdapter();
            this.l_Season = new System.Windows.Forms.Label();
            this.l_Rank = new System.Windows.Forms.Label();
            this.l_Note = new System.Windows.Forms.Label();
            this.t_Season = new System.Windows.Forms.TextBox();
            this.t_Rank = new System.Windows.Forms.TextBox();
            this.t_Note = new System.Windows.Forms.TextBox();
            this.l_Bowler = new System.Windows.Forms.Label();
            this.cb_Bowler = new System.Windows.Forms.ComboBox();
            this.hbabowlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vActiveBowler = new KiaOra.vActiveBowler();
            this.hba_bowlerTableAdapter = new KiaOra.vActiveBowlerTableAdapters.hba_bowlerTableAdapter();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Update = new System.Windows.Forms.Button();
            this.b_Insert = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBowler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbabowlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vActiveBowler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBowler
            // 
            this.dgvBowler.AllowUserToAddRows = false;
            this.dgvBowler.AllowUserToDeleteRows = false;
            this.dgvBowler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBowler.AutoGenerateColumns = false;
            this.dgvBowler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBowler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBowler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seasonDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.bowlernameDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.bowleridDataGridViewTextBoxColumn});
            this.dgvBowler.DataSource = this.vBowlerNoteBindingSource;
            this.dgvBowler.Location = new System.Drawing.Point(13, 118);
            this.dgvBowler.Name = "dgvBowler";
            this.dgvBowler.ReadOnly = true;
            this.dgvBowler.Size = new System.Drawing.Size(775, 320);
            this.dgvBowler.TabIndex = 0;
            this.dgvBowler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBowler_CellContentClick);
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "Season";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Width = 68;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 74;
            // 
            // bowlernameDataGridViewTextBoxColumn
            // 
            this.bowlernameDataGridViewTextBoxColumn.DataPropertyName = "bowler_name";
            this.bowlernameDataGridViewTextBoxColumn.HeaderText = "Bowler";
            this.bowlernameDataGridViewTextBoxColumn.Name = "bowlernameDataGridViewTextBoxColumn";
            this.bowlernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bowlernameDataGridViewTextBoxColumn.Width = 64;
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
            // bowleridDataGridViewTextBoxColumn
            // 
            this.bowleridDataGridViewTextBoxColumn.DataPropertyName = "bowler_id";
            this.bowleridDataGridViewTextBoxColumn.HeaderText = "bowler_id";
            this.bowleridDataGridViewTextBoxColumn.Name = "bowleridDataGridViewTextBoxColumn";
            this.bowleridDataGridViewTextBoxColumn.ReadOnly = true;
            this.bowleridDataGridViewTextBoxColumn.Visible = false;
            // 
            // vBowlerNoteBindingSource
            // 
            this.vBowlerNoteBindingSource.DataMember = "vBowlerNote";
            this.vBowlerNoteBindingSource.DataSource = this.vBowlerNote;
            // 
            // vBowlerNote
            // 
            this.vBowlerNote.DataSetName = "vBowlerNote";
            this.vBowlerNote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vBowlerNoteTableAdapter
            // 
            this.vBowlerNoteTableAdapter.ClearBeforeFill = true;
            // 
            // l_Season
            // 
            this.l_Season.AutoSize = true;
            this.l_Season.Location = new System.Drawing.Point(13, 9);
            this.l_Season.Name = "l_Season";
            this.l_Season.Size = new System.Drawing.Size(46, 13);
            this.l_Season.TabIndex = 1;
            this.l_Season.Text = "Season:";
            // 
            // l_Rank
            // 
            this.l_Rank.AutoSize = true;
            this.l_Rank.Location = new System.Drawing.Point(13, 66);
            this.l_Rank.Name = "l_Rank";
            this.l_Rank.Size = new System.Drawing.Size(36, 13);
            this.l_Rank.TabIndex = 2;
            this.l_Rank.Text = "Rank:";
            // 
            // l_Note
            // 
            this.l_Note.AutoSize = true;
            this.l_Note.Location = new System.Drawing.Point(13, 94);
            this.l_Note.Name = "l_Note";
            this.l_Note.Size = new System.Drawing.Size(33, 13);
            this.l_Note.TabIndex = 3;
            this.l_Note.Text = "Note:";
            // 
            // t_Season
            // 
            this.t_Season.Location = new System.Drawing.Point(61, 5);
            this.t_Season.MaxLength = 4;
            this.t_Season.Name = "t_Season";
            this.t_Season.Size = new System.Drawing.Size(56, 20);
            this.t_Season.TabIndex = 1;
            // 
            // t_Rank
            // 
            this.t_Rank.Location = new System.Drawing.Point(61, 62);
            this.t_Rank.MaxLength = 4;
            this.t_Rank.Name = "t_Rank";
            this.t_Rank.Size = new System.Drawing.Size(56, 20);
            this.t_Rank.TabIndex = 3;
            // 
            // t_Note
            // 
            this.t_Note.Location = new System.Drawing.Point(61, 90);
            this.t_Note.Name = "t_Note";
            this.t_Note.Size = new System.Drawing.Size(537, 20);
            this.t_Note.TabIndex = 4;
            // 
            // l_Bowler
            // 
            this.l_Bowler.AutoSize = true;
            this.l_Bowler.Location = new System.Drawing.Point(13, 37);
            this.l_Bowler.Name = "l_Bowler";
            this.l_Bowler.Size = new System.Drawing.Size(42, 13);
            this.l_Bowler.TabIndex = 7;
            this.l_Bowler.Text = "Bowler:";
            // 
            // cb_Bowler
            // 
            this.cb_Bowler.DataSource = this.hbabowlerBindingSource;
            this.cb_Bowler.DisplayMember = "bowler_name";
            this.cb_Bowler.FormattingEnabled = true;
            this.cb_Bowler.Location = new System.Drawing.Point(61, 33);
            this.cb_Bowler.Name = "cb_Bowler";
            this.cb_Bowler.Size = new System.Drawing.Size(219, 21);
            this.cb_Bowler.TabIndex = 2;
            this.cb_Bowler.ValueMember = "id";
            this.cb_Bowler.SelectedIndexChanged += new System.EventHandler(this.cb_Bowler_SelectedIndexChanged);
            // 
            // hbabowlerBindingSource
            // 
            this.hbabowlerBindingSource.DataMember = "hba_bowler";
            this.hbabowlerBindingSource.DataSource = this.vActiveBowler;
            // 
            // vActiveBowler
            // 
            this.vActiveBowler.DataSetName = "vActiveBowler";
            this.vActiveBowler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hba_bowlerTableAdapter
            // 
            this.hba_bowlerTableAdapter.ClearBeforeFill = true;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(713, 89);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 8;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Update
            // 
            this.b_Update.Location = new System.Drawing.Point(713, 61);
            this.b_Update.Name = "b_Update";
            this.b_Update.Size = new System.Drawing.Size(75, 23);
            this.b_Update.TabIndex = 7;
            this.b_Update.Text = "&Update";
            this.b_Update.UseVisualStyleBackColor = true;
            this.b_Update.Click += new System.EventHandler(this.b_Update_Click);
            // 
            // b_Insert
            // 
            this.b_Insert.Location = new System.Drawing.Point(713, 32);
            this.b_Insert.Name = "b_Insert";
            this.b_Insert.Size = new System.Drawing.Size(75, 23);
            this.b_Insert.TabIndex = 6;
            this.b_Insert.Text = "&Add Note";
            this.b_Insert.UseVisualStyleBackColor = true;
            this.b_Insert.Click += new System.EventHandler(this.b_Insert_Click);
            // 
            // b_Clear
            // 
            this.b_Clear.Location = new System.Drawing.Point(713, 4);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(75, 23);
            this.b_Clear.TabIndex = 5;
            this.b_Clear.Text = "C&lear";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(632, 61);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 9;
            this.b_Delete.Text = "&Delete";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // frmBowlerNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_Insert);
            this.Controls.Add(this.b_Update);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.cb_Bowler);
            this.Controls.Add(this.l_Bowler);
            this.Controls.Add(this.t_Note);
            this.Controls.Add(this.t_Rank);
            this.Controls.Add(this.t_Season);
            this.Controls.Add(this.l_Note);
            this.Controls.Add(this.l_Rank);
            this.Controls.Add(this.l_Season);
            this.Controls.Add(this.dgvBowler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBowlerNote";
            this.Text = "EOY Bowler Note Maintenance";
            this.Load += new System.EventHandler(this.frmBowlerNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBowler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbabowlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vActiveBowler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBowler;
        private vBowlerNote vBowlerNote;
        private System.Windows.Forms.BindingSource vBowlerNoteBindingSource;
        private vBowlerNoteTableAdapters.vBowlerNoteTableAdapter vBowlerNoteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bowlernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bowleridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label l_Season;
        private System.Windows.Forms.Label l_Rank;
        private System.Windows.Forms.Label l_Note;
        private System.Windows.Forms.TextBox t_Season;
        private System.Windows.Forms.TextBox t_Rank;
        private System.Windows.Forms.TextBox t_Note;
        private System.Windows.Forms.Label l_Bowler;
        private System.Windows.Forms.ComboBox cb_Bowler;
        private vActiveBowler vActiveBowler;
        private System.Windows.Forms.BindingSource hbabowlerBindingSource;
        private vActiveBowlerTableAdapters.hba_bowlerTableAdapter hba_bowlerTableAdapter;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Update;
        private System.Windows.Forms.Button b_Insert;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b_Delete;
    }
}