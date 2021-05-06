namespace KiaOra
{
    partial class frmEditBowler
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
            this.t_position = new System.Windows.Forms.TextBox();
            this.l_Position = new System.Windows.Forms.Label();
            this.l_teamName = new System.Windows.Forms.Label();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.cb_Private = new System.Windows.Forms.CheckBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_phone = new System.Windows.Forms.TextBox();
            this.t_address = new System.Windows.Forms.TextBox();
            this.l_Gender = new System.Windows.Forms.Label();
            this.l_Email = new System.Windows.Forms.Label();
            this.l_Phone = new System.Windows.Forms.Label();
            this.l_Address = new System.Windows.Forms.Label();
            this.l_BowlerName = new System.Windows.Forms.Label();
            this.t_bowlerName = new System.Windows.Forms.TextBox();
            this.t_BowlerId = new System.Windows.Forms.TextBox();
            this.l_BowlerId = new System.Windows.Forms.Label();
            this.cb_Active = new System.Windows.Forms.CheckBox();
            this.dd_Team = new System.Windows.Forms.ComboBox();
            this.hbateamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTeam = new KiaOra.vTeam();
            this.hba_teamTableAdapter = new KiaOra.vTeamTableAdapters.hba_teamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // t_position
            // 
            this.t_position.Location = new System.Drawing.Point(451, 203);
            this.t_position.MaxLength = 3;
            this.t_position.Name = "t_position";
            this.t_position.Size = new System.Drawing.Size(56, 20);
            this.t_position.TabIndex = 10;
            // 
            // l_Position
            // 
            this.l_Position.AutoSize = true;
            this.l_Position.Location = new System.Drawing.Point(398, 207);
            this.l_Position.Name = "l_Position";
            this.l_Position.Size = new System.Drawing.Size(47, 13);
            this.l_Position.TabIndex = 0;
            this.l_Position.Text = "Position:";
            // 
            // l_teamName
            // 
            this.l_teamName.AutoSize = true;
            this.l_teamName.Location = new System.Drawing.Point(14, 207);
            this.l_teamName.Name = "l_teamName";
            this.l_teamName.Size = new System.Drawing.Size(68, 13);
            this.l_teamName.TabIndex = 0;
            this.l_teamName.Text = "Team Name:";
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(662, 43);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 13;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(662, 14);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 12;
            this.b_update.Text = "&Update ";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // cb_Private
            // 
            this.cb_Private.AutoSize = true;
            this.cb_Private.Location = new System.Drawing.Point(14, 234);
            this.cb_Private.Name = "cb_Private";
            this.cb_Private.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_Private.Size = new System.Drawing.Size(61, 17);
            this.cb_Private.TabIndex = 11;
            this.cb_Private.Text = "Privacy";
            this.cb_Private.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Checked = true;
            this.rb_female.Location = new System.Drawing.Point(179, 179);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 8;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(125, 179);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 7;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(125, 149);
            this.t_email.MaxLength = 255;
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(257, 20);
            this.t_email.TabIndex = 6;
            // 
            // t_phone
            // 
            this.t_phone.Location = new System.Drawing.Point(125, 122);
            this.t_phone.MaxLength = 50;
            this.t_phone.Name = "t_phone";
            this.t_phone.Size = new System.Drawing.Size(257, 20);
            this.t_phone.TabIndex = 5;
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(125, 95);
            this.t_address.MaxLength = 255;
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(257, 20);
            this.t_address.TabIndex = 4;
            // 
            // l_Gender
            // 
            this.l_Gender.AutoSize = true;
            this.l_Gender.Location = new System.Drawing.Point(14, 180);
            this.l_Gender.Name = "l_Gender";
            this.l_Gender.Size = new System.Drawing.Size(45, 13);
            this.l_Gender.TabIndex = 0;
            this.l_Gender.Text = "Gender:";
            // 
            // l_Email
            // 
            this.l_Email.AutoSize = true;
            this.l_Email.Location = new System.Drawing.Point(14, 153);
            this.l_Email.Name = "l_Email";
            this.l_Email.Size = new System.Drawing.Size(35, 13);
            this.l_Email.TabIndex = 0;
            this.l_Email.Text = "Email:";
            // 
            // l_Phone
            // 
            this.l_Phone.AutoSize = true;
            this.l_Phone.Location = new System.Drawing.Point(14, 126);
            this.l_Phone.Name = "l_Phone";
            this.l_Phone.Size = new System.Drawing.Size(41, 13);
            this.l_Phone.TabIndex = 0;
            this.l_Phone.Text = "Phone:";
            // 
            // l_Address
            // 
            this.l_Address.AutoSize = true;
            this.l_Address.Location = new System.Drawing.Point(14, 99);
            this.l_Address.Name = "l_Address";
            this.l_Address.Size = new System.Drawing.Size(48, 13);
            this.l_Address.TabIndex = 0;
            this.l_Address.Text = "Address:";
            // 
            // l_BowlerName
            // 
            this.l_BowlerName.AutoSize = true;
            this.l_BowlerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_BowlerName.Location = new System.Drawing.Point(14, 72);
            this.l_BowlerName.Name = "l_BowlerName";
            this.l_BowlerName.Size = new System.Drawing.Size(73, 13);
            this.l_BowlerName.TabIndex = 0;
            this.l_BowlerName.Text = "Bowler Name:";
            // 
            // t_bowlerName
            // 
            this.t_bowlerName.Location = new System.Drawing.Point(125, 68);
            this.t_bowlerName.MaxLength = 30;
            this.t_bowlerName.Name = "t_bowlerName";
            this.t_bowlerName.Size = new System.Drawing.Size(257, 20);
            this.t_bowlerName.TabIndex = 3;
            // 
            // t_BowlerId
            // 
            this.t_BowlerId.Location = new System.Drawing.Point(125, 10);
            this.t_BowlerId.Name = "t_BowlerId";
            this.t_BowlerId.ReadOnly = true;
            this.t_BowlerId.Size = new System.Drawing.Size(56, 20);
            this.t_BowlerId.TabIndex = 1;
            this.t_BowlerId.TabStop = false;
            // 
            // l_BowlerId
            // 
            this.l_BowlerId.AutoSize = true;
            this.l_BowlerId.Location = new System.Drawing.Point(14, 14);
            this.l_BowlerId.Name = "l_BowlerId";
            this.l_BowlerId.Size = new System.Drawing.Size(19, 13);
            this.l_BowlerId.TabIndex = 0;
            this.l_BowlerId.Text = "Id:";
            // 
            // cb_Active
            // 
            this.cb_Active.AutoSize = true;
            this.cb_Active.Location = new System.Drawing.Point(14, 41);
            this.cb_Active.Name = "cb_Active";
            this.cb_Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_Active.Size = new System.Drawing.Size(56, 17);
            this.cb_Active.TabIndex = 2;
            this.cb_Active.Text = "Active";
            this.cb_Active.UseVisualStyleBackColor = true;
            this.cb_Active.CheckedChanged += new System.EventHandler(this.cb_Active_CheckedChanged);
            // 
            // dd_Team
            // 
            this.dd_Team.DataSource = this.hbateamBindingSource;
            this.dd_Team.DisplayMember = "team_name";
            this.dd_Team.Location = new System.Drawing.Point(125, 204);
            this.dd_Team.Name = "dd_Team";
            this.dd_Team.Size = new System.Drawing.Size(257, 21);
            this.dd_Team.TabIndex = 9;
            this.dd_Team.ValueMember = "id";
            this.dd_Team.SelectedIndexChanged += new System.EventHandler(this.dd_Team_SelectedIndexChanged);
            // 
            // hbateamBindingSource
            // 
            this.hbateamBindingSource.DataMember = "hba_team";
            this.hbateamBindingSource.DataSource = this.vTeam;
            // 
            // vTeam
            // 
            this.vTeam.DataSetName = "vTeam";
            this.vTeam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hba_teamTableAdapter
            // 
            this.hba_teamTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditBowler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 332);
            this.Controls.Add(this.dd_Team);
            this.Controls.Add(this.t_BowlerId);
            this.Controls.Add(this.l_BowlerId);
            this.Controls.Add(this.cb_Active);
            this.Controls.Add(this.t_position);
            this.Controls.Add(this.l_Position);
            this.Controls.Add(this.l_teamName);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.cb_Private);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_phone);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.l_Gender);
            this.Controls.Add(this.l_Email);
            this.Controls.Add(this.l_Phone);
            this.Controls.Add(this.l_Address);
            this.Controls.Add(this.l_BowlerName);
            this.Controls.Add(this.t_bowlerName);
            this.Name = "frmEditBowler";
            this.Text = "Edit Bowler";
            this.Load += new System.EventHandler(this.frmEditBowler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_position;
        private System.Windows.Forms.Label l_Position;
        private System.Windows.Forms.Label l_teamName;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.CheckBox cb_Private;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_phone;
        private System.Windows.Forms.TextBox t_address;
        private System.Windows.Forms.Label l_Gender;
        private System.Windows.Forms.Label l_Email;
        private System.Windows.Forms.Label l_Phone;
        private System.Windows.Forms.Label l_Address;
        private System.Windows.Forms.Label l_BowlerName;
        private System.Windows.Forms.TextBox t_bowlerName;
        private System.Windows.Forms.TextBox t_BowlerId;
        private System.Windows.Forms.Label l_BowlerId;
        private System.Windows.Forms.CheckBox cb_Active;
        private System.Windows.Forms.ComboBox dd_Team;
        private vTeam vTeam;
        private System.Windows.Forms.BindingSource hbateamBindingSource;
        private vTeamTableAdapters.hba_teamTableAdapter hba_teamTableAdapter;
    }
}