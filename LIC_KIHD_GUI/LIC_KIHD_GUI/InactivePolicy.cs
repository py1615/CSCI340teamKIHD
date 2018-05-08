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
        public InactivePolicy(string[] policy, string policyN)
        {
            InitializeComponent();
            label23.Text = policyN;
            label23.Text = policy[0];
            label24.Text = policy[1];
            label25.Text = policy[2];
            label26.Text = policy[3];
            label27.Text = policy[4];
            label28.Text = policy[5];
            label29.Text = policy[6];
            label30.Text = policy[7];
            label31.Text = policy[8];
            label32.Text = policy[9];
            label33.Text = policy[10];
            label34.Text = policy[11];
            label35.Text = policy[12];
            label36.Text = policy[13];
            label37.Text = policy[14];
            label38.Text = policy[15];
            label39.Text = policy[16];
            label40.Text = policy[17];
            label41.Text = policy[18];
            label21.Text = policy[20];
            label43.Text = policyN;
            label42.Text = policy[19];
        
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
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            string[,] get = agent.getPayments(label25.Text);
            PolicyHistory policyHis = new PolicyHistory(get);
            policyHis.ShowDialog();
        }

        private void viewBeneficiary_Click(object sender, EventArgs e)
        {
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            string[,] get = agent.beneficiaryName(label25.Text);
            BeneficiaryPage beneficiary = new BeneficiaryPage(get);
            beneficiary.ShowDialog();
        }
    }
}
