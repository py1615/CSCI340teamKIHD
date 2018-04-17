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
    public partial class AgentSearch : Form
    {
        public AgentSearch()
        {
            InitializeComponent();
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
            

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Hide();
            PolicyRegistration policyRegiser = new PolicyRegistration();
            policyRegiser.Closed += (s, arges) => this.Close();
            policyRegiser.Show();
        }

        private void agentSearchButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            //List<LIC_KIHD_MW.Policy> policy = LIC_KIHD_MW.Agent.search(policyNumBox.Text, false);

            dataGridView1.DataSource = table;
        }
    }
}
