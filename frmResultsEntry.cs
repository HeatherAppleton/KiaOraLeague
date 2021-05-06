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
    public partial class frmResultsEntry : Form
    {
        private DBConnection LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;

        private string is_default_week_id = null;
        private string is_week_date;

        private Boolean ib_loading = true;
        private Boolean ib_closing = false;

        private int ii_maxHandicap;
        private int ii_teamSize;
        private Boolean ib_applyBonus = true; 

        public frmResultsEntry()
        {
            InitializeComponent();
        }

        private void frmResultsEntry_Load(object sender, EventArgs e)
        {
            this.hba_bowlerTableAdapter.Fill(this.vActiveBowler.hba_bowler);
            this.hba_teamTableAdapter.Fill(this.vActiveTeam.hba_team);
            this.hba_v_current_seasonTableAdapter.Fill(this.vCurrentSeason.hba_v_current_season);

            GetMaxHandicap();
            GetTeamSize();
            GetApplyBonus();

            if (ii_teamSize < 3)
            {
                // hide bowler 3 from Team 1
                dd_t1_b3_id.Enabled = false;
                dd_t1_b3_id.Visible = false;

                cb_t1_b3_blind.Enabled = false;
                cb_t1_b3_blind.Visible = false;

                t_t1_b3_handicap.Enabled = false;
                t_t1_b3_handicap.Visible = false;

                t_t1_b3_g1.Enabled = false;
                t_t1_b3_g1.Visible = false;

                t_t1_b3_g2.Enabled = false;
                t_t1_b3_g2.Visible = false;

                t_t1_b3_g3.Enabled = false;
                t_t1_b3_g3.Visible = false;

                t_t1_b3_series.Enabled = false;
                t_t1_b3_series.Visible = false;

                // hide bowler 3 from Team 2
                dd_t2_b3_id.Enabled = false;
                dd_t2_b3_id.Visible = false;

                cb_t2_b3_blind.Enabled = false;
                cb_t2_b3_blind.Visible = false;

                t_t2_b3_handicap.Enabled = false;
                t_t2_b3_handicap.Visible = false;

                t_t2_b3_g1.Enabled = false;
                t_t2_b3_g1.Visible = false;

                t_t2_b3_g2.Enabled = false;
                t_t2_b3_g2.Visible = false;

                t_t2_b3_g3.Enabled = false;
                t_t2_b3_g3.Visible = false;

                t_t2_b3_series.Enabled = false;
                t_t2_b3_series.Visible = false;
            }

            SetDefaultWeek();

            ib_loading = false;
        }

        private void GetMaxHandicap()
        {
            string ls_sql;

            ls_sql = String.Format("select settingValue from hba_config where settingName = '{0}'", "MaxHandicap");

            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    if (!Int32.TryParse(isdr_data[0].ToString(), out ii_maxHandicap))
                    {
                        ii_maxHandicap = 100;
                    }
                }
            }
            else
            {
                ii_maxHandicap = 100;
            }

            isdr_data.Close();
        }

        private void GetApplyBonus()
        {
            string ls_sql;
            string ls_value = "Y";

            ls_sql = String.Format("select upper(left(settingValue,1)) from hba_config where settingName = '{0}'", "ApplyBonus");

            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    ls_value = isdr_data[0].ToString();
                }
            }
            isdr_data.Close();

            ib_applyBonus = (ls_value == "Y");
        }

        private void GetTeamSize()
        {
            string ls_sql;

            ls_sql = String.Format("select settingValue from hba_config where settingName = '{0}'", "TeamSize");

            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    if (!Int32.TryParse(isdr_data[0].ToString(), out ii_teamSize))
                    {
                        ii_teamSize = 3;
                    }
                }
            }
            else
            {
                ii_teamSize = 3;
            }

            if (ii_teamSize < 2)
            {
                ii_teamSize = 2;
            }
            else if(ii_teamSize > 3)
            {
                ii_teamSize = 3;
            }

            isdr_data.Close();
        }

        private void SetDefaultWeek()
        {
            string ls_sql;

            is_default_week_id = null;

            ls_sql = string.Concat("select  w.Id ",
                                    "       ,convert(varchar, w.week_date, 103) as week_date ",
                                    "from   hba_week w ",
                                    "where  w.id = (select min(vcs.Id) as Id ",
                                    "               from hba_v_current_season vcs ",
                                    "               where vcs.week_date <= getdate() ",
                                    "               and not exists(select 1 ",
                                    "                              from hba_draw d ",
                                    "                              where d.week_id = vcs.id ",
                                    "                             ) ",
                                    "              )");
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    is_default_week_id = isdr_data[0].ToString();
                    is_week_date = isdr_data[1].ToString();
                }
            }

            isdr_data.Close();

            if (String.IsNullOrEmpty(is_default_week_id))
            {
                ls_sql = string.Concat("select min(w.Id) "
                                      ,"       ,convert(varchar, min(w.week_date), 103) as week_date "
                                      , "from   hba_week w "
                                      ,"where  w.season = year(getdate()) ");
                isdr_data = LeagueDB.ExecQuery(ls_sql);
                if (isdr_data.HasRows)
                {
                    while (isdr_data.Read())
                    {
                        is_default_week_id = isdr_data[0].ToString();
                        is_week_date = isdr_data[1].ToString();

                    }
                }
                isdr_data.Close();
            }

            dd_WeekId.SelectedValue = is_default_week_id;

            RecalculateHandicaps();

            return;
        }

        private void dd_WeekId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox lcb_week = (ComboBox)sender;

            if (lcb_week.SelectedIndex >= 0)
            {
                is_default_week_id = lcb_week.SelectedValue.ToString();
                is_week_date = lcb_week.Text.ToString();

                RecalculateHandicaps();
            }
            return;
        }

        private void RecalculateHandicaps()
        {
            string ls_sql;

            ls_sql = string.Concat("exec hba_s_averages_audit @p_week_id=", is_default_week_id);
            LeagueDB.ExecNonQuery(ls_sql);

            ib_loading = true;
            SetupNewRecord();
            ib_loading = false;

            return;

        }

        private void SetupNewRecord()
        {
            string ls_sql;
            int li_pairing = 0;
            int li_lane;

            ls_sql = string.Concat("select count(*) from hba_draw d where d.week_id = ", is_default_week_id);
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    li_pairing = Convert.ToInt16(isdr_data[0].ToString());
                }
            }
            isdr_data.Close();

            if (li_pairing == 0)
            {
                li_pairing = 1;
            }
            else
            {
                li_pairing = li_pairing / 2 + 1;
            }
            li_lane = li_pairing * 2;

            t_pairing.Text = Convert.ToString(li_pairing);

            t_t1_lane.Text = Convert.ToString(li_lane - 1);
            dd_team1.Text = "";
            cb_t1_legal.Checked = true;

            t_t2_lane.Text = Convert.ToString(li_lane);
            dd_team2.Text = "";
            cb_t2_legal.Checked = true;

            ib_loading = true;
            ResetBowlerScore(1);
            ResetBowlerScore(2);
            ResetBowlerScore(3);
            ResetBowlerScore(4);
            ResetBowlerScore(5);
            ResetBowlerScore(6);
            ib_loading = false;

            dd_team1.Focus();

            return;
        }

        private void ResetBowlerScore(int ai_b_index)
        {
            string ls_series;
            string ls_id = "";
            string ls_handicap = "0";
            string ls_sql;
            int li_handicap;
            int li_average;

            if (ib_loading)
            {
                switch (ai_b_index)
                {
                    case 1:
                        dd_t1_b1_id.Text = "";
                        cb_t1_b1_blind.Checked = false;
                        break;
                    case 2:
                        dd_t1_b2_id.Text = "";
                        cb_t1_b2_blind.Checked = false;
                        break;
                    case 3:
                        dd_t1_b3_id.Text = "";
                        cb_t1_b3_blind.Checked = false;
                        break;

                    case 4:
                        dd_t2_b1_id.Text = "";
                        cb_t2_b1_blind.Checked = false;
                        break;
                    case 5:
                        dd_t2_b2_id.Text = "";
                        cb_t2_b2_blind.Checked = false;
                        break;
                    case 6:
                        dd_t2_b3_id.Text = "";
                        cb_t2_b3_blind.Checked = false;
                        break;
                }
            }
            else 
            {

                switch (ai_b_index)
                {
                    case 1:
                        if (dd_t1_b1_id.SelectedIndex >= 0)
                        {
                            ls_id = dd_t1_b1_id.SelectedValue.ToString();
                        }
                        break;

                    case 2:
                        if (dd_t1_b2_id.SelectedIndex >= 0)
                        {
                            ls_id = dd_t1_b2_id.SelectedValue.ToString();
                        }
                        break;

                    case 3:
                        if (dd_t1_b3_id.SelectedIndex >= 0)
                        {
                            ls_id = dd_t1_b3_id.SelectedValue.ToString();
                        }
                        break;

                    case 4:
                        if (dd_t2_b1_id.SelectedIndex >= 0)
                        {
                            ls_id = dd_t2_b1_id.SelectedValue.ToString();
                        }
                        break;

                    case 5:
                        if (dd_t2_b2_id.SelectedIndex >= 0)
                        {
                            ls_id = dd_t2_b2_id.SelectedValue.ToString();
                        }
                        break;

                    case 6:
                        if (dd_t2_b3_id.SelectedIndex >= 0)
                        {
                            ls_id = dd_t2_b3_id.SelectedValue.ToString();
                        }
                        break;
                }

                if (string.IsNullOrEmpty(ls_id))
                {
                    ls_handicap = ii_maxHandicap.ToString();
                }
                else {
                    ls_sql = string.Concat("select floor(avg(series_average)) ",
                                           "from hba_averages a ",
                                           "join hba_score_sheet s on s.id = a.score_sheet_id ",
                                           "where s.bowler_id = ", ls_id);
                    isdr_data = LeagueDB.ExecQuery(ls_sql);
                    if (isdr_data.HasRows)
                    {
                        while (isdr_data.Read())
                        {
                            if (!int.TryParse(isdr_data[0].ToString(), out li_average))
                            {
                                li_average = 200 - ii_maxHandicap;
                            }
                            li_handicap = 200 - li_average;
                            if (li_handicap > ii_maxHandicap)
                            {
                                li_handicap = ii_maxHandicap;
                            }
                            ls_handicap = li_handicap.ToString();
                        }
                    }
                    else
                    {
                        ls_handicap = ii_maxHandicap.ToString();
                    }
                    isdr_data.Close();
                }
            }

            ls_series = Convert.ToString(Convert.ToInt16(ls_handicap) * 3);

            switch (ai_b_index)
            {
                case 1:
                    cb_t1_b1_blind.Checked = false;
                    t_t1_b1_handicap.Text = ls_handicap;
                    t_t1_b1_g1.Text = "0";
                    t_t1_b1_g2.Text = "0";
                    t_t1_b1_g3.Text = "0";
                    t_t1_b1_series.Text = ls_series;
                    UpdateTeamTotals(1);
                    break;

                case 2:
                    cb_t1_b2_blind.Checked = false;
                    t_t1_b2_handicap.Text = ls_handicap;
                    t_t1_b2_g1.Text = "0";
                    t_t1_b2_g2.Text = "0";
                    t_t1_b2_g3.Text = "0";
                    t_t1_b2_series.Text = ls_series;
                    UpdateTeamTotals(1);
                    break;

                case 3:
                    cb_t1_b3_blind.Checked = false;
                    t_t1_b3_handicap.Text = ls_handicap;
                    t_t1_b3_g1.Text = "0";
                    t_t1_b3_g2.Text = "0";
                    t_t1_b3_g3.Text = "0";
                    t_t1_b3_series.Text = ls_series;
                    UpdateTeamTotals(1);
                    break;

                case 4:
                    cb_t2_b1_blind.Checked = false;
                    t_t2_b1_handicap.Text = ls_handicap;
                    t_t2_b1_g1.Text = "0";
                    t_t2_b1_g2.Text = "0";
                    t_t2_b1_g3.Text = "0";
                    t_t2_b1_series.Text = ls_series;
                    UpdateTeamTotals(2);
                    break;

                case 5:
                    cb_t2_b2_blind.Checked = false;
                    t_t2_b2_handicap.Text = ls_handicap;
                    t_t2_b2_g1.Text = "0";
                    t_t2_b2_g2.Text = "0";
                    t_t2_b2_g3.Text = "0";
                    t_t2_b2_series.Text = ls_series;
                    UpdateTeamTotals(2);
                    break;

                case 6:
                    cb_t2_b3_blind.Checked = false;
                    t_t2_b3_handicap.Text = ls_handicap;
                    t_t2_b3_g1.Text = "0";
                    t_t2_b3_g2.Text = "0";
                    t_t2_b3_g3.Text = "0";
                    t_t2_b3_series.Text = ls_series;
                    UpdateTeamTotals(2);
                    break;
            }

        }

        private void DefaultTeamBowlers(int ai_teamNumber)
        {
            DataTable ldt_bowler;
            int li_row = 0;
            string ls_sql;
            string ls_team_id = "";
            string ls_b1_id = "";
            string ls_b1_name = "";
            string ls_b2_id = "";
            string ls_b2_name = "";
            string ls_b3_id = "";
            string ls_b3_name = "";


            if (ib_closing)
            {
                return;
            }


            switch (ai_teamNumber)
            {
                case 1:
                    ls_team_id = dd_team1.SelectedValue.ToString();
                    break;

                case 2:
                    ls_team_id = dd_team2.SelectedValue.ToString();
                    break;
            }

            ls_sql = string.Concat("select  b.id ",
                       "       ,b.bowler_name ",
                       "from hba_bowler b ",
                       "where b.team_id = ", ls_team_id, " ",
                       "order by b.position, b.bowler_name");
            ldt_bowler = LeagueDB.PopulateGridView(ls_sql);

            if (ldt_bowler.Rows.Count > 0)
            {
                foreach (DataRow dtRow in ldt_bowler.Rows)
                {
                    li_row++;

                    switch (li_row)
                    {
                        case 1:
                            ls_b1_id = dtRow[0].ToString();
                            ls_b1_name = dtRow[1].ToString();
                            break;

                        case 2:
                            ls_b2_id = dtRow[0].ToString();
                            ls_b2_name = dtRow[1].ToString();
                            break;

                        case 3:
                            ls_b3_id = dtRow[0].ToString();
                            ls_b3_name = dtRow[1].ToString();
                            break;
                    }
                }
            }

            switch (ai_teamNumber)
            {
                case 1:
                    dd_t1_b1_id.Text = ls_b1_name;
                    dd_t1_b2_id.Text = ls_b2_name;
                    dd_t1_b3_id.Text = ls_b3_name;
                    cb_t1_b1_blind.Checked = false;
                    cb_t1_b2_blind.Checked = false;
                    cb_t1_b3_blind.Checked = false;
                    break;

                case 2:
                    dd_t2_b1_id.Text = ls_b1_name;
                    dd_t2_b2_id.Text = ls_b2_name;
                    dd_t2_b3_id.Text = ls_b3_name;
                    cb_t1_b1_blind.Checked = false;
                    cb_t2_b2_blind.Checked = false;
                    cb_t2_b3_blind.Checked = false;
                    break;
            }

        }

        private void dd_team1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (  !ib_loading 
                && dd_team1.SelectedIndex >= 0)
            {
                cb_t1_legal.Checked = true;
                DefaultTeamBowlers(1);
            }
        }

        private void dd_team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ib_loading
                && dd_team1.SelectedIndex >= 0)
            {
                cb_t2_legal.Checked = true;
                DefaultTeamBowlers(2);
            }
        }

        private void UpdateTeamTotals(int ai_TeamNumber)
        {
            TeamResultsCalculation[] results = new TeamResultsCalculation[ii_teamSize];
            Boolean lb_blindScore;
            int li_handicap;
            int li_temp;
            int li_game1 = 0;
            int li_game2 = 0;
            int li_game3 = 0;
            int li_series = 0;
            int li_blinds = 0;
            int li_entry = 0;
            int li_bonus = 0;

            if (ib_loading
                || ib_closing)
            {
                return;
            }

            switch (ai_TeamNumber)
            {
                case 1:
                    // bowler 1
                    lb_blindScore = cb_t1_b1_blind.Checked;

                    if (!int.TryParse(t_t1_b1_handicap.Text, out li_handicap))
                    {
                        li_handicap = 0;
                    }

                    if (!int.TryParse(t_t1_b1_g1.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game1 = li_handicap + li_temp;
                    li_series = li_game1;

                    if (!int.TryParse(t_t1_b1_g2.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game2 = li_handicap + li_temp;
                    li_series = li_series + li_game2;

                    if (!int.TryParse(t_t1_b1_g3.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game3 = li_handicap + li_temp;
                    li_series = li_series + li_game3;

                    results[0] = new TeamResultsCalculation(lb_blindScore, li_game1, li_game2, li_game3, li_series);

                    // bowler 2
                    lb_blindScore = cb_t1_b2_blind.Checked;

                    if (!int.TryParse(t_t1_b2_handicap.Text, out li_handicap))
                    {
                        li_handicap = 0;
                    }

                    if (!int.TryParse(t_t1_b2_g1.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game1 = li_handicap + li_temp;
                    li_series = li_game1;

                    if (!int.TryParse(t_t1_b2_g2.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game2 = li_handicap + li_temp;
                    li_series = li_series + li_game2;

                    if (!int.TryParse(t_t1_b2_g3.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game3 = li_handicap + li_temp;
                    li_series = li_series + li_game3;

                    results[1] = new TeamResultsCalculation(lb_blindScore, li_game1, li_game2, li_game3, li_series);

                    // bowler 3
                    if (ii_teamSize == 3)
                    {
                        lb_blindScore = cb_t1_b3_blind.Checked;

                        if (!int.TryParse(t_t1_b3_handicap.Text, out li_handicap))
                        {
                            li_handicap = 0;
                        }

                        if (!int.TryParse(t_t1_b3_g1.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game1 = li_handicap + li_temp;
                        li_series = li_game1;

                        if (!int.TryParse(t_t1_b3_g2.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game2 = li_handicap + li_temp;
                        li_series = li_series + li_game2;

                        if (!int.TryParse(t_t1_b3_g3.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game3 = li_handicap + li_temp;
                        li_series = li_series + li_game3;

                        results[2] = new TeamResultsCalculation(lb_blindScore, li_game1, li_game2, li_game3, li_series);
                    }
                    break;

                case 2:
                    // bowler 1
                    lb_blindScore = cb_t2_b1_blind.Checked;

                    if (!int.TryParse(t_t2_b1_handicap.Text, out li_handicap))
                    {
                        li_handicap = 0;
                    }

                    if (!int.TryParse(t_t2_b1_g1.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game1 = li_handicap + li_temp;
                    li_series = li_game1;

                    if (!int.TryParse(t_t2_b1_g2.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game2 = li_handicap + li_temp;
                    li_series = li_series + li_game2;

                    if (!int.TryParse(t_t2_b1_g3.Text, out li_temp))
                    {
                        li_temp = 0;
                    }
                    li_game3 = li_handicap + li_temp;
                    li_series = li_series + li_game3;

                    results[0] = new TeamResultsCalculation(lb_blindScore, li_game1, li_game2, li_game3, li_series);

                    // bowler 2
                    if (ii_teamSize >= 2)
                    {
                        lb_blindScore = cb_t2_b2_blind.Checked;

                        if (!int.TryParse(t_t2_b2_handicap.Text, out li_handicap))
                        {
                            li_handicap = 0;
                        }

                        if (!int.TryParse(t_t2_b2_g1.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game1 = li_handicap + li_temp;
                        li_series = li_game1;

                        if (!int.TryParse(t_t2_b2_g2.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game2 = li_handicap + li_temp;
                        li_series = li_series + li_game2;

                        if (!int.TryParse(t_t2_b2_g3.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game3 = li_handicap + li_temp;
                        li_series = li_series + li_game3;

                        results[1] = new TeamResultsCalculation(lb_blindScore, li_game1, li_game2, li_game3, li_series);
                    }

                    // bowler 3
                    if (ii_teamSize >= 3)
                    {
                        lb_blindScore = cb_t2_b3_blind.Checked;

                        if (!int.TryParse(t_t2_b3_handicap.Text, out li_handicap))
                        {
                            li_handicap = 0;
                        }

                        if (!int.TryParse(t_t2_b3_g1.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game1 = li_handicap + li_temp;
                        li_series = li_game1;

                        if (!int.TryParse(t_t2_b3_g2.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game2 = li_handicap + li_temp;
                        li_series = li_series + li_game2;

                        if (!int.TryParse(t_t2_b3_g3.Text, out li_temp))
                        {
                            li_temp = 0;
                        }
                        li_game3 = li_handicap + li_temp;
                        li_series = li_series + li_game3;

                        results[2] = new TeamResultsCalculation(lb_blindScore, li_game1, li_game2, li_game3, li_series);
                    }
                    break;
            }

            // do the calculations
            li_blinds = 0;
            li_game1 = 0;
            li_game2 = 0;
            li_game3 = 0;
            li_series = 0;
            li_bonus = 0;

            while (li_entry < ii_teamSize)
            {
                if (results[li_entry].blindScore == true)
                {
                    li_blinds++;
                }
                li_game1 += results[li_entry].game1;
                li_game2 += results[li_entry].game2;
                li_game3 += results[li_entry].game3;
                li_series += results[li_entry].series;

                if (ib_applyBonus && results[li_entry].series >= 600)
                {
                    li_bonus++;
                }

                // next iteration
                li_entry++;
            }

            // display the results
            switch (ai_TeamNumber)
            {
                case 1:
                    if (li_blinds == ii_teamSize)
                    {
                        cb_t1_legal.Checked = false;
                    }
                    else
                    {
                        cb_t1_legal.Checked = true;
                    }
                    t_t1_g1.Text = Convert.ToString(li_game1);
                    t_t1_g2.Text = Convert.ToString(li_game2);
                    t_t1_g3.Text = Convert.ToString(li_game3);
                    t_t1_series.Text = Convert.ToString(li_series);
                    t_t1_bonuses.Text = Convert.ToString(li_bonus);
                    break;

                case 2:
                    if (li_blinds == ii_teamSize)
                    {
                        cb_t2_legal.Checked = false;
                    }
                    else
                    {
                        cb_t2_legal.Checked = true;
                    }
                    t_t2_g1.Text = Convert.ToString(li_game1);
                    t_t2_g2.Text = Convert.ToString(li_game2);
                    t_t2_g3.Text = Convert.ToString(li_game3);
                    t_t2_series.Text = Convert.ToString(li_series);
                    t_t2_bonuses.Text = Convert.ToString(li_bonus);
                    break;
            }


        }

        private void dd_t1_b1_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBowlerScore(1);
            UpdateTeamTotals(1);
        }

        private void dd_t1_b2_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBowlerScore(2);
            UpdateTeamTotals(1);
        }

        private void dd_t1_b3_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBowlerScore(3);
            UpdateTeamTotals(1);
        }

        private void dd_t2_b1_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBowlerScore(4);
            UpdateTeamTotals(2);
        }

        private void dd_t2_b2_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBowlerScore(5);
            UpdateTeamTotals(2);
        }

        private void dd_t2_b3_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBowlerScore(6);
            UpdateTeamTotals(2);
        }

        private void cb_t1_b1_blind_CheckedChanged(object sender, EventArgs e)
        {
            Boolean lb_readOnly = false;
            string ls_score = "0";

            if (cb_t1_b1_blind.Checked == true)
            {
                ls_score = Convert.ToString(190 - Convert.ToInt16(t_t1_b1_handicap.Text));
                lb_readOnly = true;
            }

            t_t1_b1_g1.Text = ls_score;
            t_t1_b1_g2.Text = ls_score;
            t_t1_b1_g3.Text = ls_score;

            t_t1_b1_g1.ReadOnly = lb_readOnly;
            t_t1_b1_g2.ReadOnly = lb_readOnly;
            t_t1_b1_g3.ReadOnly = lb_readOnly;

        }

        private void cb_t1_b2_blind_CheckedChanged(object sender, EventArgs e)
        {
            Boolean lb_readOnly = false;
            string ls_score = "0";

            if (cb_t1_b2_blind.Checked == true)
            {
                ls_score = Convert.ToString(190 - Convert.ToInt16(t_t1_b2_handicap.Text));
                lb_readOnly = true;
            }

            t_t1_b2_g1.Text = ls_score;
            t_t1_b2_g2.Text = ls_score;
            t_t1_b2_g3.Text = ls_score;

            t_t1_b2_g1.ReadOnly = lb_readOnly;
            t_t1_b2_g2.ReadOnly = lb_readOnly;
            t_t1_b2_g3.ReadOnly = lb_readOnly;
        }

        private void cb_t1_b3_blind_CheckedChanged(object sender, EventArgs e)
        {
            Boolean lb_readOnly = false;
            string ls_score = "0";

            if (cb_t1_b3_blind.Checked == true)
            {
                ls_score = Convert.ToString(190 - Convert.ToInt16(t_t1_b3_handicap.Text));
                lb_readOnly = true;
            }

            t_t1_b3_g1.Text = ls_score;
            t_t1_b3_g2.Text = ls_score;
            t_t1_b3_g3.Text = ls_score;

            t_t1_b3_g1.ReadOnly = lb_readOnly;
            t_t1_b3_g2.ReadOnly = lb_readOnly;
            t_t1_b3_g3.ReadOnly = lb_readOnly;
        }

        private void cb_t2_b1_blind_CheckedChanged(object sender, EventArgs e)
        {
            Boolean lb_readOnly = false;
            string ls_score = "0";

            if (cb_t2_b1_blind.Checked == true)
            {
                ls_score = Convert.ToString(190 - Convert.ToInt16(t_t2_b1_handicap.Text));
                lb_readOnly = true;
            }

            t_t2_b1_g1.Text = ls_score;
            t_t2_b1_g2.Text = ls_score;
            t_t2_b1_g3.Text = ls_score;

            t_t2_b1_g1.ReadOnly = lb_readOnly;
            t_t2_b1_g2.ReadOnly = lb_readOnly;
            t_t2_b1_g3.ReadOnly = lb_readOnly;
        }

        private void cb_t2_b2_blind_CheckedChanged(object sender, EventArgs e)
        {
            Boolean lb_readOnly = false;
            string ls_score = "0";

            if (cb_t2_b2_blind.Checked == true)
            {
                ls_score = Convert.ToString(190 - Convert.ToInt16(t_t2_b2_handicap.Text));
                lb_readOnly = true;
            }

            t_t2_b2_g1.Text = ls_score;
            t_t2_b2_g2.Text = ls_score;
            t_t2_b2_g3.Text = ls_score;

            t_t2_b2_g1.ReadOnly = lb_readOnly;
            t_t2_b2_g2.ReadOnly = lb_readOnly;
            t_t2_b2_g3.ReadOnly = lb_readOnly;
        }

        private void cb_t2_b3_blind_CheckedChanged(object sender, EventArgs e)
        {
            Boolean lb_readOnly = false;
            string ls_score = "0";

            if (cb_t2_b3_blind.Checked == true)
            {
                ls_score = Convert.ToString(190 - Convert.ToInt16(t_t2_b3_handicap.Text));
                lb_readOnly = true;
            }

            t_t2_b3_g1.Text = ls_score;
            t_t2_b3_g2.Text = ls_score;
            t_t2_b3_g3.Text = ls_score;

            t_t2_b3_g1.ReadOnly = lb_readOnly;
            t_t2_b3_g2.ReadOnly = lb_readOnly;
            t_t2_b3_g3.ReadOnly = lb_readOnly;
        }

        private Boolean UpdateBowlerSeries(int ai_bowlerNumber)
        {
            Boolean lb_isValid = true;
            int li_series = 0;
            int li_temp;
            string ls_series;
            string ls_handicap = "";
            string ls_game1 = "";
            string ls_game2 = "";
            string ls_game3 = "";

            if (ib_loading)
            {
                return true;
            }

            // get values to summarise
            switch (ai_bowlerNumber)
            {
                case 1:
                    ls_handicap = t_t1_b1_handicap.Text;
                    ls_game1 = t_t1_b1_g1.Text;
                    ls_game2 = t_t1_b1_g2.Text;
                    ls_game3 = t_t1_b1_g3.Text;
                    break;
                case 2:
                    ls_handicap = t_t1_b2_handicap.Text;
                    ls_game1 = t_t1_b2_g1.Text;
                    ls_game2 = t_t1_b2_g2.Text;
                    ls_game3 = t_t1_b2_g3.Text;
                    break;
                case 3:
                    ls_handicap = t_t1_b3_handicap.Text;
                    ls_game1 = t_t1_b3_g1.Text;
                    ls_game2 = t_t1_b3_g2.Text;
                    ls_game3 = t_t1_b3_g3.Text;
                    break;
                case 4:
                    ls_handicap = t_t2_b1_handicap.Text;
                    ls_game1 = t_t2_b1_g1.Text;
                    ls_game2 = t_t2_b1_g2.Text;
                    ls_game3 = t_t2_b1_g3.Text;
                    break;
                case 5:
                    ls_handicap = t_t2_b2_handicap.Text;
                    ls_game1 = t_t2_b2_g1.Text;
                    ls_game2 = t_t2_b2_g2.Text;
                    ls_game3 = t_t2_b2_g3.Text;
                    break;
                case 6:
                    ls_handicap = t_t2_b3_handicap.Text;
                    ls_game1 = t_t2_b3_g1.Text;
                    ls_game2 = t_t2_b3_g2.Text;
                    ls_game3 = t_t2_b3_g3.Text;
                    break;
            }

            // calculate the series total
            if (int.TryParse(ls_handicap, out li_temp))
            {
                if (   li_temp < 0 
                    || li_temp > ii_maxHandicap)
                {
                    MessageBox.Show(String.Format("Handicap must be between 0 and {0} inclusive.",ii_maxHandicap.ToString()), "Error", MessageBoxButtons.OK);
                    return false;
                }
                li_series = li_temp * 3;
            }
            else
            {
                if (string.IsNullOrEmpty(ls_handicap))
                {
                    MessageBox.Show("Handicap is required.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(String.Format("Handicap must be numeric and between 0 and {0} inclusive.", ii_maxHandicap.ToString()), "Error", MessageBoxButtons.OK);
                }
                return false;
            }

            if (int.TryParse(ls_game1, out li_temp))
            {
                if (   li_temp < 0
                    || li_temp > 300)
                {
                    MessageBox.Show("Game 1 must be between 0 and 300 inclusive.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                li_series = li_series + li_temp;
            }
            else
            {
                if (string.IsNullOrEmpty(ls_game1))
                {
                    MessageBox.Show("Game 1 is required.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Game 1 must be numeric and between 0 and 300 inclusive.", "Error", MessageBoxButtons.OK);
                }
                return false;
            }

            if (int.TryParse(ls_game2, out li_temp))
            {
                if (li_temp < 0
                    || li_temp > 300)
                {
                    MessageBox.Show("Game 2 must be between 0 and 300 inclusive.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                li_series = li_series + li_temp;
            }
            else
            {
                if (string.IsNullOrEmpty(ls_game2))
                {
                    MessageBox.Show("Game 2 is required.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Game 2 must be numeric and between 0 and 300 inclusive.", "Error", MessageBoxButtons.OK);
                }
                return false;
            }

            if (int.TryParse(ls_game3, out li_temp))
            {
                if (li_temp < 0
                    || li_temp > 300)
                {
                    MessageBox.Show("Game 3 must be between 0 and 300 inclusive.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                li_series = li_series + li_temp;
            }
            else
            {
                if (string.IsNullOrEmpty(ls_game3))
                {
                    MessageBox.Show("Game 3 is required.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Game 3 must be numeric and between 0 and 300 inclusive.", "Error", MessageBoxButtons.OK);
                }
                return false;
            }

            // display the series total and update the team totals
            ls_series = Convert.ToString(li_series);
            switch (ai_bowlerNumber)
            {
                case 1:
                    t_t1_b1_series.Text = ls_series;
                    UpdateTeamTotals(1);
                    break;
                case 2:
                    t_t1_b2_series.Text = ls_series;
                    UpdateTeamTotals(1);
                    break;
                case 3:
                    t_t1_b3_series.Text = ls_series;
                    UpdateTeamTotals(1);
                    break;
                case 4:
                    t_t2_b1_series.Text = ls_series;
                    UpdateTeamTotals(2);
                    break;
                case 5:
                    t_t2_b2_series.Text = ls_series;
                    UpdateTeamTotals(2);
                    break;
                case 6:
                    t_t2_b3_series.Text = ls_series;
                    UpdateTeamTotals(2);
                    break;
            }

            return lb_isValid;
        }

        private void t_t1_b1_handicap_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(1))
            {
                t_t1_b1_handicap.Focus();
            }
        }

        private void t_t1_b1_g1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b1_g1.Text))
            {
                t_t1_b1_g1.SelectionStart = 0;
                t_t1_b1_g1.SelectionLength = t_t1_b1_g1.Text.Length;
            }
        }

        private void t_t1_b1_g2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b1_g2.Text))
            {
                t_t1_b1_g2.SelectionStart = 0;
                t_t1_b1_g2.SelectionLength = t_t1_b1_g2.Text.Length;
            }
        }

        private void t_t1_b1_g3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b1_g3.Text))
            {
                t_t1_b1_g3.SelectionStart = 0;
                t_t1_b1_g3.SelectionLength = t_t1_b1_g3.Text.Length;
            }
        }

        private void t_t1_b1_g1_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(1))
            {
                t_t1_b1_g1.Focus();
            }
        }

        private void t_t1_b1_g2_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(1))
            {
                t_t1_b1_g2.Focus();
            }
        }

        private void t_t1_b1_g3_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(1))
            {
                t_t1_b1_g3.Focus();
            }
        }

        private void t_t1_b2_handicap_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(2))
            {
                t_t1_b2_handicap.Focus();
            }
        }

        private void t_t1_b2_g1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b2_g1.Text))
            {
                t_t1_b2_g1.SelectionStart = 0;
                t_t1_b2_g1.SelectionLength = t_t1_b2_g1.Text.Length;
            }
        }

        private void t_t1_b2_g2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b2_g2.Text))
            {
                t_t1_b2_g2.SelectionStart = 0;
                t_t1_b2_g2.SelectionLength = t_t1_b2_g2.Text.Length;
            }
        }

        private void t_t1_b2_g3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b2_g3.Text))
            {
                t_t1_b2_g3.SelectionStart = 0;
                t_t1_b2_g3.SelectionLength = t_t1_b2_g3.Text.Length;
            }
        }

        private void t_t1_b2_g1_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(2))
            {
                t_t1_b2_g1.Focus();
            }
        }

        private void t_t1_b2_g2_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(2))
            {
                t_t1_b2_g2.Focus();
            }
        }

        private void t_t1_b2_g3_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(2))
            {
                t_t1_b2_g3.Focus();
            }
        }

        private void t_t1_b3_handicap_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(3))
            {
                t_t1_b3_handicap.Focus();
            }
        }

        private void t_t1_b3_g1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b3_g1.Text))
            {
                t_t1_b3_g1.SelectionStart = 0;
                t_t1_b3_g1.SelectionLength = t_t1_b3_g1.Text.Length;
            }
        }

        private void t_t1_b3_g2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b3_g2.Text))
            {
                t_t1_b3_g2.SelectionStart = 0;
                t_t1_b3_g2.SelectionLength = t_t1_b3_g2.Text.Length;
            }
        }

        private void t_t1_b3_g3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t1_b3_g3.Text))
            {
                t_t1_b3_g3.SelectionStart = 0;
                t_t1_b3_g3.SelectionLength = t_t1_b3_g3.Text.Length;
            }
        }

        private void t_t1_b3_g1_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(3))
            {
                t_t1_b3_g1.Focus();
            }
        }

        private void t_t1_b3_g2_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(3))
            {
                t_t1_b3_g2.Focus();
            }
        }

        private void t_t1_b3_g3_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(3))
            {
                t_t1_b3_g3.Focus();
            }
        }

        private void t_t2_b1_handicap_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(4))
            {
                t_t2_b1_handicap.Focus();
            }
        }

        private void t_t2_b1_g1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b1_g1.Text))
            {
                t_t2_b1_g1.SelectionStart = 0;
                t_t2_b1_g1.SelectionLength = t_t2_b1_g1.Text.Length;
            }
        }

        private void t_t2_b1_g2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b1_g2.Text))
            {
                t_t2_b1_g2.SelectionStart = 0;
                t_t2_b1_g2.SelectionLength = t_t2_b1_g2.Text.Length;
            }
        }

        private void t_t2_b1_g3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b1_g3.Text))
            {
                t_t2_b1_g3.SelectionStart = 0;
                t_t2_b1_g3.SelectionLength = t_t2_b1_g3.Text.Length;
            }
        }

        private void t_t2_b1_g1_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(4))
            {
                t_t2_b1_g1.Focus();
            }
        }

        private void t_t2_b1_g2_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(4))
            {
                t_t2_b1_g2.Focus();
            }
        }

        private void t_t2_b1_g3_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(4))
            {
                t_t2_b1_g3.Focus();
            }
        }

        private void t_t2_b2_handicap_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(5))
            {
                t_t2_b2_handicap.Focus();
            }
        }

        private void t_t2_b2_g1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b2_g1.Text))
            {
                t_t2_b2_g1.SelectionStart = 0;
                t_t2_b2_g1.SelectionLength = t_t2_b2_g1.Text.Length;
            }
        }

        private void t_t2_b2_g2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b2_g2.Text))
            {
                t_t2_b2_g2.SelectionStart = 0;
                t_t2_b2_g2.SelectionLength = t_t2_b2_g2.Text.Length;
            }
        }

        private void t_t2_b2_g3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b2_g3.Text))
            {
                t_t2_b2_g3.SelectionStart = 0;
                t_t2_b2_g3.SelectionLength = t_t2_b2_g3.Text.Length;
            }
        }

        private void t_t2_b2_g1_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(5))
            {
                t_t2_b2_g1.Focus();
            }
        }

        private void t_t2_b2_g2_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(5))
            {
                t_t2_b2_g2.Focus();
            }
        }

        private void t_t2_b2_g3_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(5))
            {
                t_t2_b2_g3.Focus();
            }
        }

        private void t_t2_b3_handicap_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(6))
            {
                t_t2_b3_handicap.Focus();
            }
        }

        private void t_t2_b3_g1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b3_g1.Text))
            {
                t_t2_b3_g1.SelectionStart = 0;
                t_t2_b3_g1.SelectionLength = t_t2_b3_g1.Text.Length;
            }
        }

        private void t_t2_b3_g2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b3_g2.Text))
            {
                t_t2_b3_g2.SelectionStart = 0;
                t_t2_b3_g2.SelectionLength = t_t2_b3_g2.Text.Length;
            }
        }

        private void t_t2_b3_g3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(t_t2_b3_g3.Text))
            {
                t_t2_b3_g3.SelectionStart = 0;
                t_t2_b3_g3.SelectionLength = t_t2_b3_g3.Text.Length;
            }
        }

        private void t_t2_b3_g1_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(6))
            {
                t_t2_b3_g1.Focus();
            }
        }

        private void t_t2_b3_g2_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(6))
            {
                t_t2_b3_g2.Focus();
            }
        }

        private void t_t2_b3_g3_TextChanged(object sender, EventArgs e)
        {
            if (!UpdateBowlerSeries(6))
            {
                t_t2_b3_g3.Focus();
            }
        }

        private Boolean InsertScoresheets()
        {
            List<string> ls_Statement = new List<string>();
            string ls_temp;
            Array la_sql;

            int li_t1_game1 = 0;
            int li_t1_game2 = 0;
            int li_t1_game3 = 0;
            int li_t1_series = 0;
            int li_t1_points_g1 = 0;
            int li_t1_points_g2 = 0;
            int li_t1_points_g3 = 0;
            int li_t1_points_series = 0;
            string ls_t1_legal = "Y";
            int li_t2_game1 = 0;
            int li_t2_game2 = 0;
            int li_t2_game3 = 0;
            int li_t2_series = 0;
            int li_t2_points_g1 = 0;
            int li_t2_points_g2 = 0;
            int li_t2_points_g3 = 0;
            int li_t2_points_series = 0;
            string ls_t2_legal = "Y";
            string ls_blind = "N";

            // ensure that there is something to process
            if (   !UpdateBowlerSeries(1)
                || !UpdateBowlerSeries(2)
                || !UpdateBowlerSeries(3)
                || !UpdateBowlerSeries(4)
                || !UpdateBowlerSeries(5)
                || !UpdateBowlerSeries(6))
            {
                return false;
            }

            // get data to compare
            int.TryParse(t_t1_g1.Text, out li_t1_game1);
            int.TryParse(t_t1_g2.Text, out li_t1_game2);
            int.TryParse(t_t1_g3.Text, out li_t1_game3);
            int.TryParse(t_t1_series.Text, out li_t1_series);

            int.TryParse(t_t2_g1.Text, out li_t2_game1);
            int.TryParse(t_t2_g2.Text, out li_t2_game2);
            int.TryParse(t_t2_g3.Text, out li_t2_game3);
            int.TryParse(t_t2_series.Text, out li_t2_series);

            // calculate the points for each team
            if (li_t1_game1 > li_t2_game1)
            {
                li_t1_points_g1 = 2;
                li_t2_points_g1 = 0;
            }
            else if (li_t1_game1 == li_t2_game1)
            {
                li_t1_points_g1 = 1;
                li_t2_points_g1 = 1;
            }
            else
            {
                li_t1_points_g1 = 0;
                li_t2_points_g1 = 2;
            }

            if (li_t1_game2 > li_t2_game2)
            {
                li_t1_points_g2 = 2;
                li_t2_points_g2 = 0;
            }
            else if (li_t1_game2 == li_t2_game2)
            {
                li_t1_points_g2 = 1;
                li_t2_points_g2 = 1;
            }
            else
            {
                li_t1_points_g2 = 0;
                li_t2_points_g2 = 2;
            }

            if (li_t1_game3 > li_t2_game3)
            {
                li_t1_points_g3 = 2;
                li_t2_points_g3 = 0;
            }
            else if (li_t1_game3 == li_t2_game3)
            {
                li_t1_points_g3 = 1;
                li_t2_points_g3 = 1;
            }
            else
            {
                li_t1_points_g3 = 0;
                li_t2_points_g3 = 2;
            }

            if (li_t1_series > li_t2_series)
            {
                li_t1_points_series = 2;
                li_t2_points_series = 0;
            }
            else if (li_t1_series == li_t2_series)
            {
                li_t1_points_series = 1;
                li_t2_points_series = 1;
            }
            else
            {
                li_t1_points_series = 0;
                li_t2_points_series = 2;
            }

            // deduct points from team if not legal lineup - ie at least 1 bowler without a blind
            if (!cb_t1_legal.Checked)
            {
                li_t1_points_g1 = 0;
                li_t1_points_g2 = 0;
                li_t1_points_g3 = 0;
                li_t1_points_series = 0;

                ls_t1_legal = "N";
            }
            if (!cb_t2_legal.Checked)
            {
                li_t2_points_g1 = 0;
                li_t2_points_g2 = 0;
                li_t2_points_g3 = 0;
                li_t2_points_series = 0;

                ls_t2_legal = "N";
            }

            // build the sql statements to be applied in a single transaction 
            // Team 1 
            ls_temp = string.Concat("insert into hba_draw (week_id, pairing, team_id, lane, game_1, game_2, game_3, series, bonus, legal_lineup) values (",
                                    is_default_week_id, ", ",
                                    t_pairing.Text, ", ",
                                    dd_team1.SelectedValue.ToString(), ", ",
                                    t_t1_lane.Text, ", ",
                                    Convert.ToString(li_t1_points_g1), ", ",
                                    Convert.ToString(li_t1_points_g2), ", ",
                                    Convert.ToString(li_t1_points_g3), ", ",
                                    Convert.ToString(li_t1_points_series), ", ",
                                    t_t1_bonuses.Text, ", ",
                                    "'", ls_t1_legal, "' ",
                                    ");");
            ls_Statement.Add(ls_temp);

            if (cb_t1_b1_blind.Checked == true)
            {
                ls_blind = "Y";
            }
            else
            {
                ls_blind = "N";
            }
            ls_temp = string.Concat("insert into hba_score_sheet (draw_id, bowler_id, blind_score, handicap, game_1, game_2, game_3) ",
                                    "select  max(d.id) ",
                                    "       ,", dd_t1_b1_id.SelectedValue.ToString(), 
                                    "       ,'",ls_blind, "' ",
                                    "       ,", t_t1_b1_handicap.Text,
                                    "       ,", t_t1_b1_g1.Text,
                                    "       ,", t_t1_b1_g2.Text,
                                    "       ,", t_t1_b1_g3.Text,
                                    " from   hba_draw d ",
                                    ";");
            ls_Statement.Add(ls_temp);

            if (cb_t1_b2_blind.Checked == true)
            {
                ls_blind = "Y";
            }
            else
            {
                ls_blind = "N";
            }
            ls_temp = string.Concat("insert into hba_score_sheet (draw_id, bowler_id, blind_score, handicap, game_1, game_2, game_3) ",
                                    "select  max(d.id) ",
                                    "       ,", dd_t1_b2_id.SelectedValue.ToString(),
                                    "       ,'", ls_blind, "' ",
                                    "       ,", t_t1_b2_handicap.Text,
                                    "       ,", t_t1_b2_g1.Text, 
                                    "       ,", t_t1_b2_g2.Text, 
                                    "       ,", t_t1_b2_g3.Text,
                                    " from   hba_draw d ",
                                    ";");
            ls_Statement.Add(ls_temp);

            if (ii_teamSize == 3)
            {
                if (cb_t1_b3_blind.Checked == true)
                {
                    ls_blind = "Y";
                }
                else
                {
                    ls_blind = "N";
                }
                ls_temp = string.Concat("insert into hba_score_sheet (draw_id, bowler_id, blind_score, handicap, game_1, game_2, game_3) ",
                                        "select  max(d.id) ",
                                        "       ,", dd_t1_b3_id.SelectedValue.ToString(),
                                        "       ,'", ls_blind, "' ",
                                        "       ,", t_t1_b3_handicap.Text,
                                        "       ,", t_t1_b3_g1.Text,
                                        "       ,", t_t1_b3_g2.Text,
                                        "       ,", t_t1_b3_g3.Text,
                                        " from   hba_draw d ",
                                        ";");
                ls_Statement.Add(ls_temp);
            }

            // Team 2
            ls_temp = string.Concat("insert into hba_draw (week_id, pairing, team_id, lane, game_1, game_2, game_3, series, bonus, legal_lineup) values (",
                                    is_default_week_id, ", ",
                                    t_pairing.Text, ", ",
                                    dd_team2.SelectedValue.ToString(), ", ",
                                    t_t2_lane.Text, ", ",
                                    Convert.ToString(li_t2_points_g1), ", ",
                                    Convert.ToString(li_t2_points_g2), ", ",
                                    Convert.ToString(li_t2_points_g3), ", ",
                                    Convert.ToString(li_t2_points_series), ", ",
                                    t_t2_bonuses.Text, ", ",
                                    "'", ls_t2_legal, "' ",
                                    ");");
            ls_Statement.Add(ls_temp);

            if (cb_t2_b1_blind.Checked == true)
            {
                ls_blind = "Y";
            }
            else
            {
                ls_blind = "N";
            }
            ls_temp = string.Concat("insert into hba_score_sheet (draw_id, bowler_id, blind_score, handicap, game_1, game_2, game_3) ",
                                    "select  max(d.id) ",
                                    "       ,", dd_t2_b1_id.SelectedValue.ToString(),
                                    "       ,'", ls_blind, "' ",
                                    "       ,", t_t2_b1_handicap.Text,
                                    "       ,", t_t2_b1_g1.Text,
                                    "       ,", t_t2_b1_g2.Text,
                                    "       ,", t_t2_b1_g3.Text,
                                    " from   hba_draw d ",
                                    ";");
            ls_Statement.Add(ls_temp);

            if (cb_t2_b2_blind.Checked == true)
            {
                ls_blind = "Y";
            }
            else
            {
                ls_blind = "N";
            }
            ls_temp = string.Concat("insert into hba_score_sheet (draw_id, bowler_id, blind_score, handicap, game_1, game_2, game_3) ",
                                    "select  max(d.id) ",
                                    "       ,", dd_t2_b2_id.SelectedValue.ToString(),
                                    "       ,'", ls_blind, "' ",
                                    "       ,", t_t2_b2_handicap.Text,
                                    "       ,", t_t2_b2_g1.Text,
                                    "       ,", t_t2_b2_g2.Text,
                                    "       ,", t_t2_b2_g3.Text,
                                    " from   hba_draw d ",
                                    ";");
            ls_Statement.Add(ls_temp);

            if (ii_teamSize == 3)
            {
                if (cb_t2_b3_blind.Checked == true)
                {
                    ls_blind = "Y";
                }
                else
                {
                    ls_blind = "N";
                }
                ls_temp = string.Concat("insert into hba_score_sheet (draw_id, bowler_id, blind_score, handicap, game_1, game_2, game_3) ",
                                        "select  max(d.id) ",
                                        "       ,", dd_t2_b3_id.SelectedValue.ToString(),
                                        "       ,'", ls_blind, "' ",
                                        "       ,", t_t2_b3_handicap.Text,
                                        "       ,", t_t2_b3_g1.Text,
                                        "       ,", t_t2_b3_g2.Text,
                                        "       ,", t_t2_b3_g3.Text,
                                        " from   hba_draw d ",
                                        ";");
                ls_Statement.Add(ls_temp);
            }

            // turn List into StringArray
            la_sql = ls_Statement.ToArray();

            return LeagueDB.ExecuteSqlTransaction("Scoresheets", la_sql);
        }

        private void b_saveNext_Click(object sender, EventArgs e)
        {
            if (InsertScoresheets())
            {
                SetupNewRecord();
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (InsertScoresheets())
            {
                ib_closing = true;
                Close();
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ib_closing = true;
            Close();
        }

    }
}
