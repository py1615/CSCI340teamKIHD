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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userAccess = LIC_KIHD_MW.Agent.login(barForID.Text, barForPassword.Text);
            if (userAccess  == "A") // Agent access the search page// made up id and pw
            {
                Hide();
                AgentSearch agent = new AgentSearch();
                agent.Closed += (s, arges) => this.Close();
                agent.ShowDialog();
                
            }
            else if (userAccess == "M")
            {
                managerSearch agent = new managerSearch();
                agent.Closed += (s, arges) => this.Close();
                agent.Show();
                Hide();
            }//manager access the search page
            else
            { 
                MessageBox.Show(String.Format("Username or Password is Incorrect")); //wrong id or pw

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barForID_TextChanged(object sender, EventArgs e)
        {

        }

        private void barForPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            this.Closed += (s, arges) => Application.Exit();
        }
    }
}
