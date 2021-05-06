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
    public partial class frmNewBowler : Form
    {
        private DBConnection LeagueDB = new DBConnection();
        private BowlerValidation bowlerValidation = new BowlerValidation();
        private TeamValidation teamValidation = new TeamValidation();

        private Int32 li_position;
        private string ls_privacyFlag;
        private string ls_activeFlag = "Y";
        private string ls_bowlerName;
        private string ls_gender;
        private string ls_position;
        private string ls_teamId;
        private string ls_sql;

        private frmBowler bowler;



        public frmNewBowler()
        {
            InitializeComponent();
        }

        public void setCallingForm(frmBowler callingForm)
        {
            bowler = callingForm;
        }

        private void frmNewBowler_Load(object sender, EventArgs e)
        {
            this.hba_teamTableAdapter.Fill(this.vActiveTeam.hba_team);
            b_clear_Click(null, null);
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            t_bowlerName.Text = "";
            cb_Private.Checked = false;
            t_address.Text = "";
            t_phone.Text = "";
            t_email.Text = "";
            rb_female.Checked = false;
            rb_male.Checked = false;
            dd_Team.Text = " (select Team)";
            t_position.Text = "";
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            string address = "";
            string phone = "";
            string email = "";

            // validation
            if (!IsRecordValid())
            {
                return;
            }

            if (!String.IsNullOrEmpty(t_address.Text))
            {
                address = t_address.Text;
            }

            if (!String.IsNullOrEmpty(t_phone.Text))
            {
                phone = t_phone.Text;
            }

            if (!String.IsNullOrEmpty(t_email.Text))
            {
                email = t_email.Text;
            }

            // apply changes
            ls_sql = string.Concat("insert into hba_bowler (bowler_name, address, phone, email, gender, active_flag, privacy_flag, team_id, position) values ("
                                  , "'", ls_bowlerName, "' "
                                  , ",'", address, "' "
                                  , ",'", phone, "' "
                                  , ",'", email, "' "
                                  , ",'", ls_gender, "' "
                                  , ",'", ls_activeFlag, "' "
                                  , ",'", ls_privacyFlag, "' "
                                  , ",", ls_teamId, " "
                                  , ",", ls_position, " "
                                  , ");");
            if (LeagueDB.ExecNonQuery(ls_sql) == 1)
            {
                MessageBox.Show("Bowler recorded successfully.", "Information", MessageBoxButtons.OK);
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

        private Boolean IsRecordValid()
        {
            string ls_teamName = "";

            ls_bowlerName = t_bowlerName.Text;
            if (rb_male.Checked == true)
            {
                ls_gender = "M";
            }
            else if (rb_female.Checked == true)
            {
                ls_gender = "F";
            }

            ls_teamId = dd_Team.SelectedValue.ToString();
            ls_teamName = dd_Team.Text;
            ls_position = t_position.Text;

            if (cb_Private.Checked == true)
            {
                ls_privacyFlag = "Y";
            }
            else
            {
                ls_privacyFlag = "N";
            }


            return bowlerValidation.IsValid(ls_bowlerName, ls_gender, ls_teamName, ls_position, ls_activeFlag, ls_privacyFlag);
        }

        private void cb_Private_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dd_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teamId;

            if (String.IsNullOrEmpty(dd_Team.Text))
            {
                li_position = 0;
            }
            else
            {
                teamId = dd_Team.SelectedValue.ToString();
                li_position = teamValidation.GetNextPosition(teamId);
            }

            t_position.Text = li_position.ToString();
        }
    }
}
