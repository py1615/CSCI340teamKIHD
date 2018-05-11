using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;



namespace LIC_KIHD_GUI
{
    public partial class managerSearch : Form
    {
        private string agentID;
        public managerSearch(string id)
        {
            InitializeComponent();
            agentID = id;
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You are successfully logged out"));
            Hide();
            loginPage login = new loginPage();
            login.Closed += (s, arges) => this.Close();
            login.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            
            PolicyRegistration policyRegister = new PolicyRegistration(agentID);
            
            policyRegister.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UserRegistrationButton_Click(object sender, EventArgs e)
        {
            
            UserRegister register = new UserRegister();
           
            register.Show();
            
        }

        private void agentSearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string policyNumber = string.IsNullOrEmpty(barForPolicyNumber.Text)?  "null" : barForPolicyNumber.Text ;
            string clientFirstName = string.IsNullOrEmpty(barForClientFirstName.Text) ? "null" : barForClientFirstName.Text;
            string clientLastName = string.IsNullOrEmpty(barForClientLastN.Text) ? "null" : barForClientLastN.Text;
            string agentFirstName = string.IsNullOrEmpty(barForAgentFirstName.Text) ? "null" : barForAgentFirstName.Text;
            string agentLastName = string.IsNullOrEmpty(BarForAgentLastName.Text) ? "null" : BarForAgentLastName.Text;
            if (string.IsNullOrEmpty(barForPolicyNumber.Text) && string.IsNullOrEmpty(barForAgentFirstName.Text) && string.IsNullOrEmpty(barForClientFirstName.Text) 
                && string.IsNullOrEmpty(barForClientLastN.Text) && string.IsNullOrEmpty(BarForAgentLastName.Text))
            {
                MessageBox.Show("Please enter policy number and client's name!");
            }
            else 
            {
                
                LIC_KIHD_MW.Manager agent = new LIC_KIHD_MW.Manager(agentFirstName, agentLastName, "", "","", agentID);
               
                List<string[]> search = agent.managerSearch(policyNumber, clientFirstName, clientLastName, agentFirstName, agentLastName);
                if (search != null && search.Count > 0)
                {
                    for (int i = 0; i < search.Count; i++)
                    {
                        string[] row = new string[search[i].Length];
                        for (int j = 0; j < search[i].Length; j++)
                        {

                            row[j] = search[i][ j];
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("No result is found.");
                   
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string policyN;
            this.ViewButton.UseColumnTextForButtonValue = true;
            this.ViewButton.Text = "View";
            LIC_KIHD_MW.Agent manager = new LIC_KIHD_MW.Agent(barForAgentFirstName.Text, BarForAgentLastName.Text, "", agentID);
            if (e.ColumnIndex == dataGridView1.Columns["ViewButton"].Index)
            {

                policyN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] searchInfo = manager.searchOnClick(policyN);
                if (searchInfo[21] == "A")
                {
                    Policyinfo infoPage = new Policyinfo(searchInfo, policyN);
                    infoPage.ShowDialog();
                }
                else if (searchInfo[21] == "D")
                {
                    DelinquentPolicyInfo delinquent = new DelinquentPolicyInfo(searchInfo, policyN);
                    delinquent.ShowDialog();
                }
                else if (searchInfo[21] == "C")
                {
                    InactivePolicy inactive = new InactivePolicy(searchInfo, policyN);
                    inactive.ShowDialog();
                }
                else if(searchInfo[21] == "I")
                {
                    InactivePolicy inactive = new InactivePolicy(searchInfo, policyN);
                    inactive.ShowDialog();
                }

            }



        }

        private void managerSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void barForPolicyNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
