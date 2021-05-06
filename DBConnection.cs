using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KiaOra
{
    class DBConnection
    {
        // Class Variables
        private static SqlConnection myConnection;

        private Boolean ConnectDB()
        {
            Boolean myUseDatabase = false;

            if (   myConnection is null 
                || myConnection.State != ConnectionState.Open)
            {
                myConnection = new SqlConnection();
                myConnection.ConnectionString = GetConnectionString();

                try
                {
                    myConnection.Open();
                    myUseDatabase = true;
                }
                catch (SqlException)
                {
                    myUseDatabase = false;
                };
            }

            return myUseDatabase;
        }

        private string GetConnectionString()
        {
            string myConnectionString;

            myConnectionString = Properties.Settings.Default.hba_leagueConnectionString.ToString();
            return myConnectionString;
        }

        private void DisconnectDB()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
                myConnection.Dispose();
            }
        }

        public SqlDataReader ExecQuery(string aSQL)
        {
            Boolean       lb_return;

            lb_return = ConnectDB();
            using (SqlCommand cmd = new SqlCommand(aSQL, myConnection))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
        }

        public int ExecNonQuery(string aSQL)
        {
            Boolean lb_connected;
            int li_return;

            lb_connected = ConnectDB();
            using (SqlCommand cmd = new SqlCommand(aSQL, myConnection))
            {
                try
                {
                    li_return = cmd.ExecuteNonQuery();
                }
                catch 
                {
                    li_return = -1;
                }
            }

            myConnection.Close();

            return li_return;
        }

        public DataTable PopulateGridView(string aSQL)
        {
            DataTable dtGrid = new DataTable();

            Boolean lb_return = ConnectDB();

            SqlDataAdapter adapt = new SqlDataAdapter(aSQL, myConnection);
            adapt.Fill(dtGrid);

            myConnection.Close();

            return dtGrid;
        }

        public Boolean ExecuteSqlTransaction(string aTransactionName, Array aSql)
        {
            Boolean lb_connected;
            Boolean lb_succeeded = false;
            SqlTransaction transaction;
            SqlCommand command;
            String ls_message;

            lb_connected = ConnectDB();

            transaction = myConnection.BeginTransaction(aTransactionName);
            command = myConnection.CreateCommand();

            command.Connection = myConnection;
            command.Transaction = transaction;

            try
            {
                foreach (string ls_statement in aSql)
                {
                    command.CommandText = ls_statement;
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                lb_succeeded = true;
            }
            catch (SqlException e)
            {
                ls_message = string.Concat(aTransactionName, " failed \n\r ", e.Message);
                MessageBox.Show(ls_message, "Database Error", MessageBoxButtons.OK);
                transaction.Rollback();
                lb_succeeded = false;
            }

            myConnection.Close();
            return lb_succeeded;
        }
    }
}
 
