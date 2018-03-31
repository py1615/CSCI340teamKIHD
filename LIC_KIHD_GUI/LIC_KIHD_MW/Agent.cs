using System;
using System.Collections.Generic;
using System.Text;

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
        public void login(string userName, string passWord)
        {

        }
        public void logout()
        {

        }
    }
}
