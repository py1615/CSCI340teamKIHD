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
    public partial class addBeneficiary : Form
    {
        private string fn;
        private string ln;
        private string policyN;
        public string FN
        {
            get { return fn; }
            set { fn = value; }

        }
        public string LN
        {
            get { return ln ; }
            set { ln = value; }

        }
        public addBeneficiary(string policyNumber)
        {
            InitializeComponent();
            policyN = policyNumber;
        }
        
       

        private void add_Click(object sender, EventArgs e)
        {
     
            LIC_KIHD_MW.Address addre = new LIC_KIHD_MW.Address("", "", "", "");
            LIC_KIHD_MW.PolicyHolder holder = new LIC_KIHD_MW.PolicyHolder("", "", "", addre);
            LIC_KIHD_MW.Beneficiary BENE = new LIC_KIHD_MW.Beneficiary("", "");
            LIC_KIHD_MW.Policy po = new LIC_KIHD_MW.Policy(holder, "", 1, 1, 1, 1, 1, 1, 1, "", "", "", "", BENE, "");

            po.addBeneficiary(policyN, firstName.Text, lastName.Text);
            addBeneficiary addMore = new addBeneficiary(policyN);
            Hide();
            addMore.Closed += (s, arges) => this.Close();
            addMore.ShowDialog();
        }

        private void addBeneficiary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Have you done with adding beneficiary?",
                                          "Caution",
                                          MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();

            }
            
        }
    }
}
