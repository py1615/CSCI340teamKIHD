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
    public partial class Policyinfo : Form
    {
        public Policyinfo(string[] policy,string policyN)
        {

            InitializeComponent();
            labelForPolicyNumber.Text = policyN;
            labelForFirstName.Text = policy[0];
            labelForLastName.Text = policy[1];
            labelDateOfBirth.Text = policy[2];
            labelForStreet.Text = policy[3];
            labelForCity.Text = policy[4];
            labelForState.Text = policy[5];
            labelZip.Text = policy[6];
            
            
            labelForFatherAtAge.Text = convertAge(policy[7]);
            labelForMotherAtAge.Text = convertAge(policy[8]);
            labelForCigPerDay.Text = policy[9];
            labelForSmokeHistory.Text = convertAge(policy[10]);
            labelForBloodPressure.Text = policy[11];
            labelForAvgGrams.Text = policy[12];
            labelForHeartDisease.Text = policy[13];
            labelForCancer.Text = policy[14];
            labelForHospitalized.Text = policy[15];
            labelForDangerousActivities.Text = policy[16];
            labelForStartDate.Text = policy[17];
            labelForPolicyEndDate.Text = policy[18];
            labelPayoffAmount.Text = policy[19];
            labelForPremium.Text = policy[20];
            labelForStatus.Text = policy[21];
  
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CancelPolicyButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this policy ??",
                                     "Cancellation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //LIC_KIHD_MW.Policy.Cancel();
                MessageBox.Show("Policy has been cancelled successfully");// If 'Yes', do something here.
                this.Close();
            }
            else
            {

            }
        }

        private void Policyinfo_Load(object sender, EventArgs e)
        {
            
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewBeneficiary_Click(object sender, EventArgs e)
        {
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            string[,] get = agent.beneficiaryName(labelForPolicyNumber.Text);
            BeneficiaryPage beneficiary = new BeneficiaryPage(get);
            beneficiary.ShowDialog();
        }

        private void PaymentHistory_Click(object sender, EventArgs e)
        {
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            string[,] get = agent.getPayments(labelForPolicyNumber.Text);
            PolicyHistory policyHis = new PolicyHistory(get);
            policyHis.ShowDialog();
        }

        private void buttonClaim_Click(object sender, EventArgs e)
        {
            LIC_KIHD_MW.Address addre = new LIC_KIHD_MW.Address("", "", "", "");
            LIC_KIHD_MW.PolicyHolder holder = new LIC_KIHD_MW.PolicyHolder("", "", "", addre);
            LIC_KIHD_MW.Beneficiary BENE = new LIC_KIHD_MW.Beneficiary("", "");
            LIC_KIHD_MW.Policy po = new LIC_KIHD_MW.Policy(holder, "", 1, 1, 1, 1, 1, 1, 1, "", "", "", "", BENE, "");

            bool highNetLoss= po.MakeClaim(labelForPolicyNumber.Text);
            if(highNetLoss)
            {
                MessageBox.Show("This policy has high impact new loss!");
            }
            else
            {
                MessageBox.Show("This policy has been claimed successfully");
            }
        }
        private string convertAge(string ageForConverting)
        {
            char[] convert = ageForConverting.ToCharArray();
            char[] newChar = new char[convert.Length];
            if (!(ageForConverting == "0"))
            {
       

                if (convert[0] == 0)
                {
                    newChar[0] = convert[1];
                    newChar[1] = convert[2];
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        newChar[i] = convert[i];
                    }
                }
            }
            string converted = new string(newChar);

            return converted;
        }
    }
}
