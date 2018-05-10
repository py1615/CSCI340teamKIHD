using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Manager : Agent
    {
        private readonly static int RETURN_INFOM = 11;
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
                id = "" + reader.GetString(reader.GetOrdinal("id"));
            }
            conn.Close();
            return id;
        }

        public List<string[]> managerSearch(string policyNum, string clientFirstName, string clientLastName, string agentFirstName, string agentLastName)
        {
            string thePolicyNum = policyNum;
            string theClientFirstName = clientFirstName;
            string theClientLastName = clientLastName;
            string theAgentFirstName = agentFirstName;
            string theAgentLastName = agentLastName;
            string theAgentID = "null";
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute search " + thePolicyNum + ", " + theClientFirstName + ", " + theClientLastName + ", " + theAgentFirstName + ", " 
                + theAgentLastName + ", "+ theAgentID + "";
            Console.WriteLine(query);
            Console.WriteLine(query);
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> policyInfo = new List<string[]>();
            string[] colName = {"policy_number", "policy_holder_first_name", "policy_holder_last_name", "dob", "policy_start", "payoff_amount", 
                "monthly_premium", "policy_status", "agent_id", "agent_first_name", "agent_last_name"};
            while (reader.Read())
            {
                string[] policy = new string[RETURN_INFOM];
                for (int i = 0; i < RETURN_INFOM; i ++)
                {
                    if(reader.IsDBNull(reader.GetOrdinal(colName[i])))
                    {
                        policy[i] = "null";
                    }
                    else if (typeof(decimal) == (reader.GetFieldType(reader.GetOrdinal(colName[i]))))
                    {
                        decimal d = reader.GetDecimal(reader.GetOrdinal(colName[i]));
                        policy[i] = "" + d;
                    }
                    else if(typeof(DateTime) == (reader.GetFieldType(reader.GetOrdinal(colName[i]))))
                    {
                        DateTime day = reader.GetDateTime(reader.GetOrdinal(colName[i]));
                        policy[i] = day.ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        policy[i] = reader.GetString(reader.GetOrdinal(colName[i]));
                    }
                }
                policyInfo.Add(policy);
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
