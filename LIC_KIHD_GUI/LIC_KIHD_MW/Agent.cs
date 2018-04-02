using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Agent
    {
        private string firstName;
        private string lastName;
        private string department;
        private string agentName;
        public List<Policy> search(string name, Boolean delinquent = false)
        {
            List<Policy> policies = new List<Policy>();
            return policies;
        }
        public Policy search(string policyNumber, string name = "", Boolean delinquent = false)
        {
            Policy client = new Policy();
            return client;
        }
        public static Boolean login(string userName, string passWord)
        {
            String connectionString = Properties.Settings.Default.SQLConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            //String query = "";

            //insert catch here

            //SqlCommand cmd = new SqlCommand(query);
            //cmd.Connection = conn;
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            String query = "execute get_login '" + userName + "', '" + passWord + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                return true;
            } else
            {
                conn.Close();
                return false;
            }
        }
        public void logout()
        {

        }
    }
}
