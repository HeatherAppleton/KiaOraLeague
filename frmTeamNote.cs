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
    public partial class frmTeamNote : Form
    {
        private DBConnection LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;

        public frmTeamNote()
        {
            InitializeComponent();
        }

        private void frmTeamNote_Load(object sender, EventArgs e)
        {
            this.hba_teamTableAdapter.Fill(this.vActiveTeam.hba_team);
            GetData();
            ClearData();
        }

        private void GetData()
        {
            this.vTeamNoteTableAdapter.Fill(this.vTeamNote._vTeamNote);
        }

        private void ClearData()
        {
            DateTime ldt_Today = DateTime.Now;
            t_Season.Text = ldt_Today.ToString("yyyy");
            cb_Team.SelectedValue = 0;
            t_Rank.Text = "";
            t_Note.Text = "";

            cb_Team.Focus();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 li_row = dgvTeam.CurrentCell.RowIndex;

            t_Season.Text = dgvTeam.Rows[li_row].Cells[0].Value.ToString();
            cb_Team.Text = dgvTeam.Rows[li_row].Cells[1].Value.ToString();
            t_Rank.Text = dgvTeam.Rows[li_row].Cells[2].Value.ToString();
            t_Note.Text = dgvTeam.Rows[li_row].Cells[3].Value.ToString();
        }

        private void b_Update_Click(object sender, EventArgs e)
        {
            Int32 li_row = dgvTeam.CurrentCell.RowIndex;
            string ls_sql;

            ls_sql = string.Concat("update hba_team_note ",
                                   "set  team_id = ", cb_Team.SelectedValue.ToString(),
                                   "    ,rank = ", t_Rank.Text,
                                   "    ,note = '", t_Note.Text, "' ",
                                   "where id = ", dgvTeam.Rows[li_row].Cells[4].Value.ToString());
            LeagueDB.ExecNonQuery(ls_sql);
            GetData();
            ClearData();
        }

        private void b_Insert_Click(object sender, EventArgs e)
        {
            string ls_sql;

            ls_sql = string.Format("insert into hba_team_note(season, team_id, rank, note) values ({0}, {1}, {2}, '{3}')",
                                   t_Season.Text, 
                                   cb_Team.SelectedValue.ToString(), 
                                   t_Rank.Text, 
                                   t_Note.Text);
            LeagueDB.ExecNonQuery(ls_sql);
            GetData();
            ClearData();

        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ls_sql;

            if (cb_Team.SelectedIndex < 0)
            {
                return;
            }

            ls_sql = string.Concat("select  count(*) +1 as rank ",
                                    "from   hba_team_note tn ",
                                    "where  tn.season = ", t_Season.Text, " ",
                                    "and    tn.team_id = ", cb_Team.SelectedValue.ToString());
            isdr_data = LeagueDB.ExecQuery(ls_sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    t_Rank.Text = isdr_data[0].ToString();
                }
            }

            isdr_data.Close();

            t_Note.Focus();
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            string ls_message = "Are you sure?";
            string ls_sql = "";
            Int32 li_row = dgvTeam.CurrentCell.RowIndex;

            ls_message = string.Concat("About to delete",
                                        "\n\tSeason: ", dgvTeam.Rows[li_row].Cells[0].Value.ToString(),
                                        "\n\tTeam: ", dgvTeam.Rows[li_row].Cells[1].Value.ToString(),
                                        "\n\tRank: ", dgvTeam.Rows[li_row].Cells[2].Value.ToString(),
                                        "\n\tNote: ", dgvTeam.Rows[li_row].Cells[3].Value.ToString(),
                                        "\n\nAre you sure?");

            DialogResult dr = MessageBox.Show(ls_message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                ls_sql = string.Concat("delete from hba_team_note where id = ", dgvTeam.Rows[li_row].Cells[4].Value.ToString());
                LeagueDB.ExecNonQuery(ls_sql);

                GetData();
                ClearData();
            }
        }
    }
}
