using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LIC_KIHD_MW
{
    class Policy
    {
        private string policyNum;
        private double payoffAmount;
        private Agent agent;
        private double duration;
        private Beneficiary beneficiary;
        private double fartherDeathAge;
        private double motherDeathAge;
        private double cigsPerDay;
        private double smokingHistory;
        private double bloodPressure;
        private double gramsFatPerDay;
        private Boolean heartDisease;
        private Boolean cancer;
        private Boolean hospitalized;
        private string dangerousAct;
        public Policy()
        {

        }
        public void Cancel(Policy policy)
        {
            String connectionString = "Data Source=DATABASE" + "\\" + "CSCI3400011030;Initial Catalog=LIC_KIHD;"
        + "Integrated Security=false;user='LIC_KIHD_MW';pwd='KIHD';";
            SqlConnection conn = new SqlConnection(connectionString);
            String policyNumber = policy.policyNum;
            String query = "update Policy set policy_status = 'cancel' where policy_no = '" + policyNumber + "'";
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
