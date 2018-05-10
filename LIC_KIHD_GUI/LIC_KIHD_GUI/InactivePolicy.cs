using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIC_KIHD_GUI
{
    public partial class InactivePolicy : Form
    {
        private LIC_KIHD_MW.Agent agent;
        public InactivePolicy(string[] policy, string policyN)
        {
            InitializeComponent();
            labelForFirstName.Text = policyN;
            labelForFirstName.Text = policy[0];
            labelForLastName.Text = policy[1];
            labelFordob.Text = policy[2];
            labelForStreetAddress.Text = policy[3];
            labelForCity.Text = policy[4];
            labelForState.Text = policy[5];
            labelForZipCode.Text = policy[6];
            labelForFatherDeathAtAge.Text = policy[7];
            labelForMotherDeathAtAge.Text = policy[8];
            labelForCigPerDay.Text = policy[9];
            labelForSmokeHistory.Text = policy[10];
            labelForBloodPressure.Text = policy[11];
            labelAvgFat.Text = policy[12];
            labelForHeartDisease.Text = policy[13];
            labelForCancer.Text = policy[14];
            labelForHospitalized.Text = policy[15];
            labelForDangerousActivities.Text = policy[16];
            labelForPolicyStartDate.Text = policy[17];
            labelForPolicyEndDate.Text = policy[18];
            labelForPremium.Text = policy[20];
            labelForPolicyNumber.Text = policyN;
            labelForPayoff.Text = policy[19];
            
        }

        private void InactivePolicy_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewHistory_Click(object sender, EventArgs e)
        {
            
            string[,] get = agent.getPayments(labelFordob.Text);
            PolicyHistory policyHis = new PolicyHistory(get);
            policyHis.ShowDialog();
        }

        private void viewBeneficiary_Click(object sender, EventArgs e)
        {
            
            string[,] get = agent.beneficiaryName(labelFordob.Text);
            BeneficiaryPage beneficiary = new BeneficiaryPage(get);
            beneficiary.ShowDialog();
        }
    }
}
