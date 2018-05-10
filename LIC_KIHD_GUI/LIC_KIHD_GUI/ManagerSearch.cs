﻿using System;
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
            
            PolicyRegistration policyRegiser = new PolicyRegistration(agentID);
            
            policyRegiser.ShowDialog();
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
            string policyNumber = "null";
            string clientFirstName = "null";
            string clientLastName = "null";
            string agentFirstName = "null";
            string agentLastName = "null";
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(barForClientLastN.Text) &&
                string.IsNullOrEmpty(BarForAgentLastN.Text))
            {
                MessageBox.Show("Please enter policy number and client's name!");
            }
            else 
            {
                if(!string.IsNullOrEmpty(textBox1.Text))
                {
                    policyNumber = textBox1.Text;
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    clientFirstName = textBox3.Text;
                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    agentFirstName = textBox2.Text;
                }
                if(!string.IsNullOrEmpty(barForClientLastN.Text))
                {
                    clientLastName = barForClientLastN.Text;
                }
                if(!string.IsNullOrEmpty(BarForAgentLastN.Text))
                {
                    agentLastName = barForClientLastN.Text;
                }
                LIC_KIHD_MW.Manager agent = new LIC_KIHD_MW.Manager("", "", "", "","","");
               
                List<string[]> search = agent.managerSearch(policyNumber, clientFirstName, clientLastName, agentFirstName, agentLastName);
                //search = agent.managerSearch(policyNumber, clientFirstName, clientLastName, agentID);
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
                    textBox1.Clear();
                    textBox3.Clear();
                    barForClientLastN.Clear();
                    textBox2.Clear();
                    BarForAgentLastN.Clear();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string policyN;
            this.ViewButton.UseColumnTextForButtonValue = true;
            this.ViewButton.Text = "View";
            LIC_KIHD_MW.Agent agent = new LIC_KIHD_MW.Agent("", "", "", "");
            if (e.ColumnIndex == dataGridView1.Columns["ViewButton"].Index)
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

        private void managerSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
