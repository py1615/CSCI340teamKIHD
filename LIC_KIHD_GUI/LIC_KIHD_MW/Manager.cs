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
        public Manager(string theAgentID, string theFirstName, string theLastName, string theDepartment, 
            string theAgentType, string userName, string passWord) : base(theAgentID, theFirstName, theLastName, theDepartment, theAgentType)
        {
            string agentID = theAgentID;
            string firstName = theFirstName;
            string lastName = theLastName;
            string department = theDepartment;
            string agentType = theAgentType;
            string id = userName;
            string psw = passWord;
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute register_user '" + agentID + "', '" + firstName + "', '" + lastName + "', '" + agentType+ "', '" + department + "', '" + id + "','" + psw + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        /*public List<Policy> search(string policyNum, ,string agentNum, string clientName)
        {
            List<Policy> list = new List<Policy>();
            return list;
        }*/
    }
}
