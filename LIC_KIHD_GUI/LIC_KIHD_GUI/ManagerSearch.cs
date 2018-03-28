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

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UserRegistrationButton_Click(object sender, EventArgs e)
        {
            UserRegister register = new UserRegister();
            register.Show();
            Hide();
        }
    }
}
