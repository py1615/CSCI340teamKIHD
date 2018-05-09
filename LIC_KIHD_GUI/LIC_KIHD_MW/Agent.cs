using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Agent
    {
        private readonly static int POLICY_ARRAY_INDEX = 22;
        private readonly static int RETURN_INFO = 7;
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
        public List<string[]> search(string policyNum, string clientFirstName, string clientLastName, string agentID)
        {
            string thePolicyNum = policyNum;
            string theClientFirstName = clientFirstName;
            string theClientLastName = clientLastName;
            string theAgentFirstName = "";
            string theAgentLastName = "";
            string theAgentID = agentID;
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute search " + thePolicyNum + ", '" + theClientFirstName + "', '" + theClientLastName + "', '" + theAgentFirstName + "', '" 
                + theAgentLastName + "', "+ theAgentID + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> policyInfo = new List<string[]>();
            string[] policy = new string[RETURN_INFO];
            string[] colName = {"policy_number", "policy_holder_first_name", "policy_holder_last_name", "policy_start", "policy_status", "payoff_amount", 
                "monthly_premium"};
            while (reader.Read())
            {
                for(int i = 0; i < RETURN_INFO; i ++)
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
            foreach (string[] s in policyInfo.ToArray())
            {
                if (!(thePolicyNum.Equals("null")) && !(s[0].Equals(thePolicyNum)))
                {
                    policyInfo.Remove(s);
                }
                if (!(theClientFirstName.Equals("")) && !(s[1].Equals(theClientFirstName)))
                {
                    policyInfo.Remove(s);
                }
                if (!(theClientLastName.Equals("")) && !(s[2].Equals(theClientLastName)))
                {
                    policyInfo.Remove(s);
                }
            }
            return policyInfo;
        }

        public string[] searchOnClick(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute search_on_click " + policyNum + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            string[] policyInfo = {"policy_holder_first_name", "policy_holder_last_name", "dob", "street_address", "city_address", "state_address", "zip_address", "fathers_age_of_death",
                "mothers_age_of_death", "cigs_day", "smoking_history", "systolic_blood_pressure", "avg_grams_fat_day", "heart_disease", "cancer", "hospitalized",
                "dangerous_activities", "policy_start", "policy_end", "payoff_amount", "monthly_premium", "policy_status"};
            string[] policy = new string[policyInfo.Length];
            while (reader.Read())
            {
                for(int i = 0; i < POLICY_ARRAY_INDEX; i ++)
                {
                    if(reader.IsDBNull(reader.GetOrdinal(policyInfo[i])))
                    {
                        policy[i] = "null";
                    }
                    else if (typeof(decimal) == (reader.GetFieldType(reader.GetOrdinal(policyInfo[i]))))
                    {
                        decimal d = reader.GetDecimal(reader.GetOrdinal(policyInfo[i]));
                        policy[i] = "" + d;
                    }
                    else if(typeof(DateTime) == (reader.GetFieldType(reader.GetOrdinal(policyInfo[i]))))
                    {
                        DateTime day = reader.GetDateTime(reader.GetOrdinal(policyInfo[i]));
                        policy[i] = day.ToString("yyyy/MM/dd");
                    }
                    else if(typeof(Boolean) == (reader.GetFieldType(reader.GetOrdinal(policyInfo[i]))))
                    {
                        Boolean x = reader.GetBoolean(reader.GetOrdinal(policyInfo[i]));
                        if(x)
                        {
                            policy[i] = "Yes";
                        }else
                        {
                            policy[i] = "No";
                        }
                    }else
                    {
                        policy[i] = reader.GetString(reader.GetOrdinal(policyInfo[i]));
                    }
                }
            }
            conn.Close();
            return policy;
        }

        public string[,] beneficiaryName(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute get_beneficiary " + policyNum + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                row ++;
            }
            conn.Close();
            string[,] beneficiary = new string[row, 2];
            row = 0;
            conn.Open();
            string[] beneficiaryName = {"first_name", "last_name"};
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for(int i = 0; i < beneficiaryName.Length; i ++)
                {
                    beneficiary[row, i] = reader.GetString(reader.GetOrdinal(beneficiaryName[i]));
                }
                row ++;
            }
            conn.Close();
            return beneficiary;
        }

        public string[,] getPayments(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute get_payments " + policyNum + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                row ++;
            }
            conn.Close();
            string[,] payment = new string[row, 2];
            row = 0;
            conn.Open();
            string[] paymentInfo = {"date_paid", "amount"};
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for(int i = 0; i < paymentInfo.Length; i ++)
                {
                    if(typeof(DateTime) == (reader.GetFieldType(reader.GetOrdinal(paymentInfo[i]))))
                    {
                        DateTime day = reader.GetDateTime(reader.GetOrdinal(paymentInfo[i]));
                        payment[row, i] = day.ToString();
                    }else
                    {
                        decimal x = reader.GetDecimal(reader.GetOrdinal(paymentInfo[i]));
                        payment[row, i] = "" + x;
                    }
                }
                row ++;
            }
            conn.Close();
            return payment;
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
