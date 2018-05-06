using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Policy
    {
        private readonly int DATE_CONVERT = 10000;
        private readonly int MONTH_CONVERT = 100;
        private readonly int DATE = 30;
        private readonly int MONTH = 12;
        private readonly int HEALTH_RELATE = 10;
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

        internal PolicyHolder Insured { get => insured; set => insured = value; }
        public string PolicyNum { get => policyNum; set => policyNum = value; }
        public double PayoffAmount { get => payoffAmount; set => payoffAmount = value; }
        internal Beneficiary Beneficiary { get => beneficiary; set => beneficiary = value; }
        public double FatherDeathAge { get => fatherDeathAge; set => fatherDeathAge = value; }
        public double MotherDeathAge { get => motherDeathAge; set => motherDeathAge = value; }
        public double CigsPerDay { get => cigsPerDay; set => cigsPerDay = value; }
        public double SmokingHistory { get => smokingHistory; set => smokingHistory = value; }
        public double BloodPressure { get => bloodPressure; set => bloodPressure = value; }
        public double GramsFatPerDay { get => gramsFatPerDay; set => gramsFatPerDay = value; }
        public string HeartDisease { get => heartDisease; set => heartDisease = value; }
        public string Cancer { get => cancer; set => cancer = value; }
        public string Hospitalized { get => hospitalized; set => hospitalized = value; }
        public string DangerousAct { get => dangerousAct; set => dangerousAct = value; }
        public string AgentID { get => agentID; set => agentID = value; }

        public Policy(PolicyHolder theInsured, string thePolicyNum, double thePayOffAmount, double theFatherDeathAge, double theMotherDeathAge,
            double theCigsPerDay, double theSmokingHistory, double theBloodPressure, double theGramsFatPerDay, string theHeartDisease,
            string theCancer, string theHospitalized, string theDangerousAct, Beneficiary theHeir, string theAgent)
        {
            Insured = theInsured;
            PayoffAmount = thePayOffAmount;
            AgentID = theAgent;
            Beneficiary = theHeir;
            FatherDeathAge = theFatherDeathAge;
            MotherDeathAge = theMotherDeathAge;
            CigsPerDay = theCigsPerDay;
            SmokingHistory = theSmokingHistory;
            BloodPressure = theBloodPressure;
            GramsFatPerDay = theGramsFatPerDay;
            HeartDisease = theHeartDisease;
            Cancer = theCancer;
            Hospitalized = theHospitalized;
            DangerousAct = theDangerousAct;
            PolicyNum = thePolicyNum;
        }

        public String PolicyNumReg(string firstName, string lastName, string dob, string streetAddress,
            string city, string state, string zip, string fatherDeathAge, string motherDeathAge, string cigPerDay,
            string smokingHistory, string bloodPressure, string avegGrams, string heartDisease, string cancer,
            string hospitalized, string dangerousAct, string payoffAmount, string premium,  string agentID)
        {
            
        }

        public void Cancel(string policyNum)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute cancel '" + policyNum + "'";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void MakeClaim(Policy policy)
        {

        }
        private Report SendReport(List<Policy> policy)
        {
            Report rept = new Report();
            return rept;
        }
        public double CalculatePremium(string payoffAmount, string dob, string fathersDeathAge, string mothersDeathAge, 
            string cigPerDay, string smokingHistory, string bloodPressure, string avgFatPerDay, 
            string heartDisease, string theCancer, string hospitalized, string dangerousAct)
        {
            double fatherDA = convertMonth(fathersDeathAge);
            double motherDA = convertMonth(mothersDeathAge);
            double cigsPerDay = Convert.ToDouble(cigPerDay);
            double history = convertMonth(smokingHistory);
            double bloodP = Convert.ToDouble(bloodPressure);
            double avgFat = Convert.ToDouble(avgFatPerDay);
            double heartD = Convert.ToDouble(HeartDisease);
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
                D.setData(row, 1, converMonth(reader.GetString(reader.GetOrdinal(colName[0]))));
                D.setData(row, 2, converMonth(reader.GetString(reader.GetOrdinal(colName[1]))));
                D.setData(row, 3, Convert.ToDouble(reader.GetString(reader.GetOrdinal(colName[2]))));
                D.setData(row, 4, converMonth(reader.GetString(reader.GetOrdinal(colName[3]))));
                D.setData(row, 5, Convert.ToDouble(reader.GetString(reader.GetOrdinal(colName[4]))));
                D.setData(row, 6, Convert.ToDouble(reader.GetString(reader.GetOrdinal(colName[5]))));
                D.setData(row, 7, Convert.ToDouble(reader.GetString(reader.GetOrdinal(colName[6]))));
                D.setData(row, 8, Convert.ToDouble(reader.GetString(reader.GetOrdinal(colName[7]))));
                D.setData(row, 9, Convert.ToDouble(reader.GetString(reader.GetOrdinal(colName[8]))));
                D.setData(row, 10, dangerousCount(reader.GetString(reader.GetOrdinal(colName[9]))));
                y.setData(row, 0, convertDate(reader.GetString(reader.GetOrdinal(colName[10])), 
                    reader.GetString(reader.GetOrdinal(colName[11]))));
                row++;
            }
            conn.Close();
            double ageOfDeath = PredictAgeAtDeath(D, y, client);
            string today = DateTime.Now.ToString("yyyy - MM - dd");
            int restOfMonth = monthCount(dob, today, ageOfDeath);
            double premium = 0;
            for(int i = 0; i < restOfMonth; i ++)
            {

            }
            double result = 0;
            return result;
        }

        private int monthCount(string dob, string startDate, double ageOfDeath)
        {
            double yearBeforePolicy = convertDate(dob, startDate);
            double restOfYear = ageOfDeath - yearBeforePolicy;
            int restOfMonth = restOfYear * MONTH;
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

        private double convertDate(string dob, string eod)
        {
            string[] start = dob.Split(" - ");
            string[] end = eod.Split(" - ");
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
            double convert = Convert.ToDouble(c);
            int day = convert;
            int year = day / MONTH_CONVERT;
            double month = day % MONTH_CONVERT;
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
            int row = betaHat.Row();
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
