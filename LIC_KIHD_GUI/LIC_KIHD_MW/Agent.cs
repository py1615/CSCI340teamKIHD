using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Agent
    {
        private string agentID;
        private string firstName;
        private string lastName;
        private string department;
        private string agentType;
        public Agent(string theAgentID, string theFirstName, string theLastName, string theDepartment, string theAgentType)
        {
            agentID = theAgentID;
            firstName = theFirstName;
            lastName = theLastName;
            department = theDepartment;
            agentType = theAgentType;
        }
        /*public List<Policy> search(string policyNum, string clientName)
        {
            List<Policy> list = new List<Policy>();
            string[][] policyInfo = new string[][];
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute Search ''";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int columnNum = reader.GetOrdinal("PolicyHolder");
                string policyholder = reader.GetString(columnNum);
            }
            conn.Close();
            return list;
        }*/

        public static string login(string userName, string passWord)
        {
            /*
             * there are 2 ways to connect with SQL Server:
             * (1) using the Windows account of the current user, called "Integrated security".
             * (2) using a SQL account with a password, called "SQL Server authentication".
             * 
             * In a SQL connection string, we list the following information:
             * Initial Catalog = name of database
             * Data Source = name of server machine, which can be a networked machine or URL
            */
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            /*"Data Source=DATABASE" + "\\" + "CSCI3400011030;Initial Catalog=LIC_KIHD;"
        + "Integrated Security=false;user='LIC_KIHD_MW';pwd='KIHD';"*/
            //"Initial Catalog=Restaurant;Data Source=SROSEN-LT-5000;" + "Integrated Security=False;user='middleware';pwd='password'";
            SqlConnection conn = new SqlConnection(connectionString);
            //String query = "";

            string userType = "";
            if(userName.Contains("'"))
            {
                return userType;
            }
            if(passWord.Contains("'"))
            {
                return userType;
            }
            //insert catch here <----------------------------------------------------------------------------------------------------DO THIS!
            


            //SqlCommand cmd = new SqlCommand(query);
            //cmd.Connection = conn;
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            string query = "execute get_login '" + userName + "', '" + passWord + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                userType = reader.GetString(reader.GetOrdinal("user_type"));
            }
            conn.Close();
            return userType;
        }
        public void logout()
        {

        }
    }
}
