using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KiaOra
{
    class TeamValidation
    {
        private DBConnection LeagueDB = new DBConnection();
        private SqlDataReader isdr_data;

        public int GetNextPosition(string teamId)
        {
            int position = 0;
            string temp;
            string sql;

            if (String.IsNullOrEmpty(teamId))
            {
                return position;
            }

            sql = "select isnull(max(b.position), 0) + 1 "
                + "from   hba_bowler b "
                + "where  b.team_id = " + teamId;

            isdr_data = LeagueDB.ExecQuery(sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    temp = isdr_data[0].ToString();
                    Int32.TryParse(temp, out position);
                }
            }

            isdr_data.Close();


            return position;
        }

        public Boolean IsTeamActive(string teamId)
        {
            string active = "";
            string sql;

            if (String.IsNullOrEmpty(teamId))
            {
                return false;
            }

            sql = "select active_flag "
                + "from   hba_team t "
                + "where  t.id = " + teamId;

            isdr_data = LeagueDB.ExecQuery(sql);
            if (isdr_data.HasRows)
            {
                while (isdr_data.Read())
                {
                    active = isdr_data[0].ToString();
                }
            }

            isdr_data.Close();


            return (active == "Y");
        }
    }
}
