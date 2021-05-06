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
    public partial class frmDrawView : Form
    {
        private frmResultsMaintenance ifrm_details;
        public frmDrawView()
        {
            InitializeComponent();
        }

        private void frmDrawView_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            if (ifrm_details != null)
            {
                ifrm_details.Close();
            }
            Close();
        }

        private void b_Details_Click(object sender, EventArgs e)
        {
            Int32 li_row = dgvDraw.CurrentCell.RowIndex;
            string ls_drawId = dgvDraw.Rows[li_row].Cells[0].Value.ToString();

            ifrm_details = new frmResultsMaintenance(this);
            ifrm_details.DisplayResults(ls_drawId);
            ifrm_details.Show();
        }

        private void dgvDraw_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            b_Details_Click(sender, e);
        }

        public void RefreshData()
        {
            int returnCode;
            returnCode = this.hba_v_drawTableAdapter.Fill(this.vDrawDataSet.hba_v_draw);
        }
    }
}
