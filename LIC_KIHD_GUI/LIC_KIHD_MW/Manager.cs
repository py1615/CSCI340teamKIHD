using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Manager : Agent
    {
        /*private string agentID;
        private string firstName;
        private string lastName;
        private string department;
        private string agentType;*/
        public Manager(string firstName, string lastName, string department, string agentType,
            string userName, string passWord) : base(firstName, lastName, department, agentType)
        {

        }

        public static string userRegister(string userName, string firstName, string lastName, string passWord,
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
        /*public List<Policy> search(string policyNum, ,string agentNum, string clientName)
        {
            List<Policy> list = new List<Policy>();
            return list;
        }*/
    }
}
