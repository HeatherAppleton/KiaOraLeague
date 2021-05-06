using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KiaOra
{
    class BowlerValidation
    {
        private DBConnection LeagueDB = new DBConnection();

        public Boolean IsValid(string bowlerName, string gender, string teamName, string position, string active, string privacy)
        {
            int li_position;

            if (string.IsNullOrEmpty(bowlerName))
            {
                MessageBox.Show("Bowler Name is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(teamName))
            {
                MessageBox.Show("Team Name is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(position.ToString()))
            {
                MessageBox.Show("Team Position is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Team Position is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!int.TryParse(position, out li_position))
            {
                MessageBox.Show("Team Position is required and must be between 1 and 99 inclusive.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (   li_position < 1
                || li_position > 99)
            {
                MessageBox.Show("Team Position must be between 1 and 99 inclusive.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(active))
            {
                MessageBox.Show("Active is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(privacy))
            {
                MessageBox.Show("Privacy is required.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
