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
    public partial class DelinquentPolicyInfo : Form
    {
        public DelinquentPolicyInfo()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelPolicyButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this policy ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //LIC_KIHD_MW.Policy.Cancel();
                MessageBox.Show("Policy has been cancelled successfully");// If 'Yes', do something here.
            }
            else
            {

            }
        }

        private void DelinquentPolicyInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
