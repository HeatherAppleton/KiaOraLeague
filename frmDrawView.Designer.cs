namespace KiaOra
{
    partial class frmDrawView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawView));
            this.dgvDraw = new System.Windows.Forms.DataGridView();
            this.draw_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pairingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundwinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculated_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legallineupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDrawDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDrawDataSet = new KiaOra.vDrawDataSet();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Details = new System.Windows.Forms.Button();
            this.hba_v_drawTableAdapter = new KiaOra.vDrawDataSetTableAdapters.hba_v_drawTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDrawDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDrawDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDraw
            // 
            this.dgvDraw.AllowUserToAddRows = false;
            this.dgvDraw.AllowUserToDeleteRows = false;
            this.dgvDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDraw.AutoGenerateColumns = false;
            this.dgvDraw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.draw_id,
            this.seasonDataGridViewTextBoxColumn,
            this.roundDataGridViewTextBoxColumn,
            this.roundweekDataGridViewTextBoxColumn,
            this.weekdateDataGridViewTextBoxColumn,
            this.pairingDataGridViewTextBoxColumn,
            this.laneDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn,
            this.roundwinnerDataGridViewTextBoxColumn,
            this.game1DataGridViewTextBoxColumn,
            this.game2DataGridViewTextBoxColumn,
            this.game3DataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn,
            this.calculated_total,
            this.legallineupDataGridViewTextBoxColumn,
            this.weekidDataGridViewTextBoxColumn,
            this.teamidDataGridViewTextBoxColumn});
            this.dgvDraw.DataMember = "hba_v_draw";
            this.dgvDraw.DataSource = this.vDrawDataSetBindingSource;
            this.dgvDraw.Location = new System.Drawing.Point(12, 64);
            this.dgvDraw.Name = "dgvDraw";
            this.dgvDraw.ReadOnly = true;
            this.dgvDraw.Size = new System.Drawing.Size(1086, 374);
            this.dgvDraw.TabIndex = 0;
            this.dgvDraw.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDraw_CellContentDoubleClick);
            // 
            // draw_id
            // 
            this.draw_id.DataPropertyName = "draw_id";
            this.draw_id.HeaderText = "draw_id";
            this.draw_id.Name = "draw_id";
            this.draw_id.ReadOnly = true;
            this.draw_id.Width = 69;
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "season";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Width = 66;
            // 
            // roundDataGridViewTextBoxColumn
            // 
            this.roundDataGridViewTextBoxColumn.DataPropertyName = "round";
            this.roundDataGridViewTextBoxColumn.HeaderText = "round";
            this.roundDataGridViewTextBoxColumn.Name = "roundDataGridViewTextBoxColumn";
            this.roundDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundDataGridViewTextBoxColumn.Width = 59;
            // 
            // roundweekDataGridViewTextBoxColumn
            // 
            this.roundweekDataGridViewTextBoxColumn.DataPropertyName = "round_week";
            this.roundweekDataGridViewTextBoxColumn.HeaderText = "round_week";
            this.roundweekDataGridViewTextBoxColumn.Name = "roundweekDataGridViewTextBoxColumn";
            this.roundweekDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundweekDataGridViewTextBoxColumn.Width = 91;
            // 
            // weekdateDataGridViewTextBoxColumn
            // 
            this.weekdateDataGridViewTextBoxColumn.DataPropertyName = "week_date";
            this.weekdateDataGridViewTextBoxColumn.HeaderText = "week_date";
            this.weekdateDataGridViewTextBoxColumn.Name = "weekdateDataGridViewTextBoxColumn";
            this.weekdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.weekdateDataGridViewTextBoxColumn.Width = 85;
            // 
            // pairingDataGridViewTextBoxColumn
            // 
            this.pairingDataGridViewTextBoxColumn.DataPropertyName = "pairing";
            this.pairingDataGridViewTextBoxColumn.HeaderText = "pairing";
            this.pairingDataGridViewTextBoxColumn.Name = "pairingDataGridViewTextBoxColumn";
            this.pairingDataGridViewTextBoxColumn.ReadOnly = true;
            this.pairingDataGridViewTextBoxColumn.Width = 63;
            // 
            // laneDataGridViewTextBoxColumn
            // 
            this.laneDataGridViewTextBoxColumn.DataPropertyName = "lane";
            this.laneDataGridViewTextBoxColumn.HeaderText = "lane";
            this.laneDataGridViewTextBoxColumn.Name = "laneDataGridViewTextBoxColumn";
            this.laneDataGridViewTextBoxColumn.ReadOnly = true;
            this.laneDataGridViewTextBoxColumn.Width = 52;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "team_name";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "team_name";
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamnameDataGridViewTextBoxColumn.Width = 87;
            // 
            // roundwinnerDataGridViewTextBoxColumn
            // 
            this.roundwinnerDataGridViewTextBoxColumn.DataPropertyName = "round_winner";
            this.roundwinnerDataGridViewTextBoxColumn.HeaderText = "round_winner";
            this.roundwinnerDataGridViewTextBoxColumn.Name = "roundwinnerDataGridViewTextBoxColumn";
            this.roundwinnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundwinnerDataGridViewTextBoxColumn.Visible = false;
            this.roundwinnerDataGridViewTextBoxColumn.Width = 96;
            // 
            // game1DataGridViewTextBoxColumn
            // 
            this.game1DataGridViewTextBoxColumn.DataPropertyName = "game_1";
            this.game1DataGridViewTextBoxColumn.HeaderText = "game_1";
            this.game1DataGridViewTextBoxColumn.Name = "game1DataGridViewTextBoxColumn";
            this.game1DataGridViewTextBoxColumn.ReadOnly = true;
            this.game1DataGridViewTextBoxColumn.Width = 70;
            // 
            // game2DataGridViewTextBoxColumn
            // 
            this.game2DataGridViewTextBoxColumn.DataPropertyName = "game_2";
            this.game2DataGridViewTextBoxColumn.HeaderText = "game_2";
            this.game2DataGridViewTextBoxColumn.Name = "game2DataGridViewTextBoxColumn";
            this.game2DataGridViewTextBoxColumn.ReadOnly = true;
            this.game2DataGridViewTextBoxColumn.Width = 70;
            // 
            // game3DataGridViewTextBoxColumn
            // 
            this.game3DataGridViewTextBoxColumn.DataPropertyName = "game_3";
            this.game3DataGridViewTextBoxColumn.HeaderText = "game_3";
            this.game3DataGridViewTextBoxColumn.Name = "game3DataGridViewTextBoxColumn";
            this.game3DataGridViewTextBoxColumn.ReadOnly = true;
            this.game3DataGridViewTextBoxColumn.Width = 70;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.seriesDataGridViewTextBoxColumn.Width = 59;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "bonus";
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDataGridViewTextBoxColumn.Width = 61;
            // 
            // calculated_total
            // 
            this.calculated_total.DataPropertyName = "calculated_total";
            this.calculated_total.HeaderText = "total";
            this.calculated_total.Name = "calculated_total";
            this.calculated_total.ReadOnly = true;
            this.calculated_total.Width = 52;
            // 
            // legallineupDataGridViewTextBoxColumn
            // 
            this.legallineupDataGridViewTextBoxColumn.DataPropertyName = "legal_lineup";
            this.legallineupDataGridViewTextBoxColumn.HeaderText = "legal_lineup";
            this.legallineupDataGridViewTextBoxColumn.Name = "legallineupDataGridViewTextBoxColumn";
            this.legallineupDataGridViewTextBoxColumn.ReadOnly = true;
            this.legallineupDataGridViewTextBoxColumn.Width = 88;
            // 
            // weekidDataGridViewTextBoxColumn
            // 
            this.weekidDataGridViewTextBoxColumn.DataPropertyName = "week_id";
            this.weekidDataGridViewTextBoxColumn.HeaderText = "week_id";
            this.weekidDataGridViewTextBoxColumn.Name = "weekidDataGridViewTextBoxColumn";
            this.weekidDataGridViewTextBoxColumn.ReadOnly = true;
            this.weekidDataGridViewTextBoxColumn.Visible = false;
            this.weekidDataGridViewTextBoxColumn.Width = 72;
            // 
            // teamidDataGridViewTextBoxColumn
            // 
            this.teamidDataGridViewTextBoxColumn.DataPropertyName = "team_id";
            this.teamidDataGridViewTextBoxColumn.HeaderText = "team_id";
            this.teamidDataGridViewTextBoxColumn.Name = "teamidDataGridViewTextBoxColumn";
            this.teamidDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamidDataGridViewTextBoxColumn.Visible = false;
            this.teamidDataGridViewTextBoxColumn.Width = 69;
            // 
            // vDrawDataSetBindingSource
            // 
            this.vDrawDataSetBindingSource.DataSource = this.vDrawDataSet;
            this.vDrawDataSetBindingSource.Position = 0;
            // 
            // vDrawDataSet
            // 
            this.vDrawDataSet.DataSetName = "vDrawDataSet";
            this.vDrawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_Close
            // 
            this.b_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Close.Location = new System.Drawing.Point(1018, 40);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 1;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Details
            // 
            this.b_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Details.Location = new System.Drawing.Point(1018, 13);
            this.b_Details.Name = "b_Details";
            this.b_Details.Size = new System.Drawing.Size(75, 23);
            this.b_Details.TabIndex = 2;
            this.b_Details.Text = "&Details";
            this.b_Details.UseVisualStyleBackColor = true;
            this.b_Details.Click += new System.EventHandler(this.b_Details_Click);
            // 
            // hba_v_drawTableAdapter
            // 
            this.hba_v_drawTableAdapter.ClearBeforeFill = true;
            // 
            // frmDrawView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.b_Details);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.dgvDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrawView";
            this.Text = "Draw Results";
            this.Load += new System.EventHandler(this.frmDrawView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDrawDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDrawDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDraw;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Details;
        private System.Windows.Forms.BindingSource vDrawDataSetBindingSource;
        private vDrawDataSet vDrawDataSet;
        private vDrawDataSetTableAdapters.hba_v_drawTableAdapter hba_v_drawTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn draw_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pairingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundwinnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn game3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculated_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn legallineupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn;
    }
}