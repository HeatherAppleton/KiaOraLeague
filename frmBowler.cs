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
    public partial class frmBowler : Form
    {
        private DBConnection LeagueDB = new DBConnection();

        private frmNewBowler NewBowler = new frmNewBowler();
        private frmEditBowler EditBowler = new frmEditBowler();

        private int cBowlerName = 0;
        private int cActive = 1;
        private int cAddress = 2;
        private int cPhone = 3;
        private int cEmail = 4;
        private int cGender = 5;
        private int cTeamName = 6;
        private int cPosition = 7;
        private int cPrivacy = 8;
        private int cId = 9;
        private int cTeamId = 10;

        public frmBowler()
        {
            InitializeComponent();
        }

        private void frmBowler_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string ls_sql;
            DataTable data;

            ls_sql = string.Concat("SELECT b.bowler_name  "
                                  , ",b.active_flag "
                                  , ",b.address "
                                  , ",b.phone "
                                  , ",b.email "
                                  , ",b.gender "
                                  , ",t.team_name "
                                  , ",b.position "
                                  , ",b.privacy_flag "
                                  , ",b.id "
                                  , ",b.team_id "
                                  , "FROM dbo.hba_bowler b "
                                  , "JOIN dbo.hba_team   t on t.id = b.team_id "
                                  , "order by b.active_flag desc, b.bowler_name"
                                  );
            data = LeagueDB.PopulateGridView(ls_sql);
            dgvBowler.DataSource = data;
        }

        private void dgvBowler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            b_Edit_Click(sender, null);
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_New_Click(object sender, EventArgs e)
        {
            if (NewBowler.IsDisposed)
            {
                NewBowler = new frmNewBowler();
            }
            NewBowler.setCallingForm(this);
            NewBowler.Show();
        }

        private void b_Edit_Click(object sender, EventArgs e)
        {
            int row;
            int position;
            int teamId;
            int bowlerId;
            string bowlerName;
            string address;
            string phone;
            string email;
            string gender;
            string active;
            string privacy;
            string teamName;

            row = dgvBowler.CurrentCell.RowIndex;

            Int32.TryParse(dgvBowler.Rows[row].Cells[cId].Value.ToString(), out bowlerId);
            Int32.TryParse(dgvBowler.Rows[row].Cells[cPosition].Value.ToString(), out position);
            Int32.TryParse(dgvBowler.Rows[row].Cells[cTeamId].Value.ToString(), out teamId);

            bowlerName = dgvBowler.Rows[row].Cells[cBowlerName].Value.ToString();
            address = dgvBowler.Rows[row].Cells[cAddress].Value.ToString();
            phone = dgvBowler.Rows[row].Cells[cPhone].Value.ToString();
            email = dgvBowler.Rows[row].Cells[cEmail].Value.ToString();
            gender = dgvBowler.Rows[row].Cells[cGender].Value.ToString();
            active = dgvBowler.Rows[row].Cells[cActive].Value.ToString();
            privacy = dgvBowler.Rows[row].Cells[cPrivacy].Value.ToString();
            teamName = dgvBowler.Rows[row].Cells[cTeamName].Value.ToString();

            if (EditBowler.IsDisposed)
            {
                EditBowler = new frmEditBowler();
            }
            EditBowler.SetCallingWindow(this);
            EditBowler.Show();
            EditBowler.SetData(bowlerId,
                               bowlerName,
                               address,
                               phone,
                               email,
                               gender,
                               active,
                               privacy,
                               teamId, 
                               teamName,
                               position
            );
        }
    }
}
