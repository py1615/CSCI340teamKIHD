using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Policy
    {
        private PolicyHolder insured;
        private string policyNum;
        private double payoffAmount;
        private Agent agent;
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
            string theCancer, string theHospitalized, string theDangerousAct, Beneficiary theHeir, Agent theAgent)
        {
            insured = theInsured;
            payoffAmount = thePayOffAmount;
            agent = theAgent;
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
        public String PolicyNumReg()
        {
            return "";
        }
        public void Cancel(Policy policy)
        {
            String connectionString = LIC_KIHD_GUI.Properties.Settings.Default.SQL_connection;
            SqlConnection conn = new SqlConnection(connectionString);
            String policyNumber = policy.policyNum;
            String query = "execute cancel '" + policyNumber + "'";
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
        public double CalculatePremium(Policy policy)
        {
            double result = 0;
            return result;
        }
        private double PredictAgeAtDeath(Matrix D, Matrix y)
        {
            double age = 0;
            return age;
        }
    }
}
