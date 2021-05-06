namespace KiaOra
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ll_TeamMaintenance = new System.Windows.Forms.LinkLabel();
            this.ll_BowlerMaintenance = new System.Windows.Forms.LinkLabel();
            this.ll_ResultsEntry = new System.Windows.Forms.LinkLabel();
            this.ll_SeasonMaintenance = new System.Windows.Forms.LinkLabel();
            this.ll_BowlerNote = new System.Windows.Forms.LinkLabel();
            this.ll_TeamNote = new System.Windows.Forms.LinkLabel();
            this.ll_DrawResults = new System.Windows.Forms.LinkLabel();
            this.b_Close = new System.Windows.Forms.Button();
            this.ll_RoundResults = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_TeamMaintenance
            // 
            this.ll_TeamMaintenance.AutoSize = true;
            this.ll_TeamMaintenance.Location = new System.Drawing.Point(49, 122);
            this.ll_TeamMaintenance.Name = "ll_TeamMaintenance";
            this.ll_TeamMaintenance.Size = new System.Drawing.Size(99, 13);
            this.ll_TeamMaintenance.TabIndex = 1;
            this.ll_TeamMaintenance.TabStop = true;
            this.ll_TeamMaintenance.Text = "Team Maintenance";
            this.ll_TeamMaintenance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ll_BowlerMaintenance
            // 
            this.ll_BowlerMaintenance.AutoSize = true;
            this.ll_BowlerMaintenance.Location = new System.Drawing.Point(49, 139);
            this.ll_BowlerMaintenance.Name = "ll_BowlerMaintenance";
            this.ll_BowlerMaintenance.Size = new System.Drawing.Size(104, 13);
            this.ll_BowlerMaintenance.TabIndex = 2;
            this.ll_BowlerMaintenance.TabStop = true;
            this.ll_BowlerMaintenance.Text = "Bowler Maintenance";
            this.ll_BowlerMaintenance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ll_ResultsEntry
            // 
            this.ll_ResultsEntry.AutoSize = true;
            this.ll_ResultsEntry.Location = new System.Drawing.Point(49, 29);
            this.ll_ResultsEntry.Name = "ll_ResultsEntry";
            this.ll_ResultsEntry.Size = new System.Drawing.Size(69, 13);
            this.ll_ResultsEntry.TabIndex = 0;
            this.ll_ResultsEntry.TabStop = true;
            this.ll_ResultsEntry.Text = "Results Entry";
            this.ll_ResultsEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ResultsEntry_LinkClicked);
            // 
            // ll_SeasonMaintenance
            // 
            this.ll_SeasonMaintenance.AutoSize = true;
            this.ll_SeasonMaintenance.Location = new System.Drawing.Point(49, 76);
            this.ll_SeasonMaintenance.Name = "ll_SeasonMaintenance";
            this.ll_SeasonMaintenance.Size = new System.Drawing.Size(108, 13);
            this.ll_SeasonMaintenance.TabIndex = 3;
            this.ll_SeasonMaintenance.TabStop = true;
            this.ll_SeasonMaintenance.Text = "Season Maintenance";
            this.ll_SeasonMaintenance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_SeasonMaintenance_LinkClicked);
            // 
            // ll_BowlerNote
            // 
            this.ll_BowlerNote.AutoSize = true;
            this.ll_BowlerNote.Location = new System.Drawing.Point(204, 139);
            this.ll_BowlerNote.Name = "ll_BowlerNote";
            this.ll_BowlerNote.Size = new System.Drawing.Size(155, 13);
            this.ll_BowlerNote.TabIndex = 4;
            this.ll_BowlerNote.TabStop = true;
            this.ll_BowlerNote.Text = "EOY Bowler Note Maintenance";
            this.ll_BowlerNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_BowlerNote_LinkClicked);
            // 
            // ll_TeamNote
            // 
            this.ll_TeamNote.AutoSize = true;
            this.ll_TeamNote.Location = new System.Drawing.Point(204, 122);
            this.ll_TeamNote.Name = "ll_TeamNote";
            this.ll_TeamNote.Size = new System.Drawing.Size(150, 13);
            this.ll_TeamNote.TabIndex = 5;
            this.ll_TeamNote.TabStop = true;
            this.ll_TeamNote.Text = "EOY Team Note Maintenance";
            this.ll_TeamNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_TeamNote_LinkClicked);
            // 
            // ll_DrawResults
            // 
            this.ll_DrawResults.AutoSize = true;
            this.ll_DrawResults.Location = new System.Drawing.Point(204, 29);
            this.ll_DrawResults.Name = "ll_DrawResults";
            this.ll_DrawResults.Size = new System.Drawing.Size(96, 13);
            this.ll_DrawResults.TabIndex = 6;
            this.ll_DrawResults.TabStop = true;
            this.ll_DrawResults.Text = "View Draw Results";
            this.ll_DrawResults.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_DrawResults_LinkClicked);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(701, 18);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 7;
            this.b_Close.Text = "&Close";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // ll_RoundResults
            // 
            this.ll_RoundResults.AutoSize = true;
            this.ll_RoundResults.Location = new System.Drawing.Point(204, 76);
            this.ll_RoundResults.Name = "ll_RoundResults";
            this.ll_RoundResults.Size = new System.Drawing.Size(77, 13);
            this.ll_RoundResults.TabIndex = 8;
            this.ll_RoundResults.TabStop = true;
            this.ll_RoundResults.Text = "Round Results";
            this.ll_RoundResults.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_RoundResults_LinkClicked);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ll_RoundResults);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.ll_DrawResults);
            this.Controls.Add(this.ll_TeamNote);
            this.Controls.Add(this.ll_BowlerNote);
            this.Controls.Add(this.ll_SeasonMaintenance);
            this.Controls.Add(this.ll_ResultsEntry);
            this.Controls.Add(this.ll_BowlerMaintenance);
            this.Controls.Add(this.ll_TeamMaintenance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Kia Ora 10 Pin Bowling League";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_TeamMaintenance;
        private System.Windows.Forms.LinkLabel ll_BowlerMaintenance;
        private System.Windows.Forms.LinkLabel ll_ResultsEntry;
        private System.Windows.Forms.LinkLabel ll_SeasonMaintenance;
        private System.Windows.Forms.LinkLabel ll_BowlerNote;
        private System.Windows.Forms.LinkLabel ll_TeamNote;
        private System.Windows.Forms.LinkLabel ll_DrawResults;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.LinkLabel ll_RoundResults;
    }
}