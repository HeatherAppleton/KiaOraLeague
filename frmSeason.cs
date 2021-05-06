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
    public partial class frmSeason : Form
    {
        private DBConnection LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;

        private DateTime idt_today = DateTime.Now;
        private int ii_rounds = 4;
        private int ii_roundSize = 9;
        private int ii_finals = 3;
        private int ii_total;

        private Boolean ib_loading = true;

        public frmSeason()
        {
            InitializeComponent();
        }

        private void CalculateLeagueLength()
        {
            if (!int.TryParse(t_rounds.Text, out ii_rounds))
            {
                ii_rounds = 4;
            }
            if (!int.TryParse(t_roundSize.Text, out ii_roundSize))
            {
                ii_roundSize = 9;
            }
            if (!int.TryParse(t_finalsSize.Text, out ii_finals))
            {
                ii_finals = 3;
            }
            ii_total = ii_rounds * ii_roundSize + ii_finals;
            t_totalWeeks.Text = ii_total.ToString();
        }

        private void frmSeason_Load(object sender, EventArgs e)
        {
            string ls_Season;
            string ls_sql;

            ls_Season = idt_today.ToString("yyyy");
            t_Season.Text = ls_Season;
            getData(ls_Season);

            ls_sql = "select c.settingName, c.settingValue from hba_config c ";
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    switch (isdr_data.GetString(0)){
                        case "ApplyBonus":
                            if(String.Equals(isdr_data.GetString(1), "Y"))
                            {
                                cb_applyBonus.Checked = true;
                            }
                            else
                            {
                                cb_applyBonus.Checked = false;
                            }
                            break;

                        case "FinalsRound":
                            t_finalsSize.Text = isdr_data.GetString(1);
                            if (!Int32.TryParse(t_finalsSize.Text, out ii_finals)){
                                ii_finals = 3;
                            }
                            break;

                        case "LeagueSize":
                            t_leagueSize.Text = isdr_data.GetString(1);
                            break;

                        case "MaxHandicap":
                            t_maxHandicap.Text = isdr_data.GetString(1);
                            break;

                        case "Rounds":
                            t_rounds.Text = isdr_data.GetString(1);
                            if (!Int32.TryParse(t_rounds.Text, out ii_rounds))
                            {
                                ii_rounds = 4;
                            }
                            break;

                        case "RoundSize":
                            t_roundSize.Text = isdr_data.GetString(1);
                            if (!Int32.TryParse(t_roundSize.Text, out ii_roundSize))
                            {
                                ii_roundSize = 9;
                            }
                            break;

                        case "TeamSize":
                            t_teamSize.Text = isdr_data.GetString(1);
                            break;

                    }
                }
            }
            isdr_data.Close();

            CalculateLeagueLength();

            ib_loading = false;
        }

        private void getData(string as_Season)
        {
            DataTable ldat_week;
            string ls_sql;

            ls_sql = string.Concat("select  cast(w.week_date as date) week_date ",
                                   "       ,w.season ",
                                   "       ,w.week_number ",
                                   "       ,w.round ",
                                   "       ,w.round_week ",
                                   "       ,w.id ",
                                   "from   hba_week w ",
                                   "where  w.season = ", as_Season, " ",
                                   "order by 1 ");
            ldat_week = LeagueDB.PopulateGridView(ls_sql);
            dgvSeason.DataSource = ldat_week;

        }

        private void b_NewSeason_Click(object sender, EventArgs e)
        {
            Int32 li_count = 0;
            string ls_sql;
            string ls_temp;
            string ls_season;
            DateTime ldt_FirstNight;
            DateTime ldt_Fieldays;
            DateTime ldt_ANZACDay;
            DateTime ldt_working;

            ls_season = t_Season.Text;
            if (!IsSeasonValid(ls_season))
            {
                return;
            }

            ls_sql = string.Concat("select count(*) ",
                                   "from   hba_week w ",
                                   "where  w.season = ", ls_season);
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read()) {
                    li_count = isdr_data.GetInt32(0);
                }
            }
            isdr_data.Close();

            if (li_count > 0)
            {
                MessageBox.Show("Season has already be setup.", "Error", MessageBoxButtons.OK);
                return;
            }

            ls_sql = string.Concat("select  dbo.f_get_FirstNight(", ls_season, ") ",
                                   "       ,dbo.f_get_fieldays(", ls_season, ") ",
                                   "       ,cast('", ls_season, "-04-25' as datetime) ");
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    ldt_FirstNight = isdr_data.GetDateTime(0);
                    ldt_Fieldays = isdr_data.GetDateTime(1);
                    ldt_ANZACDay = isdr_data.GetDateTime(2);

                    ldt_working = ldt_FirstNight.AddDays(-7);

                    ls_sql = "insert into hba_week(week_date, week_number, season) values ";

                    for (int i = 1; i <= ii_total; i++)
                    {
                        ldt_working = ldt_working.AddDays(7);

                        if (   ldt_working == ldt_ANZACDay
                            || ldt_working == ldt_Fieldays)
                        {
                            ldt_working = ldt_working.AddDays(7);
                        }

                        ls_temp = string.Concat("('", ldt_working.ToString("yyyy-MM-dd"), "', ",
                                               i.ToString(), ", ",
                                               ls_season, ")");
                        if (i < ii_total)
                        {
                            ls_temp += ',';
                        }

                        ls_sql += ls_temp;
                    }
                }
            }
            isdr_data.Close();

            // Insert all the hba_week records just constructed
            LeagueDB.ExecNonQuery(ls_sql);

            // Calcualte the Round/Round Weeks for the season
            ls_sql = "EXEC hba_s_season_rounds";
            LeagueDB.ExecNonQuery(ls_sql);

            // reset the round winners for the season just setup
            ls_sql = string.Concat("update hba_team ",
                                   "set round_winner = 0 ");
            LeagueDB.ExecNonQuery(ls_sql);

            // display the new season
            getData(ls_season);
        }

        private void b_View_Click(object sender, EventArgs e)
        {
            string ls_Season;

            ls_Season = t_Season.Text;

            if (!IsSeasonValid(ls_Season))
            {
                return;
            }

            getData(ls_Season);
        }

        private Boolean IsSeasonValid(string as_season)
        {
            int li_Season;

            if (string.IsNullOrEmpty(as_season))
            {
                MessageBox.Show("Season is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!int.TryParse(as_season, out li_Season))
            {
                MessageBox.Show("Season must be numeric.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (li_Season < 2012)
            {
                MessageBox.Show("Season must be greater than or equal to 2012.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int li_row;
            int li_weekid;
            DateTime ldt_weekdate;
            string ls_message;

            if (dgvSeason.Rows.Count < 1)
            {
                return;
            }

            li_row = dgvSeason.CurrentCell.RowIndex;
            if (!Int32.TryParse(dgvSeason.Rows[li_row].Cells["id"].Value.ToString(), out li_weekid))
            {
                return;
            }

            if (IsWeekIdInUse(li_weekid))
            {
                return;
            }

            DateTime.TryParse(dgvSeason.Rows[li_row].Cells["week_date"].Value.ToString(), out ldt_weekdate);

            ls_message = string.Format("Are you sure you want to delete the record for {0}?", ldt_weekdate.ToShortDateString());

            DialogResult result = MessageBox.Show(ls_message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                return;
            }

            deleteWeekId(li_weekid);
        }

        private Boolean IsWeekIdInUse(int ai_WeekId)
        {
            string ls_sql;
            Boolean lb_return = false;

            ls_sql = string.Concat("select count(*) as counter from hba_draw where week_id = ", ai_WeekId);
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    if (isdr_data[0].ToString() != "0")
                    {
                        MessageBox.Show("Results have already been entered for this week so it cannot be deleted.", "Error", MessageBoxButtons.OK);
                        lb_return = true;
                    }
                }

                isdr_data.Close();
            }

            return lb_return;
        }

        private void deleteWeekId(int ai_WeekId)
        {
            string[] transactionString = new string[3];
            int li_season = 0;
            int li_weekNumber = 0;
            string ls_sql;

            ls_sql = String.Format("select w.season, w.week_number from hba_week w where w.id = {0};", ai_WeekId);
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    Int32.TryParse(isdr_data[0].ToString(), out li_season);
                    Int32.TryParse(isdr_data[1].ToString(), out li_weekNumber);
                }
                isdr_data.Close();
            }
            else
            {
                return;
            }

            transactionString[0] = string.Format("delete from hba_week where id = {0};", ai_WeekId);
            transactionString[1] = getInsertNewFinalNightSQL(li_season);
            transactionString[2] = string.Format("update hba_week set week_number = week_number - 1 where season = {0} and week_number >= {1}", li_season, li_weekNumber);

            if (LeagueDB.ExecuteSqlTransaction("DeleteWeek", transactionString)){
                getData(li_season.ToString());
            }

            // recalculate the Round/Round Weeks of the records just updated.
            ls_sql = "exec hba_s_season_rounds";
            LeagueDB.ExecNonQuery(ls_sql);
        }

        private string getInsertNewFinalNightSQL(int ai_season)
        {
            DateTime ldt_finalNight = new DateTime();
            string ls_sql;
            int week_id = ii_total + 1;

            ls_sql = string.Format("select dateadd(wk, 1, max(w.week_date)) as finalNight from hba_week w where w.season = {0};", ai_season);
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    DateTime.TryParse(isdr_data[0].ToString(), out ldt_finalNight);
                }
                isdr_data.Close();
            }
            else
            {
                return "";
            }

            ls_sql = string.Format("select isnull(max(w.week_number),0) + 1 as week_number from hba_week w where w.season = {0};", ai_season);
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    Int32.TryParse(isdr_data[0].ToString(), out week_id);
                }
                isdr_data.Close();
            }
            else
            {
                return "";
            }


            ls_sql = string.Format("insert into hba_week(week_date, week_number, season) values ('{0}', {1}, {2});", 
                ldt_finalNight.ToString("yyyy-MM-dd"), week_id, ai_season);

            return ls_sql;
        }

        private Boolean UpdateConfigSetting (string settingName, string settingValue, string messageText, int minValue, int maxValue)
        {
            string ls_sql;
            int li_value;

            if (!String.Equals(settingName, "ApplyBonus"))
            {
                if (!Int32.TryParse(settingValue, out li_value))
                {
                    MessageBox.Show(messageText + " must be numeric.", "Error", MessageBoxButtons.OK);
                    return false;
                }

                if (li_value < minValue || li_value > maxValue)
                {
                    MessageBox.Show(messageText + " must be between " + minValue.ToString() + " and " + maxValue.ToString() + ".", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            ls_sql = string.Format("update hba_config set settingValue = '{0}' where settingName = '{1}' ", settingValue, settingName);
            LeagueDB.ExecNonQuery(ls_sql);

            return true;
        }

        private void b_updateSettings_Click(object sender, EventArgs e)
        {
            string[] ls_Settings = { "MaxHandicap", "LeagueSize", "TeamSize", "Rounds", "RoundSize", "FinalsRound", "ApplyBonus" }; // in screen tab order 
            string ls_settingName;
            string ls_settingValue = "";
            string ls_message_text = "";
            int li_min = 0;
            int li_max = 0;
            int li_temp = 0;

            int li_leagueSize = 0;

            if (!int.TryParse(t_leagueSize.Text, out li_leagueSize))
            {
                li_leagueSize = 10;
            }
            if (!int.TryParse(t_roundSize.Text, out li_temp))
            {
                li_temp = 9;
            }

            /*
            int li_roundSize = li_leagueSize - 1;
            DialogResult response = new DialogResult();
            if (li_roundSize < li_temp)
            {
                response = MessageBox.Show("Round Size should be " + li_roundSize.ToString() + ". Do you wish to change it?",
                                           "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    t_roundSize.Text = li_roundSize.ToString();
                }
            }
            */

            CalculateLeagueLength();
            if (ii_total > 39)
            {
                MessageBox.Show("The Season length exceeds maximum of 39 weeks. Please adjust Rounds, Rounds Size and/or Finals Size.", "Error", MessageBoxButtons.OK);
                t_rounds.Focus();
                return;
            }

            for (int i = 0; i < ls_Settings.Length; i++)
            {
                ls_settingName = ls_Settings[i];
                switch (ls_settingName)
                {
                    case "ApplyBonus":
                        if (cb_applyBonus.Checked)
                        {
                            ls_settingValue = "Y";
                        }
                        else
                        {
                            ls_settingValue = "N";
                        }
                        ls_message_text = cb_applyBonus.Text;
                        li_min = 0;
                        li_max = 0;
                        break;

                    case "FinalsRound":
                        ls_settingValue = t_finalsSize.Text;
                        ls_message_text = l_finalsSize.Text;

                        if (!Int32.TryParse(t_rounds.Text, out li_temp))
                        {
                            li_temp = 4;
                            t_rounds.Text = "3";
                        }
                        li_min = 3;
                        li_max = li_temp - 1;
                        break;

                    case "LeagueSize":
                        ls_settingValue = t_leagueSize.Text;
                        ls_message_text = l_leagueSize.Text;
                        li_min = 4;
                        li_max = 20;  // physical number of lanes at the centre
                        break;

                    case "MaxHandicap":
                        ls_settingValue = t_maxHandicap.Text;
                        ls_message_text = l_handicap.Text;
                        li_min = 0;
                        li_max = 200;
                        break;

                    case "Rounds":
                        ls_settingValue = t_rounds.Text;
                        ls_message_text = l_rounds.Text;
                        li_min = 2;
                        li_max = 5;
                        break;

                    case "RoundSize":
                        ls_settingName = t_roundSize.Text;
                        ls_message_text = l_roundSize.Text;
                        li_min = 3;
                        li_max = 9;
                        break;

                    case "TeamSize":
                        ls_settingValue = t_teamSize.Text;
                        ls_message_text = l_teamsize.Text;
                        li_min = 2;
                        li_max = 3; 
                        break;
                }

                if (!UpdateConfigSetting(ls_settingName, ls_settingValue, ls_message_text, li_min, li_max))
                {
                    switch (ls_settingName)
                    {
                        case "ApplyBonus":
                            cb_applyBonus.Focus();
                            break;

                        case "FinalsRound":
                            t_finalsSize.Focus();
                            break;

                        case "LeagueSize":
                            t_leagueSize.Focus();
                            break;

                        case "MaxHandicap":
                            t_maxHandicap.Focus();
                            break;

                        case "Rounds":
                            t_rounds.Focus();
                            break;

                        case "RoundSize":
                            t_roundSize.Focus();
                            break;

                        case "TeamSize":
                            t_teamSize.Focus();
                            break;
                    }
                }
            }
        }

        private void t_leagueSize_TextChanged(object sender, EventArgs e)
        {
            /*
            int li_leagueSize = 0;
            int li_roundSize = 0;
            DialogResult response = new DialogResult();

            if (ib_loading)
            {
                return;
            }

            if (!int.TryParse(t_leagueSize.Text, out li_leagueSize))
            {
                li_leagueSize = 10;
            }

            li_roundSize = li_leagueSize - 1;
            if (li_roundSize < 9)
            {
                response = MessageBox.Show("Round Size should be " + li_roundSize.ToString() + ". Do you wish to change it?", 
                                           "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 );
                if (response == DialogResult.Yes)
                {
                    t_roundSize.Text = ii_roundSize.ToString();
                    CalculateLeagueLength();
                }
            }
            */
        }

        private void t_rounds_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(t_rounds.Text, out ii_rounds))
            {
                ii_rounds = 0;
            }

            if (ii_rounds >= 2)
            {
                ii_finals = ii_rounds - 1;
            }
            else
            {
                ii_finals = 0;
            }

            t_finalsSize.Text = ii_finals.ToString();
            CalculateLeagueLength();
        }

        private void t_roundSize_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(t_roundSize.Text, out ii_roundSize))
            {
                ii_roundSize = 0;
            }

            CalculateLeagueLength();
        }

        private void t_finalsSize_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(t_finalsSize.Text, out ii_finals))
            {
                ii_finals = 0;
            }

            CalculateLeagueLength();
        }
    }
}
