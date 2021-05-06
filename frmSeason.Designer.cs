namespace KiaOra
{
    partial class frmSeason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeason));
            this.l_Season = new System.Windows.Forms.Label();
            this.t_Season = new System.Windows.Forms.TextBox();
            this.dgvSeason = new System.Windows.Forms.DataGridView();
            this.week_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeknumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hbavweekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWeekDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWeekDataSet = new KiaOra.vWeekDataSet();
            this.hba_v_weekTableAdapter = new KiaOra.vWeekDataSetTableAdapters.hba_v_weekTableAdapter();
            this.b_NewSeason = new System.Windows.Forms.Button();
            this.b_View = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.gb_settings = new System.Windows.Forms.GroupBox();
            this.t_totalWeeks = new System.Windows.Forms.TextBox();
            this.l_totalWeeks = new System.Windows.Forms.Label();
            this.t_finalsSize = new System.Windows.Forms.TextBox();
            this.l_finalsSize = new System.Windows.Forms.Label();
            this.t_rounds = new System.Windows.Forms.TextBox();
            this.l_rounds = new System.Windows.Forms.Label();
            this.cb_applyBonus = new System.Windows.Forms.CheckBox();
            this.t_roundSize = new System.Windows.Forms.TextBox();
            this.l_roundSize = new System.Windows.Forms.Label();
            this.t_leagueSize = new System.Windows.Forms.TextBox();
            this.l_leagueSize = new System.Windows.Forms.Label();
            this.t_teamSize = new System.Windows.Forms.TextBox();
            this.l_teamsize = new System.Windows.Forms.Label();
            this.b_updateSettings = new System.Windows.Forms.Button();
            this.t_maxHandicap = new System.Windows.Forms.TextBox();
            this.l_handicap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbavweekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeekDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeekDataSet)).BeginInit();
            this.gb_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_Season
            // 
            this.l_Season.AutoSize = true;
            this.l_Season.Location = new System.Drawing.Point(12, 22);
            this.l_Season.Name = "l_Season";
            this.l_Season.Size = new System.Drawing.Size(46, 13);
            this.l_Season.TabIndex = 0;
            this.l_Season.Text = "Season:";
            // 
            // t_Season
            // 
            this.t_Season.Location = new System.Drawing.Point(61, 18);
            this.t_Season.MaxLength = 4;
            this.t_Season.Name = "t_Season";
            this.t_Season.Size = new System.Drawing.Size(46, 20);
            this.t_Season.TabIndex = 5;
            // 
            // dgvSeason
            // 
            this.dgvSeason.AllowUserToAddRows = false;
            this.dgvSeason.AllowUserToDeleteRows = false;
            this.dgvSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSeason.AutoGenerateColumns = false;
            this.dgvSeason.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeason.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.week_date,
            this.seasonDataGridViewTextBoxColumn,
            this.weeknumberDataGridViewTextBoxColumn,
            this.roundDataGridViewTextBoxColumn,
            this.roundweekDataGridViewTextBoxColumn,
            this.id});
            this.dgvSeason.DataSource = this.hbavweekBindingSource;
            this.dgvSeason.Location = new System.Drawing.Point(295, 73);
            this.dgvSeason.Name = "dgvSeason";
            this.dgvSeason.ReadOnly = true;
            this.dgvSeason.Size = new System.Drawing.Size(470, 640);
            this.dgvSeason.TabIndex = 1;
            // 
            // week_date
            // 
            this.week_date.DataPropertyName = "week_date";
            this.week_date.HeaderText = "Date";
            this.week_date.Name = "week_date";
            this.week_date.ReadOnly = true;
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "season";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // weeknumberDataGridViewTextBoxColumn
            // 
            this.weeknumberDataGridViewTextBoxColumn.DataPropertyName = "week_number";
            this.weeknumberDataGridViewTextBoxColumn.HeaderText = "Week Number";
            this.weeknumberDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.weeknumberDataGridViewTextBoxColumn.Name = "weeknumberDataGridViewTextBoxColumn";
            this.weeknumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roundDataGridViewTextBoxColumn
            // 
            this.roundDataGridViewTextBoxColumn.DataPropertyName = "round";
            this.roundDataGridViewTextBoxColumn.HeaderText = "Round";
            this.roundDataGridViewTextBoxColumn.Name = "roundDataGridViewTextBoxColumn";
            this.roundDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roundweekDataGridViewTextBoxColumn
            // 
            this.roundweekDataGridViewTextBoxColumn.DataPropertyName = "round_week";
            this.roundweekDataGridViewTextBoxColumn.HeaderText = "Round Week";
            this.roundweekDataGridViewTextBoxColumn.Name = "roundweekDataGridViewTextBoxColumn";
            this.roundweekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // hbavweekBindingSource
            // 
            this.hbavweekBindingSource.DataMember = "hba_v_week";
            this.hbavweekBindingSource.DataSource = this.vWeekDataSetBindingSource;
            // 
            // vWeekDataSetBindingSource
            // 
            this.vWeekDataSetBindingSource.DataSource = this.vWeekDataSet;
            this.vWeekDataSetBindingSource.Position = 0;
            // 
            // vWeekDataSet
            // 
            this.vWeekDataSet.DataSetName = "vWeekDataSet";
            this.vWeekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hba_v_weekTableAdapter
            // 
            this.hba_v_weekTableAdapter.ClearBeforeFill = true;
            // 
            // b_NewSeason
            // 
            this.b_NewSeason.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.b_NewSeason.Location = new System.Drawing.Point(115, 16);
            this.b_NewSeason.Name = "b_NewSeason";
            this.b_NewSeason.Size = new System.Drawing.Size(123, 25);
            this.b_NewSeason.TabIndex = 14;
            this.b_NewSeason.Text = "&Setup Season";
            this.b_NewSeason.UseVisualStyleBackColor = false;
            this.b_NewSeason.Click += new System.EventHandler(this.b_NewSeason_Click);
            // 
            // b_View
            // 
            this.b_View.Location = new System.Drawing.Point(690, 13);
            this.b_View.Name = "b_View";
            this.b_View.Size = new System.Drawing.Size(75, 25);
            this.b_View.TabIndex = 2;
            this.b_View.Text = "&View";
            this.b_View.UseVisualStyleBackColor = true;
            this.b_View.Click += new System.EventHandler(this.b_View_Click);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(690, 39);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 3;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.LightSalmon;
            this.b_delete.Location = new System.Drawing.Point(590, 39);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(88, 23);
            this.b_delete.TabIndex = 4;
            this.b_delete.Text = "&Delete Week";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // gb_settings
            // 
            this.gb_settings.Controls.Add(this.t_totalWeeks);
            this.gb_settings.Controls.Add(this.l_totalWeeks);
            this.gb_settings.Controls.Add(this.t_finalsSize);
            this.gb_settings.Controls.Add(this.l_finalsSize);
            this.gb_settings.Controls.Add(this.t_rounds);
            this.gb_settings.Controls.Add(this.l_rounds);
            this.gb_settings.Controls.Add(this.cb_applyBonus);
            this.gb_settings.Controls.Add(this.t_roundSize);
            this.gb_settings.Controls.Add(this.l_roundSize);
            this.gb_settings.Controls.Add(this.t_leagueSize);
            this.gb_settings.Controls.Add(this.l_leagueSize);
            this.gb_settings.Controls.Add(this.t_teamSize);
            this.gb_settings.Controls.Add(this.l_teamsize);
            this.gb_settings.Controls.Add(this.b_updateSettings);
            this.gb_settings.Controls.Add(this.t_maxHandicap);
            this.gb_settings.Controls.Add(this.l_handicap);
            this.gb_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_settings.Location = new System.Drawing.Point(15, 73);
            this.gb_settings.Name = "gb_settings";
            this.gb_settings.Size = new System.Drawing.Size(223, 323);
            this.gb_settings.TabIndex = 22;
            this.gb_settings.TabStop = false;
            this.gb_settings.Text = "Settings";
            // 
            // t_totalWeeks
            // 
            this.t_totalWeeks.BackColor = System.Drawing.SystemColors.Control;
            this.t_totalWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_totalWeeks.Location = new System.Drawing.Point(106, 232);
            this.t_totalWeeks.Name = "t_totalWeeks";
            this.t_totalWeeks.Size = new System.Drawing.Size(46, 20);
            this.t_totalWeeks.TabIndex = 0;
            this.t_totalWeeks.TabStop = false;
            // 
            // l_totalWeeks
            // 
            this.l_totalWeeks.AutoSize = true;
            this.l_totalWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_totalWeeks.Location = new System.Drawing.Point(20, 236);
            this.l_totalWeeks.Name = "l_totalWeeks";
            this.l_totalWeeks.Size = new System.Drawing.Size(83, 13);
            this.l_totalWeeks.TabIndex = 0;
            this.l_totalWeeks.Text = "Total Weeks:";
            // 
            // t_finalsSize
            // 
            this.t_finalsSize.Location = new System.Drawing.Point(106, 163);
            this.t_finalsSize.Name = "t_finalsSize";
            this.t_finalsSize.Size = new System.Drawing.Size(46, 20);
            this.t_finalsSize.TabIndex = 11;
            this.t_finalsSize.TextChanged += new System.EventHandler(this.t_finalsSize_TextChanged);
            // 
            // l_finalsSize
            // 
            this.l_finalsSize.AutoSize = true;
            this.l_finalsSize.Location = new System.Drawing.Point(23, 167);
            this.l_finalsSize.Name = "l_finalsSize";
            this.l_finalsSize.Size = new System.Drawing.Size(60, 13);
            this.l_finalsSize.TabIndex = 22;
            this.l_finalsSize.Text = "Finals Size:";
            // 
            // t_rounds
            // 
            this.t_rounds.Location = new System.Drawing.Point(106, 107);
            this.t_rounds.Name = "t_rounds";
            this.t_rounds.Size = new System.Drawing.Size(46, 20);
            this.t_rounds.TabIndex = 9;
            this.t_rounds.TextChanged += new System.EventHandler(this.t_rounds_TextChanged);
            // 
            // l_rounds
            // 
            this.l_rounds.AutoSize = true;
            this.l_rounds.Location = new System.Drawing.Point(23, 111);
            this.l_rounds.Name = "l_rounds";
            this.l_rounds.Size = new System.Drawing.Size(47, 13);
            this.l_rounds.TabIndex = 23;
            this.l_rounds.Text = "Rounds:";
            // 
            // cb_applyBonus
            // 
            this.cb_applyBonus.AutoSize = true;
            this.cb_applyBonus.Location = new System.Drawing.Point(23, 194);
            this.cb_applyBonus.Name = "cb_applyBonus";
            this.cb_applyBonus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_applyBonus.Size = new System.Drawing.Size(99, 17);
            this.cb_applyBonus.TabIndex = 12;
            this.cb_applyBonus.Text = "Apply Bonuses ";
            this.cb_applyBonus.UseVisualStyleBackColor = true;
            // 
            // t_roundSize
            // 
            this.t_roundSize.Location = new System.Drawing.Point(106, 135);
            this.t_roundSize.Name = "t_roundSize";
            this.t_roundSize.Size = new System.Drawing.Size(46, 20);
            this.t_roundSize.TabIndex = 10;
            this.t_roundSize.TextChanged += new System.EventHandler(this.t_roundSize_TextChanged);
            // 
            // l_roundSize
            // 
            this.l_roundSize.AutoSize = true;
            this.l_roundSize.Location = new System.Drawing.Point(23, 139);
            this.l_roundSize.Name = "l_roundSize";
            this.l_roundSize.Size = new System.Drawing.Size(65, 13);
            this.l_roundSize.TabIndex = 24;
            this.l_roundSize.Text = "Round Size:";
            // 
            // t_leagueSize
            // 
            this.t_leagueSize.Location = new System.Drawing.Point(106, 51);
            this.t_leagueSize.Name = "t_leagueSize";
            this.t_leagueSize.Size = new System.Drawing.Size(46, 20);
            this.t_leagueSize.TabIndex = 7;
            this.t_leagueSize.TextChanged += new System.EventHandler(this.t_leagueSize_TextChanged);
            // 
            // l_leagueSize
            // 
            this.l_leagueSize.AutoSize = true;
            this.l_leagueSize.Location = new System.Drawing.Point(23, 56);
            this.l_leagueSize.Name = "l_leagueSize";
            this.l_leagueSize.Size = new System.Drawing.Size(69, 13);
            this.l_leagueSize.TabIndex = 25;
            this.l_leagueSize.Text = "League Size:";
            // 
            // t_teamSize
            // 
            this.t_teamSize.Location = new System.Drawing.Point(106, 79);
            this.t_teamSize.Name = "t_teamSize";
            this.t_teamSize.Size = new System.Drawing.Size(46, 20);
            this.t_teamSize.TabIndex = 8;
            // 
            // l_teamsize
            // 
            this.l_teamsize.AutoSize = true;
            this.l_teamsize.Location = new System.Drawing.Point(23, 83);
            this.l_teamsize.Name = "l_teamsize";
            this.l_teamsize.Size = new System.Drawing.Size(60, 13);
            this.l_teamsize.TabIndex = 26;
            this.l_teamsize.Text = "Team Size:";
            // 
            // b_updateSettings
            // 
            this.b_updateSettings.Location = new System.Drawing.Point(29, 279);
            this.b_updateSettings.Name = "b_updateSettings";
            this.b_updateSettings.Size = new System.Drawing.Size(123, 23);
            this.b_updateSettings.TabIndex = 13;
            this.b_updateSettings.Text = "&Update Settings";
            this.b_updateSettings.UseVisualStyleBackColor = true;
            this.b_updateSettings.Click += new System.EventHandler(this.b_updateSettings_Click);
            // 
            // t_maxHandicap
            // 
            this.t_maxHandicap.Location = new System.Drawing.Point(106, 23);
            this.t_maxHandicap.Name = "t_maxHandicap";
            this.t_maxHandicap.Size = new System.Drawing.Size(46, 20);
            this.t_maxHandicap.TabIndex = 6;
            // 
            // l_handicap
            // 
            this.l_handicap.AutoSize = true;
            this.l_handicap.Location = new System.Drawing.Point(23, 27);
            this.l_handicap.Name = "l_handicap";
            this.l_handicap.Size = new System.Drawing.Size(79, 13);
            this.l_handicap.TabIndex = 27;
            this.l_handicap.Text = "Max Handicap:";
            // 
            // frmSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 725);
            this.Controls.Add(this.gb_settings);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_View);
            this.Controls.Add(this.b_NewSeason);
            this.Controls.Add(this.dgvSeason);
            this.Controls.Add(this.t_Season);
            this.Controls.Add(this.l_Season);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeason";
            this.Text = "Season Maintenance";
            this.Load += new System.EventHandler(this.frmSeason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbavweekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeekDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeekDataSet)).EndInit();
            this.gb_settings.ResumeLayout(false);
            this.gb_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Season;
        private System.Windows.Forms.TextBox t_Season;
        private System.Windows.Forms.DataGridView dgvSeason;
        private System.Windows.Forms.BindingSource vWeekDataSetBindingSource;
        private vWeekDataSet vWeekDataSet;
        private System.Windows.Forms.BindingSource hbavweekBindingSource;
        private vWeekDataSetTableAdapters.hba_v_weekTableAdapter hba_v_weekTableAdapter;
        private System.Windows.Forms.Button b_NewSeason;
        private System.Windows.Forms.Button b_View;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn week_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.GroupBox gb_settings;
        private System.Windows.Forms.TextBox t_finalsSize;
        private System.Windows.Forms.Label l_finalsSize;
        private System.Windows.Forms.TextBox t_rounds;
        private System.Windows.Forms.Label l_rounds;
        private System.Windows.Forms.CheckBox cb_applyBonus;
        private System.Windows.Forms.TextBox t_roundSize;
        private System.Windows.Forms.Label l_roundSize;
        private System.Windows.Forms.TextBox t_leagueSize;
        private System.Windows.Forms.Label l_leagueSize;
        private System.Windows.Forms.TextBox t_teamSize;
        private System.Windows.Forms.Label l_teamsize;
        private System.Windows.Forms.Button b_updateSettings;
        private System.Windows.Forms.TextBox t_maxHandicap;
        private System.Windows.Forms.Label l_handicap;
        private System.Windows.Forms.TextBox t_totalWeeks;
        private System.Windows.Forms.Label l_totalWeeks;
    }
}