using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Manager : Agent
    {
        private readonly static int RETURN_INFOM = 9;
        /*private string agentID;
        private string firstName;
        private string lastName;
        private string department;
        private string agentType;*/
        public Manager(string firstName, string lastName, string department, string agentType,
            string userName, string passWord) : base(firstName, lastName, department, agentType)
        {

        }

        public string userRegister(string userName, string firstName, string lastName, string passWord,
            string agentType, string department)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute register_user '" + userName + "', '" + firstName + "', '" + lastName 
                + "', '" + passWord + "', '" + agentType + "','" + department + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = reader.GetString(reader.GetOrdinal("id"));
            }
            conn.Close();
            return id;
        }

        public string[,] managerSearch(string policyNum, string clientName, string agentID)
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
            string[,] policyInfo = new string[row,RETURN_INFOM];
            row = 0;
            string[] colName = {"policy_number", "policy_holder_first_name", "dob", "policy_start", "payoff_amount", 
                "monthly_premium", "policy_status", "agent_id", "agent_first_name"};
            while (reader.Read())
            {
                for(int i = 0; i < RETURN_INFOM; i ++)
                {
                    if(reader.GetValue(reader.IsDBNull(colName[i])) == null) policyInfo[row, i] = "null";
                    if (typeof(decimal) == (reader.GetFieldType(reader.GetOrdinal(colName[i]))))
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


        /*public List<Policy> search(string policyNum, ,string agentNum, string clientName)
        {
            List<Policy> list = new List<Policy>();
            return list;
        }*/
    }
}
