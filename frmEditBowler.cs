using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiaOra
{
    public partial class frmEditBowler : Form
    {
        private DBConnection     LeagueDB         = new DBConnection();
        private BowlerValidation bowlerValidation = new BowlerValidation();
        private TeamValidation   teamValidation   = new TeamValidation();

        private frmBowler bowler;

        private int originalTeamId = 0;
        private int originalPosition = 0;
        private String originalTeamName = null;

        public frmEditBowler()
        {
            InitializeComponent();
        }

        private void frmEditBowler_Load(object sender, EventArgs e)
        {
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            string ls_sql;

            string ls_id;
            string ls_bowlerName;
            string ls_address;
            string ls_phone;
            string ls_email;
            string ls_gender = null;
            string ls_activeFlag = null;
            string ls_privacyFlag = null;
            string ls_teamId;
            string ls_teamName;
            string ls_position;

            ls_id = t_BowlerId.Text;

            ls_bowlerName = t_bowlerName.Text;
            ls_address = t_address.Text;
            ls_phone = t_phone.Text;
            ls_email = t_email.Text;

            if (cb_Active.Checked == true)
            {
                ls_activeFlag = "Y";
            }
            else
            {
                ls_activeFlag = "N";
            }

            if (cb_Private.Checked == true)
            {
                ls_privacyFlag = "Y";
            }
            else
            {
                ls_privacyFlag = "N";
            }

            if (rb_male.Checked == true)
            {
                ls_gender = "M";
            }
            else if (rb_female.Checked == true)
            {
                ls_gender = "F";
            }

            ls_teamName = dd_Team.Text;
            ls_position = t_position.Text;

            if (!bowlerValidation.IsValid(ls_bowlerName, ls_gender, ls_teamName, ls_position, ls_activeFlag, ls_privacyFlag)){
                return;
            }

            ls_teamId = dd_Team.SelectedValue.ToString();


            ls_sql = string.Concat("update hba_bowler "
                                  , "set  bowler_name = '", t_bowlerName.Text, "' "
                                  , "    ,address = '", t_address.Text, "' "
                                  , "    ,phone = '", t_phone.Text, "' "
                                  , "    ,email = '", t_email.Text, "' "
                                  , "    ,gender = '", ls_gender, "' "
                                  , "    ,active_flag = '", ls_activeFlag, "' "
                                  , "    ,privacy_flag = '", ls_privacyFlag, "' "
                                  , "    ,team_id = ", ls_teamId, " "
                                  , "    ,position = ", ls_position, " "
                                  , "where id = ", ls_id);
            if (LeagueDB.ExecNonQuery(ls_sql) == 1)
            {
                MessageBox.Show("Bowler updated successfully.", "Information", MessageBoxButtons.OK);
            }
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            if (!bowler.IsDisposed)
            {
                bowler.GetData();
            }
            Close();
        }

        public void SetCallingWindow(frmBowler caller)
        {
            bowler = caller;
        }

        public void SetData(int bowlerId, string bowlerName, string address, string phone, string email, string gender, string active, string privacy, int teamId, string teamName, int position )
        {
            int indexText;

            originalTeamId   = teamId;
            originalTeamName = teamName;
            originalPosition = position;

            this.hba_teamTableAdapter.Fill(this.vTeam.hba_team);

            indexText = dd_Team.FindString(teamName);
            dd_Team.Text = teamName;


            t_BowlerId.Text = bowlerId.ToString();
            t_bowlerName.Text = bowlerName;
            t_address.Text = address;
            t_phone.Text = phone;
            t_email.Text = email;
            t_position.Text = position.ToString();

            if (active == "Y")
            {
                cb_Active.Checked = true;
            }
            else
            {
                cb_Active.Checked = false;
            }

            if (gender == "M")
            {
                rb_female.Checked = false;
                rb_male.Checked = true;
            }
            else
            {
                rb_female.Checked = true;
                rb_male.Checked = false;
            }

            if (privacy == "Y")
            {
                cb_Private.Checked = true;
            }
            else
            {
                cb_Private.Checked = false;
            }
        }

        private void dd_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ls_teamId = null;
            string ls_teamName = "";
            int li_position = 0;

            ls_teamName = dd_Team.Text;
            if (String.IsNullOrEmpty(ls_teamName))
            {
                li_position = 0;
            }
            else if (String.Equals(originalTeamName, ls_teamName))
            {
                li_position = originalPosition;
            }
            else
            {
                ls_teamId = dd_Team.SelectedValue.ToString();
                Int32.TryParse(ls_teamId, out originalTeamId);

                li_position = teamValidation.GetNextPosition(ls_teamId);
            }
            t_position.Text = li_position.ToString();

        }

        private void cb_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Active.Checked == false)
            {
                dd_Team.Text = "zNo Longer Bowling";
            }
            else
            {
                dd_Team.Text = "";
            }
        }

    } 
}
