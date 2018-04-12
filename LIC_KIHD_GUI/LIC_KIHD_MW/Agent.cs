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
        private char agentType;
        public Agent(string theAgentID, string theFirstName, string theLastName, string theDepartment, char theAgentType)
        {
            agentID = theAgentID;
            firstName = theFirstName;
            lastName = theLastName;
            department = theDepartment;
            agentType = theAgentType;
        }
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
            String connectionString = "Data Source=DATABASE" + "\\" + "CSCI3400011030;Initial Catalog=LIC_KIHD;"
        + "Integrated Security=false;user='LIC_KIHD_MW';pwd='KIHD';";
            //"Initial Catalog=Restaurant;Data Source=SROSEN-LT-5000;" + "Integrated Security=False;user='middleware';pwd='password'";
            SqlConnection conn = new SqlConnection(connectionString);
            //String query = "";


            if(userName.Contains("'"))
            {
                return "";
            }
            if(passWord.Contains("'"))
            {
                return "";
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
            string userType = reader.Read();
            conn.Close();
            return userType;
        }
        public void logout()
        {

        }
    }
}
