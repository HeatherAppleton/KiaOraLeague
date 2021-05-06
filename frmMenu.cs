using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiaOra
{
    public partial class frmMenu : Form
    {
        private frmTeam team = new frmTeam();
        private frmBowler bowler = new frmBowler();
        private frmResultsEntry results = new frmResultsEntry();
        private frmSeason seasonMnt = new frmSeason();
        private frmBowlerNote bowlerNote = new frmBowlerNote();
        private frmTeamNote teamNote = new frmTeamNote();
        private frmDrawView drawView = new frmDrawView();
        private frmRoundResults roundResults = new frmRoundResults();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (team.IsDisposed)
            {
                team = new frmTeam();
            }
            team.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bowler.IsDisposed)
            {
                bowler = new frmBowler();
            }
            bowler.Show();
        }

        private void ll_ResultsEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (results.IsDisposed)
            {
                results = new frmResultsEntry();
            }
            results.Show();
        }

        private void ll_SeasonMaintenance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (seasonMnt.IsDisposed)
            {
                seasonMnt = new frmSeason();
            }
            seasonMnt.Show();
        }

        private void ll_BowlerNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bowlerNote.IsDisposed)
            {
                bowlerNote = new frmBowlerNote();
            }
            bowlerNote.Show();
        }

        private void ll_TeamNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (teamNote.IsDisposed)
            {
                teamNote = new frmTeamNote();
            }
            teamNote.Show();
        }

        private void ll_DrawResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (drawView.IsDisposed)
            {
                drawView = new frmDrawView();
            }
            drawView.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            team.Close();
            bowler.Close();
            results.Close();
            seasonMnt.Close();
            bowlerNote.Close();
            teamNote.Close();
            drawView.Close();
            roundResults.Close();
            Close();
    }

        private void ll_RoundResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roundResults.Show();
        }
    }
}
