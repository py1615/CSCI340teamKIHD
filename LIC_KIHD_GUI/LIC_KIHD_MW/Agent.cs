using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Agent
    {
        private readonly static int RETURN_INFO = 6;
        private string firstName;
        private string lastName;
        private string department;
        private string agentType;
        public Agent(string theFirstName, string theLastName, string theDepartment, string theAgentType)
        {
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
            if(clientName != "null")
            {
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
            }else
            {
                firstName = "null";
                lastName = "null";
            }
            string theAgentID = agentID;
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute search " + thePolicyNum + ", '" + firstName + "', '" + lastName + "', " + theAgentID + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                row++;
            }
            conn.Close();
            conn.Open();
            reader = command.ExecuteReader();
            string[,] policyInfo = new string[row,RETURN_INFO];
            row = 0;
            string[] colName = {"policy_number", "policy_holder_first_name", "dob", "policy_start", "payoff_amount", 
                "monthly_premium"};
            while (reader.Read())
            {
                for(int i = 0; i < RETURN_INFO; i ++)
                {
                    if(reader.IsDBNull(reader.GetOrdinal(colName[i])))
                    {
                        policyInfo[row, i] = "null";
                    }
                    else if (typeof(decimal) == (reader.GetFieldType(reader.GetOrdinal(colName[i]))))
                    {
                        decimal d = reader.GetDecimal(reader.GetOrdinal(colName[i]));
                        policyInfo[row, i] = "" + d;
                    }
                    else if(typeof(DateTime) == (reader.GetFieldType(reader.GetOrdinal(colName[i]))))
                    {
                        DateTime day = reader.GetDateTime(reader.GetOrdinal(colName[i]));
                        policyInfo[row, i] = day.ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        policyInfo[row, i] = reader.GetString(reader.GetOrdinal(colName[i]));
                        if (i == 1)
                        {
                            policyInfo[row, i] += " " + reader.GetString(reader.GetOrdinal("policy_holder_last_name"));
                        }
                    }
                }
                row++;
            }
            conn.Close();
            return policyInfo;
        }

        public Policy searchOnClick(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute search_on_click " + policyNum + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
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
