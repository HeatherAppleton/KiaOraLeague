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
    public partial class frmTeam : Form
    {
        private DBConnection  LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;


        public frmTeam()
        {
            InitializeComponent();
        }

        private void frmTeam_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string    ls_sql;
            DataTable ldt_data;
            string ls_id;


            ls_sql = string.Concat("select  id "
                                  ,"       ,team_name"
                                  ,"       ,round_winner "
                                  ,"       ,active_flag "
                                  ,"from   hba_team "
                                  ,"order by active_flag desc, team_name"
                                  );
            ldt_data = LeagueDB.PopulateGridView(ls_sql);
            dgvTeam.DataSource = ldt_data;

            foreach (DataGridViewRow row in dgvTeam.Rows)
            {
                ls_id = row.Cells[0].Value.ToString();

                if (   ls_id == "1"
                    || ls_id == "101"
                   )
                {
                    row.ReadOnly = true;
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }

        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            string ls_sql;
            string ls_id = "";

            if (!IsTeamNameValid(t_teamName.Text, ls_id))
            {
                return;
            }

            ls_sql = string.Concat("insert into hba_team (team_name, round_winner, active_flag ) ",
                                   "values ('", t_teamName.Text, "', 0, 'Y');"
                                  );
            if (LeagueDB.ExecNonQuery(ls_sql) == 1)
            {
                MessageBox.Show("Team Name recorded successfully.", "Information", MessageBoxButtons.OK);

                t_teamName.Text = "";
                GetData();
            }
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            Int32 li_row;
            string ls_id;
            string ls_team_name;
            string ls_active_flag;
            string ls_round_winner;
            string ls_sql;

            li_row = dgvTeam.CurrentCell.RowIndex;

            ls_id = dgvTeam.Rows[li_row].Cells[0].Value.ToString();
            ls_team_name = dgvTeam.Rows[li_row].Cells[1].Value.ToString();
            ls_round_winner = dgvTeam.Rows[li_row].Cells[2].Value.ToString();
            ls_active_flag = dgvTeam.Rows[li_row].Cells[3].Value.ToString();

            if (!IsTeamNameValid(ls_team_name, ls_id))
            {
                return;
            }

            if (string.IsNullOrEmpty(ls_round_winner))
            {
                MessageBox.Show("Round Winner is required - must be 0, 1, 2, 3 or 4.", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (   ls_round_winner != "0"
                     && ls_round_winner != "1"
                     && ls_round_winner != "2"
                     && ls_round_winner != "3"
                     && ls_round_winner != "4"
                    )
            {
                MessageBox.Show("Round Winner must be 0, 1, 2, 3 or 4.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(ls_active_flag))
            {
                MessageBox.Show("Active is required and must be Y or N.", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (   ls_active_flag != "Y"
                     && ls_active_flag != "N")
            {
                MessageBox.Show("Active must be Y or N.", "Error", MessageBoxButtons.OK);
                return;
            }

            ls_sql = string.Concat("update hba_team "
                                  ,"set team_name    = '", ls_team_name, "', "
                                  ,"    round_winner = ", ls_round_winner, ", "
                                  ,"    active_flag  = '", ls_active_flag, "' "
                                  ,"where id = ", ls_id
                                  );
            if (LeagueDB.ExecNonQuery(ls_sql) == 1)
            {
                MessageBox.Show("Team updated successfully.", "Information", MessageBoxButtons.OK);
            }

        }

        private Boolean IsTeamNameValid(string as_TeamName, string as_TeamId)
        {
            string ls_sql;
            Boolean lb_return = true;

            if (string.IsNullOrEmpty(as_TeamName))
            {
                MessageBox.Show("Please enter the Team Name.", "Error", MessageBoxButtons.OK);
                return false;
            }

            ls_sql = string.Concat("select count(*) as counter from hba_team where team_name = '", as_TeamName, "'");
            if (!string.IsNullOrEmpty(as_TeamId))
            {
                ls_sql = string.Concat(ls_sql,
                                       " and id != ", as_TeamId);
            }
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    if (isdr_data[0].ToString() != "0")
                    {
                        MessageBox.Show("Team Name must be unique and is already in use.", "Error", MessageBoxButtons.OK);
                        lb_return = false;
                    }
                }

                isdr_data.Close();
            }

            return lb_return;
        }

        private void b_ClearWinners_Click(object sender, EventArgs e)
        {
            string ls_sql;

            ls_sql = string.Concat("update hba_team set round_winner = 0 where round_winner != 0");
            LeagueDB.ExecNonQuery(ls_sql);

            GetData();

            MessageBox.Show("All Round Winner values have been reset","Information",MessageBoxButtons.OK);
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
