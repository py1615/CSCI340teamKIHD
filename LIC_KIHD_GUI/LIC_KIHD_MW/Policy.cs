using System;
using System.Collections.Generic;
using System.Text;

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
        public void cancel(Policy policy)
        {

        }
        public void makeClaim(Policy policy)
        {

        }
        private Report SendReport(List<Policy> policy)
        {
            Report rept = new Report();
            return rept;
        }
        public double calculatePremium(Policy policy)
        {
            double result;
            return result;
        }
        private double predictAgeAtDeath(Matrix D, Matrix y)
        {
            double age;
            return age;
        }
    }
}
