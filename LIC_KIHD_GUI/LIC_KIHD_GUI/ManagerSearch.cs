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
            login.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            
            PolicyRegistration policyRegiser = new PolicyRegistration();
            
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
            DataTable table = new DataTable();
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string policyN;
            this.ViewButton.UseColumnTextForButtonValue = true;
            this.ViewButton.Text = "View";
            if (e.ColumnIndex == dataGridView1.Columns["View"].Index)
            {

                policyN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Policyinfo infoPage = new Policyinfo(policyN);
                infoPage.ShowDialog();
            }
        }

        private void managerSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
