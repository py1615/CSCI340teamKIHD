using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            //ImportUsers(@"C:\Users\Noi3s\source\repos\CSCI340teamKIHD\DATABASE\SQLImporter\User.txt");
            //ImportPolicies(@"C:\Users\Noi3s\source\repos\CSCI340teamKIHD\DATABASE\SQLImporter\LifePolicy.txt");
            ImportBeneficiaries(@"C:\Users\Noi3s\source\repos\CSCI340teamKIHD\DATABASE\SQLImporter\Beneficiaries.txt");
            for (int i = 0; i < 7; ++i)
            {
                ImportPayments(@"C:\Users\Noi3s\source\repos\CSCI340teamKIHD\DATABASE\SQLImporter\PaymentHistory" + i + ".txt");
            }
        }

        static public void ImportPayments(String filepath)
        {
            String[] users = System.IO.File.ReadAllLines(filepath);
            foreach (String line in users)
            {
                String SQLStatement = "INSERT INTO";

                SQLStatement += " payments (policy_number, datetime, amount, description) VALUES (";

                for (int i = 0; i < 30; ++i)
                {

                }
            }
        }

        static public void ImportBeneficiaries(String filepath)
        {
            String[] users = System.IO.File.ReadAllLines(filepath);
            foreach (String line in users)
            {
                String SQLStatement = "INSERT INTO";

                SQLStatement += " beneficiaries (policy_number, first_name, last_name) VALUES (";

                for (int i = 0; i <30; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 30; i < 130; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 130; i < line.Length; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ")";
                //Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
        }

        static public void ImportPolicies(String filepath)
        {
            String[] users = System.IO.File.ReadAllLines(filepath);
            foreach (String line in users)
            {
                String SQLStatement = "INSERT INTO";

                SQLStatement += " client_policy (policy_number, first_name, last_name, dob, fathers_age_at_death, mothers_age_at_death, cigs_day, smoking_history, systolic_blood_pressure, avg_grams_fat_day, heart_disease, cancer, hospitalized, dangerous_activities) VALUES (";

                for (int i = 0; i < 30; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 50; i < 58; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 58; i < 63; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 63; i < 68; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 68; i < 73; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 73; i < 78; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 78; i < 82; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 82; i < 87; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                if (line.ElementAt<char>(87) == 'Y')
                {
                    SQLStatement += "Y, ";
                }
                else
                {
                    SQLStatement += "N, ";
                }
                if (line.ElementAt<char>(88) == 'Y')
                {
                    SQLStatement += "Y, ";
                }
                else
                {
                    SQLStatement += "N, ";
                }
                if (line.ElementAt<char>(89) == 'Y')
                {
                    SQLStatement += "Y, ";
                }
                else
                {
                    SQLStatement += "N, ";
                }
                for (int i = 90; i < 345; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 345; i < 353; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 353; i < 361; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 361; i < 381; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 381; i < 391; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ", ";
                for (int i = 391; i < line.Length; ++i)
                {
                    if (line.ElementAt<char>(i) != ' ')
                    {
                        SQLStatement += line.ElementAt<char>(i);
                    }
                }
                SQLStatement += ")";
                //Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        static public void ImportUsers(String filepath)
        {
            String[] users = System.IO.File.ReadAllLines(filepath);
            foreach (String line in users)
            {
                String SQLStatement = "INSERT INTO";

                if (line.ElementAt<char>(475) == 'A' || line.ElementAt<char>(475) == 'D')
                {
                    SQLStatement += " employee (username, first_name, last_name, password, user_type, id, department) VALUES (";

                    for (int i = 0; i < 20; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 20; i < 120; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 120; i < 220; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 220; i < 475; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    if (line.ElementAt<char>(475) == 'A')
                    {
                        SQLStatement += "A, ";
                    }
                    else
                    {
                        SQLStatement += "M, ";
                    }
                    for (int i = 476; i < 496; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 557; i < line.Length; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ")";
                }
                else
                {
                    SQLStatement += " policy_holder (first_name, last_name, street, city, state, zip) VALUES (";

                    for (int i = 20; i < 120; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 120; i < 220; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 496; i < 526; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 526; i < 546; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 546; i < 548; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ", ";
                    for (int i = 548; i < 557; ++i)
                    {
                        if (line.ElementAt<char>(i) != ' ')
                        {
                            SQLStatement += line.ElementAt<char>(i);
                        }
                    }
                    SQLStatement += ")";
                }
                //Connect(SQLStatement);
                Console.WriteLine(SQLStatement);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        static public void Connect(String SQLStatement)
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
            //            String connectionString = "";//"Initial Catalog=Restaurant;Data Source=SROSEN-LT-5000;" + "Integrated Security=False;user='middleware';pwd='password'";
            //            SqlConnection conn = new SqlConnection(connectionString);
            //            String query = "INSERT INTO Diner(Credit_Card_No) VALUES('" +
            //                textBox1.Text + "')";
            /*
             * This query is vulnerable to SQL injection attack!
             * Solution is to check that textBox1.Text matches the desired format: in this case,
             * alphanumeric characters only; and that the text is not too long.
             * We can also restrict the privileges of the Middleware user on SQL Server to only
             * SELECT and execute stored procedures.
            */
            //            SqlCommand cmd = new SqlCommand(query);
            //            cmd.Connection = conn;
            //            conn.Open();
            //            cmd.ExecuteNonQuery();
            //            conn.Close();

            //            query = "execute get_orders 'burger'";//"SELECT Credit_Card_No FROM Diner";
            //            SqlCommand command = new SqlCommand(query);
            //            command.Connection = conn;
            //            conn.Open();
            //            SqlDataReader reader = command.ExecuteReader();
            //            while (reader.Read())//loop through one row at a time of returned data
            //            {
            //                int columnNum = reader.GetOrdinal("Credit_Card_No");//get column # of credit_card_no column
            //                String creditCardNum = reader.GetString(columnNum);
            //                textBox1.Text += " " + creditCardNum;
            //            }
            //            conn.Close();
        }
    }
}
