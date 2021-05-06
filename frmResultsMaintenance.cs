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
    public partial class frmResultsMaintenance : Form
    {
        private DBConnection LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;


        private DataTable idtbl_Draw = new DataTable();
        private DataTable idtbl_Scoresheet = new DataTable();


        private string is_drawIds = "";
        private string is_applyBonus = "";
        private int ii_teamSize = 2;

        private frmDrawView FrmDrawView;


        public frmResultsMaintenance(frmDrawView frmDrawView)
        {
            this.FrmDrawView = frmDrawView;
            InitializeComponent();
        }

        private void frmResultsMaintenance_Load(object sender, EventArgs e)
        {
            string ls_sql;

            ls_sql = String.Format("select upper(left(settingValue,1)) from hba_config where settingName = '{0}'", "ApplyBonus");
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    is_applyBonus = isdr_data[0].ToString();
                }
            }
            isdr_data.Close();

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
            else if (ii_teamSize > 3)
            {
                ii_teamSize = 3;
            }

            isdr_data.Close();
        }

        public void DisplayResults(string as_drawId)
        {
            GetTeamDetails(as_drawId);
            GetBowlerDetails();

            dgvDraw.DataSource = idtbl_Draw;
            dgvScoresheet.DataSource = idtbl_Scoresheet;

            FormatDataGrids();
        }

        private void GetTeamDetails(string as_drawId)
        {
            string ls_sql;

            is_drawIds = "";
            ls_sql = string.Concat("select  cast(d.id as varchar) ",
                "from   hba_draw d ",
                "join   (select  d.week_id, ",
                "                d.pairing ",
                "        from   hba_draw d ",
                "        where  d.id = ", as_drawId,
                "	   ) ds  on d.week_id = ds.week_id ",
                "           and d.pairing = ds.pairing ",
                "order by 1 ");
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    if (string.IsNullOrEmpty(is_drawIds))
                    {
                        is_drawIds = "(";
                    }
                    else
                    {
                        is_drawIds += ", ";
                    }
                    is_drawIds += isdr_data.GetString(0);
                }
                is_drawIds += ")";
            }
            isdr_data.Close();

            ls_sql = string.Concat("SELECT     d.id, w.week_date, d.lane, t.team_name, d.legal_lineup, ",
                                   "           d.game_1, d.game_2, d.game_3, d.series, d.bonus, d.calculated_total, ",
                                   "           SUM(s.game_1 + s.handicap) AS score_game1, ",
                                   "           SUM(s.game_2 + s.handicap) AS score_game2, ",
                                   "           SUM(s.game_3 + s.handicap) AS score_game3, ",
                                   "           SUM(s.handicap * 3 + s.game_1 + s.game_2 + s.game_3) AS score_series ",
                                   "FROM       hba_draw AS d ",
                                   "INNER JOIN hba_week AS w ON w.id = d.week_id ",
                                   "INNER JOIN hba_team AS t ON t.id = d.team_id ",
                                   "INNER JOIN hba_score_sheet AS s ON d.id = s.draw_id ",
                                   "WHERE      d.id in ", is_drawIds, " ",
                                   "GROUP BY   d.id, w.week_date, d.lane, t.team_name, d.legal_lineup, ",
                                   "           d.game_1, d.game_2, d.game_3, d.series, d.bonus, d.calculated_total ", 
                                   "ORDER BY   d.lane");
            idtbl_Draw = LeagueDB.PopulateGridView(ls_sql);
         }

        private void GetBowlerDetails()
        {
            string ls_sql;

            ls_sql = string.Concat("select  b.Bowler_Name as Bowler ",
                                   "       ,s.blind_Score as Blind ",
                                   "       ,s.Handicap ",
                                   "       ,s.Game_1 ",
                                   "       ,s.Game_2 ",
                                   "       ,s.Game_3 ",
                                   "       ,s.Handicap * 3 + s.Game_1 + s.Game_2 + s.Game_3 as Series ",
                                   "       ,s.id ",
                                   "       ,s.draw_id ",
                                   "       ,s.bowler_id ",
                                   "from   hba_Score_sheet s ",
                                   "join   hba_bowler b on b.id = s.bowler_id ",
                                   "where  s.draw_id in ", is_drawIds, " ",
                                   "order by s.draw_id, b.position ");
            idtbl_Scoresheet = LeagueDB.PopulateGridView(ls_sql);
        }

        private void FormatDataGrids()
        {
            dgvDraw.DefaultCellStyle.BackColor = SystemColors.Control;
            dgvDraw.DefaultCellStyle.ForeColor = SystemColors.GrayText;
            dgvDraw.DefaultCellStyle.SelectionBackColor = SystemColors.Control;
            dgvDraw.DefaultCellStyle.SelectionForeColor = SystemColors.GrayText;
            dgvDraw.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dgvDraw.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
            dgvDraw.ReadOnly = true;
            dgvDraw.Columns[0].Visible = false;        // id
            dgvDraw.Columns[1].HeaderText  = "Week";
            dgvDraw.Columns[2].HeaderText  = "Lane";
            dgvDraw.Columns[3].HeaderText  = "Team";
            dgvDraw.Columns[4].HeaderText  = "Legal";
            dgvDraw.Columns[5].HeaderText  = "Game 1";
            dgvDraw.Columns[6].HeaderText  = "Game 2";
            dgvDraw.Columns[7].HeaderText  = "Game 3";
            dgvDraw.Columns[8].HeaderText  = "Series";
            dgvDraw.Columns[9].HeaderText  = "Bonus";
            dgvDraw.Columns[10].HeaderText = "Total";
            dgvDraw.Columns[11].HeaderText = "Score Game1";
            dgvDraw.Columns[12].HeaderText = "Score Game2";
            dgvDraw.Columns[13].HeaderText = "Score Game3";
            dgvDraw.Columns[14].HeaderText = "Score Series";

            for (int i = 0; i <= 6; i++)
            {
                if (i >= 3 && i <= 5)
                {
                    continue;
                }
                dgvScoresheet.Columns[i].ReadOnly = true;
                dgvScoresheet.Columns[i].DefaultCellStyle.BackColor = SystemColors.Control;
                dgvScoresheet.Columns[i].DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgvScoresheet.Columns[i].DefaultCellStyle.SelectionBackColor = SystemColors.Control;
                dgvScoresheet.Columns[i].DefaultCellStyle.SelectionForeColor = SystemColors.GrayText;
            }

            dgvScoresheet.Columns[7].Visible = false;        // id
            dgvScoresheet.Columns[8].Visible = false;        // draw_id
            dgvScoresheet.Columns[9].Visible = false;        // bowler_id
            dgvScoresheet.Columns[3].HeaderText = "Game 1";
            dgvScoresheet.Columns[4].HeaderText = "Game 2";
            dgvScoresheet.Columns[5].HeaderText = "Game 3";

            dgvScoresheet.Focus();
            dgvScoresheet.CurrentCell = dgvScoresheet.Rows[0].Cells[3];
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvScoresheet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int li_row  = dgvScoresheet.CurrentCell.RowIndex;

            int li_handicap;
            int li_game;
            int li_series;

            int li_teamGame = 0;
            int li_teamGame1 = 0;
            int li_teamGame2 = 0;
            int li_teamGame3 = 0;
            int li_teamSeries = 0;
            int li_teamBonus = 0;
            int li_teamPoints = 0;
            int li_teamTotal = 0;

            int li_oppositionBonus = 0;
            int li_oppositionScore = 0;
            int li_oppositionPoints = 0;
            int li_oppositionTotal = 0;

            string ls_columnName;

            DataRow ldtRow_bowler  = idtbl_Scoresheet.Rows[0];

            DataRow ldtRow_team = idtbl_Draw.Rows[0];
            DataRow ldtRow_opposition = idtbl_Draw.Rows[1];

            // flip team rows if the bowler being edited is for the 2nd team
            if (li_row > ii_teamSize - 1)
            {
                ldtRow_team = idtbl_Draw.Rows[1];
                ldtRow_opposition = idtbl_Draw.Rows[0];
            }

            // calculate new scores for the team being edited
            li_series = 0;
            for (int i = 1; i <= 3; i++)
            {
                ls_columnName = "Game_" + i.ToString();

                if (li_row <= ii_teamSize - 1)
                {
                    for (int j = 0; j < ii_teamSize; j++)
                    {
                        ldtRow_bowler = idtbl_Scoresheet.Rows[j];
                        int.TryParse(ldtRow_bowler["Handicap"].ToString(), out li_handicap);
                        int.TryParse(ldtRow_bowler[ls_columnName].ToString(), out li_game);

                        li_game += li_handicap;
                        li_teamGame += li_game;

                        if (j == li_row)
                        {
                            li_series += li_game;
                        }
                    }
                }
                else
                {
                    for (int j = ii_teamSize; j < idtbl_Scoresheet.Rows.Count; j++)
                    {
                        ldtRow_bowler = idtbl_Scoresheet.Rows[j];
                        int.TryParse(ldtRow_bowler["Handicap"].ToString(), out li_handicap);
                        int.TryParse(ldtRow_bowler[ls_columnName].ToString(), out li_game);

                        li_game += li_handicap;
                        li_teamGame += li_game;

                        if (j == li_row)
                        {
                            li_series += li_game;
                        }
                    }
                }

                switch (ls_columnName)
                {
                    case "Game_1":
                        li_teamGame1 = li_teamGame;
                        break;

                    case "Game_2":
                        li_teamGame2 = li_teamGame;
                        break;

                    case "Game_3":
                        li_teamGame3 = li_teamGame;
                        break;
                }
                li_teamGame = 0;
            }
            ldtRow_bowler = idtbl_Scoresheet.Rows[li_row];
            ldtRow_bowler["Series"] = li_series;


            li_teamSeries = li_teamGame1 + li_teamGame2 + li_teamGame3;

            ldtRow_team["score_game1"] = li_teamGame1;
            ldtRow_team["score_game2"] = li_teamGame2;
            ldtRow_team["score_game3"] = li_teamGame3;
            ldtRow_team["score_series"] = li_teamSeries;


            if (string.Equals(is_applyBonus, "Y"))
            {
                li_teamBonus = 0;
                if (li_row < ii_teamSize)
                {
                    for (int j = 0; j < ii_teamSize; j++)
                    {
                        ldtRow_bowler = idtbl_Scoresheet.Rows[j];
                        int.TryParse(ldtRow_bowler["Series"].ToString(), out li_series);
                        if (li_series >= 600)
                        {
                            li_teamBonus++;
                        }
                    }
                }
                else
                {
                    for (int j = ii_teamSize - 1; j < idtbl_Scoresheet.Rows.Count; j++)
                    {
                        ldtRow_bowler = idtbl_Scoresheet.Rows[j];
                        int.TryParse(ldtRow_bowler["Series"].ToString(), out li_series);
                        if (li_series >= 600)
                        {
                            li_teamBonus++;
                        }
                    }
                }
                ldtRow_team["bonus"] = li_teamBonus;
            }

            // calculate the new points for each team
            li_teamTotal = 0;
            li_oppositionTotal = 0;
            for (int i = 1; i <= 4; i++)
            {
                if (i < 4)
                {
                    ls_columnName = "score_game" + i.ToString();
                }
                else
                {
                    ls_columnName = "score_series";
                }
                int.TryParse(ldtRow_team[ls_columnName].ToString(), out li_teamGame);
                int.TryParse(ldtRow_opposition[ls_columnName].ToString(), out li_oppositionScore);

                li_oppositionPoints = 0;
                li_teamPoints = 0;
                if (li_teamGame == li_oppositionScore)
                {
                    li_teamPoints = 1;
                    li_oppositionPoints = 1;
                }
                else if (li_teamGame > li_oppositionScore)
                {
                    li_teamPoints = 2;
                }
                else
                {
                    li_oppositionPoints = 2;
                }

                if (string.Equals(ldtRow_team["legal_lineup"].ToString(), "N"))
                {
                    li_teamPoints = 0;
                }
                if (string.Equals(ldtRow_opposition["legal_lineup"].ToString(), "N"))
                {
                    li_oppositionPoints = 0;
                }

                if (i == 4)
                {
                    ls_columnName = "series";
                }
                else
                {
                    ls_columnName = "game_" + i.ToString();
                }
                ldtRow_team[ls_columnName] = li_teamPoints;
                ldtRow_opposition[ls_columnName] = li_oppositionPoints;

                li_teamTotal += li_teamPoints;
                li_oppositionTotal += li_oppositionPoints;
            }
            ldtRow_team["total"] = li_teamTotal + li_teamBonus;

            int.TryParse(ldtRow_opposition["bonus"].ToString(), out li_oppositionBonus);
            ldtRow_opposition["total"] = li_oppositionTotal + li_oppositionBonus;
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            DataRow ldtRow_team;
            DataRow ldtRow_bowler;
            string ls_sql;

            for (int i = 0; i < idtbl_Draw.Rows.Count; i++)
            {
                ldtRow_team = idtbl_Draw.Rows[i];
                ls_sql = string.Concat("update hba_draw ",
                                       "set  game_1 = ", ldtRow_team["game_1"].ToString(),
                                       "    ,game_2 = ", ldtRow_team["game_2"].ToString(),
                                       "    ,game_3 = ", ldtRow_team["game_3"].ToString(),
                                       "    ,series = ", ldtRow_team["series"].ToString(),
                                       "    ,bonus = ",  ldtRow_team["bonus"].ToString(), " ",
                                       "where id = ",    ldtRow_team["id"].ToString());
                LeagueDB.ExecNonQuery(ls_sql);
            }

            for (int i = 0; i < idtbl_Scoresheet.Rows.Count; i++)
            {
                ldtRow_bowler = idtbl_Scoresheet.Rows[i];
                ls_sql = string.Concat("update hba_score_sheet ",
                                       "set  game_1 = ", ldtRow_bowler["Game_1"].ToString(),
                                       "    ,game_2 = ", ldtRow_bowler["Game_2"].ToString(),
                                       "    ,game_3 = ", ldtRow_bowler["Game_3"].ToString(), " ",
                                       "where id = ",    ldtRow_bowler["id"].ToString());
                LeagueDB.ExecNonQuery(ls_sql);
            }

            FrmDrawView.RefreshData();

            MessageBox.Show("Scoresheets successfully updated.", "Information", MessageBoxButtons.OK);
        }

        private void b_deletePairing_Click(object sender, EventArgs e)
        {
            List<string> ls_Statement = new List<string>();
            string ls_temp = "delete from hba_averages where score_sheet_id in (";
            Array la_sql;

            DataRow ldtRow_scoresheet = idtbl_Scoresheet.Rows[0];

            DialogResult result = MessageBox.Show("Are you sure you wish to delete this paring?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                // delete scoresheet references in Handicap Averages table first 
                for (int i = 0; i < idtbl_Scoresheet.Rows.Count; i++)
                {
                    ldtRow_scoresheet = idtbl_Scoresheet.Rows[i];
                    ls_temp += ldtRow_scoresheet["id"];
                    if (i < idtbl_Scoresheet.Rows.Count - 1)
                    {
                        ls_temp += ", ";
                    }
                }
                ls_temp += ");";
                ls_Statement.Add(ls_temp);

                // then remove the Scoresheets
                ls_temp = string.Concat("delete from hba_score_sheet where draw_id in "
                                       , is_drawIds
                                       , ";");
                ls_Statement.Add(ls_temp);

                // and remove draw records
                ls_temp = string.Concat("delete from hba_draw where Id in "
                                       , is_drawIds 
                                       , ";");
                ls_Statement.Add(ls_temp);


                // turn List into StringArray
                la_sql = ls_Statement.ToArray();

                if (LeagueDB.ExecuteSqlTransaction("DeletePairing", la_sql))
                {
                    FrmDrawView.RefreshData();
                    Close();
                }
            }
        }

    }
}
