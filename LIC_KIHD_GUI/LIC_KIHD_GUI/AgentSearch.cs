﻿using System;
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
            Hide();
            loginPage login = new loginPage();
            login.Closed += (s, arges) => this.Close();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string policyN = "12312312312321";
            DateTime time = DateTime.Now;
            LIC_KIHD_MW.Address address = new LIC_KIHD_MW.Address("A","b","c","d");
            LIC_KIHD_MW.PolicyHolder holder = new LIC_KIHD_MW.PolicyHolder("a", "b", time,address);

            View.Text = "View";
            View.UseColumnTextForButtonValue = true;
            if(e.ColumnIndex == dataGridView1.Columns["View"].Index )
            {
 
                policyN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Policyinfo infoPage = new Policyinfo(policyN);
                infoPage.ShowDialog();
            }

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
           
            PolicyRegistration policyRegiser = new PolicyRegistration();
            
            policyRegiser.ShowDialog();
        }

        private void agentSearchButton_Click(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();
            if (string.IsNullOrEmpty(policyNumBox.Text) && string.IsNullOrEmpty(clientNameBox.Text))
            {
                MessageBox.Show("Please enter policy number and client's name!");
            }
            else
            {
                string[,] searchResult = LIC_KIHD_MW.Agent.search(policyNumBox.Text, clientNameBox.Text, agentId);

                if (searchResult != null)
                {
                    for (int i = 0; i < searchResult.GetLength(0); i++)
                    {
                        string[] row = new string[searchResult.GetLength(1)];
                        for (int j = 0; j < searchResult.GetLength(1); j++)
                        {
                            row[j] = searchResult[i, j];
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("The information you entered is wrong!");
                    policyNumBox.Clear();
                    clientNameBox.Clear();
                }
            }
        }
        

        private void clientNameBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
