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
            label25.Text = policyN;
            label26.Text = policy[0];
            label27.Text = policy[1];
            label28.Text = policy[2];
            label29.Text = policy[3];
            label30.Text = policy[4];
            label31.Text = policy[5];
            label32.Text = policy[6];
            label33.Text = policy[7];
            label34.Text = policy[8];
            label35.Text = policy[9];
            label36.Text = policy[10];
            label37.Text = policy[11];
            label38.Text = policy[12];
            label39.Text = policy[13];
            label40.Text = policy[14];
            label41.Text = policy[15];
            label42.Text = policy[16];
            label43.Text = policy[17];
            label44.Text = policy[18];
            label45.Text = policy[19];
            label46.Text = policy[20];
            label47.Text = policy[21];
  
           

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
            BeneficiaryPage beneficiary = new BeneficiaryPage();
            beneficiary.ShowDialog();
        }
    }
}
