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
    public partial class QuoteForm : Form
    {
        private string agentID;
        private string payoffA;
        private string monthPremium;
        private string hd;
        private string ca;
        private string ho;
        public QuoteForm(string FN, string LN, string birth, string address, string city, string state, string zip, string father, string mother, string cigarette, string smoke, 
                        string blood, string grams, string heartDisease, string cancer, string hospital, string dangerous, string payoff, string premium, string agent, string hdpass,
                        string cancerpass, string hospass
                        )
        {
            InitializeComponent();
            firstName.Text = FN;
            LastName.Text = LN;
            dateOfBirth.Text = birth;
            StreetAdress.Text = address;
            CityLabel.Text = city;
            StateLabel.Text = state;
            zipCode.Text = zip;
            FatherAgeAtDeath.Text = father;
            MotherAgeAtDeath.Text = mother;
            CigarettesPerDay.Text = cigarette;
            SmokingHistory.Text = smoke;
            BloodPressure.Text = blood;
            AverageGrams.Text = grams;
            HeartDisease.Text = heartDisease;
            CancerLabel.Text = cancer;
            Hospitalized.Text = hospital;
            DangerousActivities.Text = dangerous;
            labelForPayoffAmount.Text =  "$"+ payoff;
            payoffA = payoff;
            PolicyStart.Text = DateTime.Now.ToString();
            MonthlyPremium.Text = "$" + premium;
            monthPremium = premium;
            //monthPremium = "100";
            agentID = agent;
            hd = hdpass;
            ca = cancerpass;
            ho = hospass;
        }

        private void QuoteForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to make some changes?",
                                        "Caution",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();

            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void PolicyStart_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            
            
           
        }
        

        private void MonthlyPremium_Click(object sender, EventArgs e)
        {

        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            LIC_KIHD_MW.Address addre = new LIC_KIHD_MW.Address("", "", "", "");
            LIC_KIHD_MW.PolicyHolder holder = new LIC_KIHD_MW.PolicyHolder("", "", "", addre);
            LIC_KIHD_MW.Beneficiary BENE = new LIC_KIHD_MW.Beneficiary("", "");
            LIC_KIHD_MW.Policy po = new LIC_KIHD_MW.Policy(holder, "", 1, 1, 1, 1, 1, 1, 1, "", "", "", "", BENE, "");
     
            // List<LIC_KIHD_MW.Beneficiary> beneficiary = new List<LIC_KIHD_MW.Beneficiary>();
           
            DateTime dod = DateTime.Parse(dateOfBirth.Text);
            string policynumber = po.PolicyNumReg(firstName.Text, LastName.Text, dod, StreetAdress.Text, CityLabel.Text, StateLabel.Text, zipCode.Text, FatherAgeAtDeath.Text
                , MotherAgeAtDeath.Text, CigarettesPerDay.Text, SmokingHistory.Text, BloodPressure.Text, AverageGrams.Text, hd, ca, ho
                , DangerousActivities.Text, payoffA, monthPremium, agentID);
            addBeneficiary addB = new addBeneficiary(policynumber);
            addB.Closed += (s, arges) => this.Close();
            // complete register and return back
            MessageBox.Show("The policy had been created successfully, and your policy number is " + policynumber);
           
            addB.ShowDialog();
            
        }

        private void PolicyNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
