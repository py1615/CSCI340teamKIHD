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
            if (barForPassword.Text == "12" && barForID
                .Text == "12")
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show(String.Format("Username or Password is Incorrect"));

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
    }
}
