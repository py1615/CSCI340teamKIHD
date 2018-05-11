using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Policy
    {
        private readonly static double HIGH_IMPACT_LOSS_RATE = 0.05;
        private readonly static int DATE_CONVERT = 10000;
        private readonly static int MONTH_CONVERT = 100;
        private readonly static int DATE = 30;
        private readonly static int MONTH = 12;
        private readonly static int HEALTH_RELATE = 10;
        private readonly static double PROFIT_RATE = 1.1;
        private PolicyHolder insured;
        private string policyNum;
        private double payoffAmount;
        private string agentID;
        //private double duration;
        private Beneficiary beneficiary;
        private double fatherDeathAge;
        private double motherDeathAge;
        private double cigsPerDay;
        private double smokingHistory;
        private double bloodPressure;
        private double gramsFatPerDay;
        private string heartDisease;
        private string cancer;
        private string hospitalized;
        private string dangerousAct;

        public Policy(PolicyHolder theInsured, string thePolicyNum, double thePayOffAmount, double theFatherDeathAge, double theMotherDeathAge,
            double theCigsPerDay, double theSmokingHistory, double theBloodPressure, double theGramsFatPerDay, string theHeartDisease,
            string theCancer, string theHospitalized, string theDangerousAct, Beneficiary theHeir, string theAgent)
        {
            insured = theInsured;
            payoffAmount = thePayOffAmount;
            agentID = theAgent;
            beneficiary = theHeir;
            fatherDeathAge = theFatherDeathAge;
            motherDeathAge = theMotherDeathAge;
            cigsPerDay = theCigsPerDay;
            smokingHistory = theSmokingHistory;
            bloodPressure = theBloodPressure;
            gramsFatPerDay = theGramsFatPerDay;
            heartDisease = theHeartDisease;
            cancer = theCancer;
            hospitalized = theHospitalized;
            dangerousAct = theDangerousAct;
            policyNum = thePolicyNum;
        }

        public String PolicyNumReg(string firstName, string lastName, DateTime dob, string streetAddress,
            string city, string state, string zip, string fatherDeathAge, string motherDeathAge, string cigPerDay,
            string smokingHistory, string bloodPressure, string avegGrams, string heartDisease, string cancer,
            string hospitalized, string dangerousAct, string payoffAmount, string premium,  string agentID)
        {
            decimal cigsPerDay = Convert.ToDecimal(cigPerDay); 
            decimal bloodsPressure = Convert.ToDecimal(bloodPressure);
            decimal avegsFat = Convert.ToDecimal(avegGrams);
            decimal agentsID = Convert.ToDecimal(agentID);
            decimal payoffAmounts = Convert.ToDecimal(payoffAmount);
            decimal premiums = Convert.ToDecimal(premium);
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute register_policy '" + firstName + "', '" + lastName + "', '" + streetAddress + 
                "', '" + city + "', '" + state + "', '" + zip + "', '" + dob + "', '" + fatherDeathAge + "', '" 
                + motherDeathAge + "', " + cigsPerDay + ", '" + smokingHistory + "', " + bloodsPressure + ", " 
                + avegsFat + ", " + heartDisease + ", " + cancer + ", " + hospitalized + ", '" + dangerousAct + "', " 
                + agentsID + ", " + payoffAmounts + ", " + premiums + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            string policyNumber = "";
            while(reader.Read())
            {
                policyNumber = reader.GetString(reader.GetOrdinal("policy_number"));
            }
            conn.Close();
            return policyNumber;
        }

        public void addBeneficiary(string policyNum, string firstName, string lastName)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute add_beneficiary " + policyNum + ", '" + firstName + "', '" + lastName + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Cancel(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute cancel " + policyNum + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public Boolean MakeClaim(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute claim " + policyNum + "";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            string[] claim = {"total_with_inflation", "payoff_amount"};
            decimal[] claimInfo = new decimal[claim.Length];
            while(reader.Read())
            {
                for(int i = 0; i < claimInfo.Length; i ++)
                {
                    claimInfo[i] = reader.GetDecimal(reader.GetOrdinal(claim[i]));
                }
            }
            conn.Close();
            double profit = (double)(claimInfo[1] - claimInfo[0]);
            double limit = (double)(claimInfo[1]) * HIGH_IMPACT_LOSS_RATE;
            if (profit >= limit) return true;
            return false;
        }


        private Report SendReport(List<Policy> policy)
        {
            Report rept = new Report();
            return rept;
        }
        public double CalculatePremium(string payoffAmount, DateTime dob, string fathersDeathAge, string mothersDeathAge, 
            string cigPerDay, string smokingHistory, string bloodPressure, string avgFatPerDay, 
            string heartDisease, string theCancer, string hospitalized, string dangerousAct)
        {
            double fatherDA = convertMonth(fathersDeathAge);
            double motherDA = convertMonth(mothersDeathAge);
            double cigsPerDay = Convert.ToDouble(cigPerDay);
            double history = convertMonth(smokingHistory);
            double bloodP = Convert.ToDouble(bloodPressure);
            double avgFat = Convert.ToDouble(avgFatPerDay);
            double heartD = Convert.ToDouble(heartDisease);
            double cancer = Convert.ToDouble(theCancer);
            double hospital = Convert.ToDouble(hospitalized);
            double dangerAct = dangerousCount(dangerousAct);
            Matrix client = new Matrix(1, HEALTH_RELATE);
            double[] clientInfo = {fatherDA, motherDA, cigsPerDay, history, bloodP, avgFat, heartD,
                cancer, hospital, dangerAct};
            for(int i = 0; i < HEALTH_RELATE; i ++)
            {
                client.setData(0, i, clientInfo[i]);
            }
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute calculation_data";
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
            Matrix D = new Matrix(row, HEALTH_RELATE + 1);
            Matrix y = new Matrix(row, 1);
            for(int i = 0; i < row; i ++)
            {
                D.setData(i, 0, 1);
            }
            row = 0;
            string[] colName = {"fathers_age_of_death", "mothers_age_of_death", "cigs_day", 
                "smoking_history", "systolic_blood_pressure", "avg_grams_fat_day", "heart_disease", 
                "cancer", "hospitalized", "dangerous_activities", "dob", "policy_end"};
            while (reader.Read())
            {
                D.setData(row, 1, convertMonth(reader.GetString(reader.GetOrdinal(colName[0]))));
                D.setData(row, 2, convertMonth(reader.GetString(reader.GetOrdinal(colName[1]))));
                D.setData(row, 3, (double)(reader.GetDecimal(reader.GetOrdinal(colName[2]))));
                D.setData(row, 4, convertMonth(reader.GetString(reader.GetOrdinal(colName[3]))));
                D.setData(row, 5, (double)(reader.GetDecimal(reader.GetOrdinal(colName[4]))));
                D.setData(row, 6, (double)(reader.GetDecimal(reader.GetOrdinal(colName[5]))));
                D.setData(row, 7, convertBoolean(reader.GetBoolean(reader.GetOrdinal(colName[6]))));
                D.setData(row, 8, convertBoolean(reader.GetBoolean(reader.GetOrdinal(colName[7]))));
                D.setData(row, 9, convertBoolean(reader.GetBoolean(reader.GetOrdinal(colName[8]))));
                D.setData(row, 10, dangerousCount(reader.GetString(reader.GetOrdinal(colName[9]))));
                y.setData(row, 0, convertDate(reader.GetDateTime(reader.GetOrdinal(colName[10])), 
                    reader.GetDateTime(reader.GetOrdinal(colName[11]))));
                row++;
            }
            conn.Close();
            double ageOfDeath = PredictAgeAtDeath(D, y, client);
            DateTime today = DateTime.Now;
            int restOfMonth = monthCount(dob, today, ageOfDeath);
            double rate = averageInflationRate() + 1;
            double premium = 0;
            double payOff = Convert.ToDouble(payoffAmount);
            payOff = payOff * PROFIT_RATE /(Math.Pow(rate, restOfMonth - 1));
            double accumRate = 0;
            for(int i = 0; i < restOfMonth; i ++)
            {
                accumRate += 1 / (Math.Pow(rate, i));
            }
            premium = payOff / accumRate;
            return premium;
        }

        private double convertBoolean(Boolean b)
        {
            double result = b? 1 : 0;
            return result;
        }

        private double averageInflationRate()
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            string inflate = DateTime.Now.ToString("yyyy/MM/01");
            String query = "execute get_inflation_rate '" + inflate + "'";
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
            double[] inflation = new double[row];
            row = 0;
            while (reader.Read())
            {
                inflation[row] = Convert.ToDouble(reader.GetString(reader.GetOrdinal("inflation")));
                row ++;
            }
            conn.Close();
            row --;
            double averageRate = 0;
            for(int i = 1; i < inflation.Length; i ++)
            {
                averageRate += inflation[i] - inflation[i - 1];
            }
            averageRate /= row;
            return averageRate;
        }

        private int monthCount(DateTime dob, DateTime startDate, double ageOfDeath)
        {
            double yearBeforePolicy = convertDate(dob, startDate);
            double restOfYear = ageOfDeath - yearBeforePolicy;
            int restOfMonth = (int)(restOfYear * MONTH);
            return restOfMonth;
        }

        private double dangerousCount(string dangerousAct)
        {
            double dangerAct = 0;
            if(dangerousAct.Length > 0) dangerAct++;
            for(int i = 0; i < dangerousAct.Length; i ++)
            {
                char x = dangerousAct[i];
                if(x == ',') dangerAct++;
            }
            return dangerAct;
        }

        private double convertDate(DateTime dob, DateTime eod)
        {
            string dob1 = dob.ToString("yyyy-MM-dd");
            string eod1 = eod.ToString("yyyy-MM-dd");
            string[] start = dob1.Split('-');
            string[] end = eod1.Split('-');
            int length = start.Length;
            double[] startNum = new double[length];
            double[] endNum = new double[length];
            for(int i = 0; i < length; i ++)
            {
                startNum[i] = Convert.ToDouble(start[i]);
                endNum[i] = Convert.ToDouble(end[i]);
            }
            double date = (endNum[2] - startNum[2]) / DATE;
            double month = (endNum[1] - startNum[1] + date) / MONTH;
            double year = endNum[0] - startNum[0] + month;
            return year;
        }

        private double convertMonth(string c)
        {
            if(c == "N/A") return 0;
            double convert = Convert.ToDouble(c);
            int data = (int)(convert);
            int year = data / MONTH_CONVERT;
            double month = data % MONTH_CONVERT;
            month /= MONTH;
            double result = year + month;
            return result;
        }

        private double PredictAgeAtDeath(Matrix D, Matrix y, Matrix client)
        {
            Matrix transpose = D.transpose();
            Matrix betaHat = (transpose * D).invert();
            betaHat *= transpose;
            betaHat *= y;
            int row = betaHat.getRow();
            double result = betaHat.getData(0, 0);
            for(int i = 1; i < row; i ++)
            {
                double beta = betaHat.getData(i, 0);
                double x = client.getData(0, i - 1);
                result += (beta * x);
            }
            return result;
        }
    }
}
