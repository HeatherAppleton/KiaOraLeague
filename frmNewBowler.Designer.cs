namespace KiaOra
{
    partial class frmNewBowler
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
            this.b_Close = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.dd_Team = new System.Windows.Forms.ComboBox();
            this.t_position = new System.Windows.Forms.TextBox();
            this.l_Position = new System.Windows.Forms.Label();
            this.l_teamName = new System.Windows.Forms.Label();
            this.vActiveTeam = new KiaOra.vActiveTeam();
            this.hbateamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hba_teamTableAdapter = new KiaOra.vActiveTeamTableAdapters.hba_teamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vActiveTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Private
            // 
            this.cb_Private.AutoSize = true;
            this.cb_Private.Location = new System.Drawing.Point(7, 183);
            this.cb_Private.Name = "cb_Private";
            this.cb_Private.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_Private.Size = new System.Drawing.Size(61, 17);
            this.cb_Private.TabIndex = 9;
            this.cb_Private.Text = "Privacy";
            this.cb_Private.UseVisualStyleBackColor = true;
            this.cb_Private.CheckedChanged += new System.EventHandler(this.cb_Private_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(172, 125);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 6;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(118, 125);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 5;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(118, 96);
            this.t_email.MaxLength = 255;
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(257, 20);
            this.t_email.TabIndex = 4;
            // 
            // t_phone
            // 
            this.t_phone.Location = new System.Drawing.Point(118, 67);
            this.t_phone.MaxLength = 50;
            this.t_phone.Name = "t_phone";
            this.t_phone.Size = new System.Drawing.Size(257, 20);
            this.t_phone.TabIndex = 3;
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(118, 38);
            this.t_address.MaxLength = 255;
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(257, 20);
            this.t_address.TabIndex = 2;
            // 
            // l_Gender
            // 
            this.l_Gender.AutoSize = true;
            this.l_Gender.Location = new System.Drawing.Point(7, 125);
            this.l_Gender.Name = "l_Gender";
            this.l_Gender.Size = new System.Drawing.Size(45, 13);
            this.l_Gender.TabIndex = 0;
            this.l_Gender.Text = "Gender:";
            // 
            // l_Email
            // 
            this.l_Email.AutoSize = true;
            this.l_Email.Location = new System.Drawing.Point(7, 96);
            this.l_Email.Name = "l_Email";
            this.l_Email.Size = new System.Drawing.Size(35, 13);
            this.l_Email.TabIndex = 0;
            this.l_Email.Text = "Email:";
            // 
            // l_Phone
            // 
            this.l_Phone.AutoSize = true;
            this.l_Phone.Location = new System.Drawing.Point(7, 67);
            this.l_Phone.Name = "l_Phone";
            this.l_Phone.Size = new System.Drawing.Size(41, 13);
            this.l_Phone.TabIndex = 0;
            this.l_Phone.Text = "Phone:";
            // 
            // l_Address
            // 
            this.l_Address.AutoSize = true;
            this.l_Address.Location = new System.Drawing.Point(7, 38);
            this.l_Address.Name = "l_Address";
            this.l_Address.Size = new System.Drawing.Size(48, 13);
            this.l_Address.TabIndex = 0;
            this.l_Address.Text = "Address:";
            // 
            // l_BowlerName
            // 
            this.l_BowlerName.AutoSize = true;
            this.l_BowlerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_BowlerName.Location = new System.Drawing.Point(7, 9);
            this.l_BowlerName.Name = "l_BowlerName";
            this.l_BowlerName.Size = new System.Drawing.Size(73, 13);
            this.l_BowlerName.TabIndex = 0;
            this.l_BowlerName.Text = "Bowler Name:";
            // 
            // t_bowlerName
            // 
            this.t_bowlerName.Location = new System.Drawing.Point(118, 9);
            this.t_bowlerName.MaxLength = 30;
            this.t_bowlerName.Name = "t_bowlerName";
            this.t_bowlerName.Size = new System.Drawing.Size(257, 20);
            this.t_bowlerName.TabIndex = 1;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(605, 65);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 12;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(605, 37);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(75, 23);
            this.b_clear.TabIndex = 11;
            this.b_clear.Text = "C&lear";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(605, 9);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 10;
            this.b_update.Text = "&Update ";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // dd_Team
            // 
            this.dd_Team.DataSource = this.hbateamBindingSource;
            this.dd_Team.DisplayMember = "team_name";
            this.dd_Team.FormattingEnabled = true;
            this.dd_Team.Location = new System.Drawing.Point(121, 153);
            this.dd_Team.Name = "dd_Team";
            this.dd_Team.Size = new System.Drawing.Size(257, 21);
            this.dd_Team.TabIndex = 7;
            this.dd_Team.ValueMember = "id";
            this.dd_Team.SelectedIndexChanged += new System.EventHandler(this.dd_Team_SelectedIndexChanged);
            // 
            // t_position
            // 
            this.t_position.Location = new System.Drawing.Point(444, 153);
            this.t_position.MaxLength = 3;
            this.t_position.Name = "t_position";
            this.t_position.Size = new System.Drawing.Size(56, 20);
            this.t_position.TabIndex = 8;
            // 
            // l_Position
            // 
            this.l_Position.AutoSize = true;
            this.l_Position.Location = new System.Drawing.Point(391, 153);
            this.l_Position.Name = "l_Position";
            this.l_Position.Size = new System.Drawing.Size(47, 13);
            this.l_Position.TabIndex = 0;
            this.l_Position.Text = "Position:";
            // 
            // l_teamName
            // 
            this.l_teamName.AutoSize = true;
            this.l_teamName.Location = new System.Drawing.Point(7, 154);
            this.l_teamName.Name = "l_teamName";
            this.l_teamName.Size = new System.Drawing.Size(68, 13);
            this.l_teamName.TabIndex = 0;
            this.l_teamName.Text = "Team Name:";
            // 
            // vActiveTeam
            // 
            this.vActiveTeam.DataSetName = "vActiveTeam";
            this.vActiveTeam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hbateamBindingSource
            // 
            this.hbateamBindingSource.DataMember = "hba_team";
            this.hbateamBindingSource.DataSource = this.vActiveTeam;
            // 
            // hba_teamTableAdapter
            // 
            this.hba_teamTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewBowler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dd_Team);
            this.Controls.Add(this.t_position);
            this.Controls.Add(this.l_Position);
            this.Controls.Add(this.l_teamName);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_clear);
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
            this.Name = "frmNewBowler";
            this.Text = "New Bowler";
            this.Load += new System.EventHandler(this.frmNewBowler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vActiveTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbateamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.ComboBox dd_Team;
        private System.Windows.Forms.TextBox t_position;
        private System.Windows.Forms.Label l_Position;
        private System.Windows.Forms.Label l_teamName;
        private vActiveTeam vActiveTeam;
        private System.Windows.Forms.BindingSource hbateamBindingSource;
        private vActiveTeamTableAdapters.hba_teamTableAdapter hba_teamTableAdapter;
    }
}