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
    public partial class frmBowlerNote : Form
    {
        private DBConnection LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;
        
        public frmBowlerNote()
        {
            InitializeComponent();
        }

        private void frmBowlerNote_Load(object sender, EventArgs e)
        {
            this.hba_bowlerTableAdapter.Fill(this.vActiveBowler.hba_bowler);
            GetData();
            ClearData();
        }

        private void GetData()
        {
            this.vBowlerNoteTableAdapter.Fill(this.vBowlerNote._vBowlerNote);
        }

        private void ClearData()
        {
            DateTime ldt_Today = DateTime.Now;
            t_Season.Text = ldt_Today.ToString("yyyy");
            cb_Bowler.SelectedValue = 0;
            t_Rank.Text = "";
            t_Note.Text = "";
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvBowler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 li_row = dgvBowler.CurrentCell.RowIndex;

            t_Season.Text = dgvBowler.Rows[li_row].Cells[0].Value.ToString();
            cb_Bowler.Text = dgvBowler.Rows[li_row].Cells[2].Value.ToString();
            t_Rank.Text = dgvBowler.Rows[li_row].Cells[3].Value.ToString();
            t_Note.Text = dgvBowler.Rows[li_row].Cells[4].Value.ToString();

        }

        private void b_Insert_Click(object sender, EventArgs e)
        {
            string ls_sql;

            ls_sql = string.Format("insert into hba_bowler_note(season, bowler_id, rank, note) values ({0}, {1}, {2}, '{3}')",
                                   t_Season.Text,
                                   cb_Bowler.SelectedValue.ToString(),
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

        private void cb_Bowler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ls_sql;

            if (cb_Bowler.SelectedIndex < 0)
            {
                return;
            }

            ls_sql = string.Concat("select  count(*) +1 as rank ",
                                    "from   hba_bowler_note bn ",
                                    "where  bn.season = ", t_Season.Text, " ",
                                    "and    bn.bowler_id = ", cb_Bowler.SelectedValue.ToString());
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
            Int32 li_row = dgvBowler.CurrentCell.RowIndex;

            ls_message = string.Concat("About to delete",
                                        "\n\tSeason: ", dgvBowler.Rows[li_row].Cells[0].Value.ToString(),
                                        "\n\tBowler: ", dgvBowler.Rows[li_row].Cells[2].Value.ToString(),
                                        "\n\tRank: ", dgvBowler.Rows[li_row].Cells[3].Value.ToString(),
                                        "\n\tNote: ", dgvBowler.Rows[li_row].Cells[4].Value.ToString(),
                                        "\n\nAre you sure?");

            DialogResult dr = MessageBox.Show(ls_message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                ls_sql = string.Concat("delete from hba_bowler_note where id = ", dgvBowler.Rows[li_row].Cells[5].Value.ToString());
                LeagueDB.ExecNonQuery(ls_sql);

                GetData();
                ClearData();
            }
        }

        private void b_Update_Click(object sender, EventArgs e)
        {
            Int32 li_row = dgvBowler.CurrentCell.RowIndex;
            string ls_sql;

            ls_sql = string.Concat("update hba_bowler_note ",
                                   "set  bowler_id = ", cb_Bowler.SelectedValue.ToString(),
                                   "    ,rank = ", t_Rank.Text,
                                   "    ,note = '", t_Note.Text, ", ",
                                   "where id = ", dgvBowler.Rows[li_row].Cells[5].Value.ToString());
            LeagueDB.ExecNonQuery(ls_sql);
            GetData();
            ClearData();
        }
    }
}
