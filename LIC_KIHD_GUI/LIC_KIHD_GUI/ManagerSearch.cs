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
    public partial class managerSearch : Form
    {
        public managerSearch()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You are successfully logged out"));
            Hide();
            loginPage login = new loginPage();
            login.Closed += (s, arges) => this.Close();
            login.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Hide();
            PolicyRegistration policyRegiser = new PolicyRegistration();
            policyRegiser.Closed += (s, arges) => this.Close();
            policyRegiser.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UserRegistrationButton_Click(object sender, EventArgs e)
        {
            Hide();
            UserRegister register = new UserRegister();
            register.Closed += (s, arges) => this.Close();
            register.Show();
            
        }

        private void agentSearchButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridView1.DataSource = table;
        }
    }
}
