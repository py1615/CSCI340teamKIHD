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
        public string[,] search(string policyNum, string clientName, string agentID)
        {
            string thePolicyNum = policyNum;
            string firstName = "";
            string lastName = "";
            int index = 0;
            for( int i = index; i < clientName.Length; i ++)
            {
                index = i;
                if (clientName[i] == ' ') break;
                char letter = clientName[i];
                firstName += letter;
            }
            index++;
            for(int i = index; i < clientName.Length; i ++)
            {
                char letter = clientName[i];
                lastName += letter;
            }
            string theAgentID = agentID;
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute search '" + thePolicyNum + "'" + firstName + "'" + lastName + "'" + theAgentID + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                row++;
            }
            string[,] policyInfo = new string[row,6];
            row = 0;
            while (reader.Read())
            {
                policyInfo[row,0] = reader.GetString(reader.GetOrdinal("policy_number"));
                policyInfo[row, 1] = reader.GetString(reader.GetOrdinal("first_name")) + " " + reader.GetString(reader.GetOrdinal("last_name"));
                policyInfo[row, 2] = reader.GetString(reader.GetOrdinal("dob"));
                policyInfo[row, 3] = reader.GetString(reader.GetOrdinal("policy_start"));
                policyInfo[row, 4] = reader.GetString(reader.GetOrdinal("payoff_amount"));
                policyInfo[row, 5] = reader.GetString(reader.GetOrdinal("monthly_premium"));
                row++;
            }
            conn.Close();
            return policyInfo;
        }

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
