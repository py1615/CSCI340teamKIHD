using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLImporter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ImportUsers(@"..\..\..\User.txt");
            ImportPolicies(@"..\..\..\LifePolicy.txt");
            for (int i = 0; i < 7; ++i)
            {
                ImportPayments(@"..\..\..\PaymentHistory" + i + ".txt");
            }
            ImportBeneficiaries(@"..\..\..\Beneficiaries.txt");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }

        static public void ImportPayments(String filepath)
        {
            String[] input = System.IO.File.ReadAllLines(filepath);
            foreach (String line in input)
            {
                String SQLStatement = "INSERT INTO ";

                SQLStatement += "payments (date_paid, policy_number, amount, payment_type) VALUES ('";

                for (int i = 10; i < 22; ++i) //date_paid
                {
                    if (i == 14 || i == 16)
                    {
                        SQLStatement += "/";
                    }
                    else if (i == 18)
                    {
                        SQLStatement += " ";
                    }
                    else if (i == 20)
                    {
                        SQLStatement += ":";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', ";
                for (int i = 22; i < 52; ++i) //policy_number
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                for (int i = 0; i < 10; ++i) //amount
                {
                    if (i == 8)
                    {
                        SQLStatement += ".";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                if (line.ToCharArray()[52] == 'P') //payment_type
                {
                    SQLStatement += "'P'";
                }
                else
                {
                    SQLStatement += "'C'";
                }
                SQLStatement += ")";
                Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
        }

        static public void ImportBeneficiaries(String filepath)
        {
            String[] input = System.IO.File.ReadAllLines(filepath);
            foreach (String line in input)
            {
                String SQLStatement = "INSERT INTO ";

                SQLStatement += "beneficiaries (policy_number, first_name, last_name) VALUES (";

                for (int i = 0; i < 30; ++i)
                {
                    if (line.ToCharArray()[i] != ' ') //policy_number
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", '";
                for (int i = 30; i < 130; ++i) //first_name
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', '";
                for (int i = 130; i < line.Length; ++i) //last_name
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "')";
                Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
        }

        static public void ImportPolicies(String filepath)
        {
            String[] input = System.IO.File.ReadAllLines(filepath);
            foreach (String line in input)
            {
                String SQLStatement = "SET IDENTITY_INSERT client_policy ON INSERT INTO ";

                SQLStatement += "client_policy (policy_number, policy_holder_id, dob, fathers_age_of_death, mothers_age_of_death, cigs_day, smoking_history, systolic_blood_pressure, avg_grams_fat_day, heart_disease, cancer, hospitalized, dangerous_activities, policy_start, policy_end, agent_id, payoff_amount, monthly_premium, policy_status) VALUES (";

                for (int i = 0; i < 30; ++i) //policy_number
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                for (int i = 30; i < 50; ++i) //policy_holder_id
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", '";
                for (int i = 50; i < 58; ++i) //dob
                {
                    if (i == 54 || i == 56)
                    {
                        SQLStatement += "/";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', '";
                for (int i = 58; i < 63; ++i) //fathers_age_of_death
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', '";
                for (int i = 63; i < 68; ++i) //mothers_age_of_death
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', ";
                for (int i = 68; i < 73; ++i) //cigs_day
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", '";
                for (int i = 73; i < 78; ++i) //smoking_history
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', ";
                for (int i = 78; i < 82; ++i) //systolic_blood_pressure
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                for (int i = 82; i < 87; ++i) //avg_grams_fat_day
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                if (line.ToCharArray()[87] == 'Y') //heart_disease
                {
                    SQLStatement += "1, ";
                }
                else
                {
                    SQLStatement += "0, ";
                }
                if (line.ToCharArray()[88] == 'Y') //cancer
                {
                    SQLStatement += "1, ";
                }
                else
                {
                    SQLStatement += "0, ";
                }
                if (line.ToCharArray()[89] == 'Y') //hospitalized
                {
                    SQLStatement += "1, ";
                }
                else
                {
                    SQLStatement += "0, ";
                }
                SQLStatement += "'";
                for (int i = 90; i < 345; ++i) //dangerous_activities
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', '";
                for (int i = 345; i < 353; ++i) //policy_start
                {
                    if (i == 349 || i == 351)
                    {
                        SQLStatement += "/";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', '";
                for (int i = 353; i < 361; ++i) //policy_end
                {
                    if ((i == 357 || i == 359) && line.ToCharArray()[353] != ' ')
                    {
                        SQLStatement += "/";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += "', ";
                for (int i = 361; i < 381; ++i) //agent_id
                {
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                for (int i = 381; i < 391; ++i) //payoff_amount
                {
                    if (i == 389)
                    {
                        SQLStatement += ".";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", ";
                for (int i = 391; i < line.Length; ++i) //monthly_premium
                {
                    if (i == 399)
                    {
                        SQLStatement += ".";
                    }
                    if (line.ToCharArray()[i] != ' ')
                    {
                        SQLStatement += line.ToCharArray()[i];
                    }
                }
                SQLStatement += ", 'A') SET IDENTITY_INSERT client_policy OFF"; //policy_status
                Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        static public void ImportUsers(String filepath)
        {
            String[] input = System.IO.File.ReadAllLines(filepath);
            foreach (String line in input)
            {
                String SQLStatement = "";

                if (line.ToCharArray()[475] == 'A' || line.ToCharArray()[475] == 'D')
                {
                    SQLStatement += "SET IDENTITY_INSERT employee ON INSERT INTO employee (id, username, first_name, last_name, employee_password, user_type, department) VALUES (";

                    for (int i = 476; i < 496; ++i) //id
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += ", '";
                    for (int i = 0; i < 20; ++i) //username
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 20; i < 120; ++i) //first_name
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 120; i < 220; ++i) //last_name
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 220; i < 475; ++i) //employee_password
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', ";
                    if (line.ToCharArray()[475] == 'D') //user_type
                    {
                        SQLStatement += "'M', ";
                    }
                    else
                    {
                        SQLStatement += "'A', '";
                    }
                    for (int i = 557; i < line.Length; ++i) //department
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "') SET IDENTITY_INSERT employee OFF";
                }
                else
                {
                    SQLStatement += "SET IDENTITY_INSERT policy_holder ON INSERT INTO policy_holder (policy_holder_id, first_name, last_name, street_address, city_address, state_address, zip_address) VALUES (";

                    for (int i = 476; i < 496; ++i) //policy_holder_id
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += ", '";
                    for (int i = 20; i < 120; ++i) //first_name
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 120; i < 220; ++i) //last_name
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 496; i < 526; ++i) //street_address
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 526; i < 546; ++i) //city_address
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 546; i < 548; ++i) //sate_address
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "', '";
                    for (int i = 548; i < 557; ++i) //zip_address
                    {
                        if (line.ToCharArray()[i] != ' ')
                        {
                            SQLStatement += line.ToCharArray()[i];
                        }
                    }
                    SQLStatement += "') SET IDENTITY_INSERT policy_holder OFF";
                }
                Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        static public void Connect(String query)
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
            String connectionString = Properties.Settings.Default.SQLConnection;//"Initial Catalog=Restaurant;Data Source=SROSEN-LT-5000;" + "Integrated Security=False;user='middleware';pwd='password'";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
