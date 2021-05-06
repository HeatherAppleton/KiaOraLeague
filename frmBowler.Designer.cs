namespace KiaOra
{
    partial class frmBowler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBowler));
            this.dgvBowler = new System.Windows.Forms.DataGridView();
            this.b_Close = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hba_teamTableAdapter = new KiaOra.vTeamTableAdapters.hba_teamTableAdapter();
            this.vTeam = new KiaOra.vTeam();
            this.hbateamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vBowlerDetail = new KiaOra.vBowlerDetail();
            this.vBowlerDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.privacyflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bowlernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_New = new System.Windows.Forms.Button();
            this.b_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBowler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBowler
            // 
            this.dgvBowler.AllowUserToAddRows = false;
            this.dgvBowler.AllowUserToDeleteRows = false;
            this.dgvBowler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBowler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBowler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bowlernameDataGridViewTextBoxColumn,
            this.activeflagDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.privacyflagDataGridViewTextBoxColumn,
            this.Id});
            this.dgvBowler.DataMember = "vBowlerDetail";
            this.dgvBowler.Location = new System.Drawing.Point(13, 97);
            this.dgvBowler.Name = "dgvBowler";
            this.dgvBowler.ReadOnly = true;
            this.dgvBowler.Size = new System.Drawing.Size(988, 340);
            this.dgvBowler.TabIndex = 1;
            this.dgvBowler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBowler_CellContentDoubleClick);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(926, 6);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 2;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // hba_teamTableAdapter
            // 
            this.hba_teamTableAdapter.ClearBeforeFill = true;
            // 
            // vTeam
            // 
            this.vTeam.DataSetName = "vTeam";
            this.vTeam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hbateamBindingSource
            // 
            this.hbateamBindingSource.DataMember = "hba_team";
            this.hbateamBindingSource.DataSource = this.vTeam;
            // 
            // vBowlerDetail
            // 
            this.vBowlerDetail.DataSetName = "vBowlerDetail";
            this.vBowlerDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vBowlerDetailBindingSource
            // 
            this.vBowlerDetailBindingSource.DataSource = this.vBowlerDetail;
            this.vBowlerDetailBindingSource.Position = 0;
            // 
            // privacyflagDataGridViewTextBoxColumn
            // 
            this.privacyflagDataGridViewTextBoxColumn.DataPropertyName = "privacy_flag";
            this.privacyflagDataGridViewTextBoxColumn.HeaderText = "Privacy";
            this.privacyflagDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.privacyflagDataGridViewTextBoxColumn.Name = "privacyflagDataGridViewTextBoxColumn";
            this.privacyflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "team_name";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "Team Name";
            this.teamnameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MaxInputLength = 255;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MaxInputLength = 255;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeflagDataGridViewTextBoxColumn
            // 
            this.activeflagDataGridViewTextBoxColumn.DataPropertyName = "active_flag";
            this.activeflagDataGridViewTextBoxColumn.HeaderText = "Active";
            this.activeflagDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.activeflagDataGridViewTextBoxColumn.Name = "activeflagDataGridViewTextBoxColumn";
            this.activeflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bowlernameDataGridViewTextBoxColumn
            // 
            this.bowlernameDataGridViewTextBoxColumn.DataPropertyName = "bowler_name";
            this.bowlernameDataGridViewTextBoxColumn.HeaderText = "Bowler Name";
            this.bowlernameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.bowlernameDataGridViewTextBoxColumn.Name = "bowlernameDataGridViewTextBoxColumn";
            this.bowlernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b_New
            // 
            this.b_New.Location = new System.Drawing.Point(926, 37);
            this.b_New.Name = "b_New";
            this.b_New.Size = new System.Drawing.Size(75, 23);
            this.b_New.TabIndex = 3;
            this.b_New.Text = "&New Bowler";
            this.b_New.UseVisualStyleBackColor = true;
            this.b_New.Click += new System.EventHandler(this.b_New_Click);
            // 
            // b_Edit
            // 
            this.b_Edit.Location = new System.Drawing.Point(926, 68);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(75, 23);
            this.b_Edit.TabIndex = 4;
            this.b_Edit.Text = "&Edit Bowler";
            this.b_Edit.UseVisualStyleBackColor = true;
            this.b_Edit.Click += new System.EventHandler(this.b_Edit_Click);
            // 
            // frmBowler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.b_New);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.dgvBowler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBowler";
            this.Text = "Bowler Maintenance";
            this.Load += new System.EventHandler(this.frmBowler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBowler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBowlerDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBowler;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bowlernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacyflagDataGridViewTextBoxColumn;
        private vTeamTableAdapters.hba_teamTableAdapter hba_teamTableAdapter;
        private vTeam vTeam;
        private System.Windows.Forms.BindingSource hbateamBindingSource;
        private vBowlerDetail vBowlerDetail;
        private System.Windows.Forms.BindingSource vBowlerDetailBindingSource;
        private System.Windows.Forms.Button b_New;
        private System.Windows.Forms.Button b_Edit;
    }
}