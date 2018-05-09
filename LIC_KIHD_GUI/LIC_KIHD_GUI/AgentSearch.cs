using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIC_KIHD_GUI
{
    public partial class AgentSearch : Form
    {
        private string agentId;

        public AgentSearch(string ID)
        {
            InitializeComponent();
            agentId = ID;
        }
       
        

        private void AgentSearch_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You are successfully logged out"));
      
            loginPage login = new loginPage();
            this.Hide();
            login.Closed += (s, arges) => this.Close();
            login.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LIC_KIHD_MW.Policy result = new LIC_KIHD_MW.Policy();//need MW
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            string policyN = "";  //need MW
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;

            if (e.ColumnIndex == dataGridView1.Columns["View"].Index)
            {

                policyN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] searchInfo = agent.searchOnClick(policyN);
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

            }

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
           
            PolicyRegistration policyRegiser = new PolicyRegistration(agentId);
            
            policyRegiser.ShowDialog();
        }

        private void agentSearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string policyNumber = "null";
            string clientFirstName = "";
            string clientLastName = "";
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            if (string.IsNullOrEmpty(policyNumBox.Text) && string.IsNullOrEmpty(clientNameBox.Text))
            {
                MessageBox.Show("Please enter policy number and client's name!");
            }
            else
            {
                if(!string.IsNullOrEmpty(policyNumBox.Text))
                {
                    policyNumber = policyNumBox.Text;
                }
                if (!string.IsNullOrEmpty(clientNameBox.Text))
                {
                    clientFirstName = clientNameBox.Text;
                }
                if(!string.IsNullOrEmpty(ClientLastN.Text))
                {
                    clientLastName = ClientLastN.Text;
                }
                
                List<string[]> search = agent.search(policyNumber, clientFirstName, clientLastName, agentId);
                //search = agent.search(policyNumber, clientFirstName, clientLastName, agentId);
                if (search != null && search.Count > 0)
                {
                    /*for (int i = 0; i < searchResult.GetLength(0); i++)
                    {
                        string[] row = new string[searchResult.GetLength(1)];
                        for (int j = 0; j < searchResult.GetLength(1); j++)
                        {
                            row[j] = searchResult[i, j];
                        }
                        dataGridView1.Rows.Add(row);
                    }*/
                    for (int i = 0; i < search.Count; i++)
                    {
                        string[] row = new string[search[i].Length];
                        for (int j = 0; j < search[i].Length; j++)
                        {

                            row[j] = search[i][j];
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("No result is found");
                    policyNumBox.Clear();
                    clientNameBox.Clear();
                }
            }
        }
        

        private void clientNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
