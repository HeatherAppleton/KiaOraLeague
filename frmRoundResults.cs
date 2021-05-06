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
    public partial class frmRoundResults : Form
    {
        public frmRoundResults()
        {
            InitializeComponent();

        }

        private void frmRoundResults_Load(object sender, EventArgs e)
        {
            this.hba_v_RoundResultsTableAdapter.Fill(this.vRoundResult.hba_v_RoundResults);

            DataGridViewColumn dgvcTeam = dgvResults.Columns[1];
            dgvcTeam.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvResults.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
