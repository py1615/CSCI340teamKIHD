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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UtYes_CheckedChanged(object sender, EventArgs e)
        {
            Manager.Checked = !Agent.Checked;
        }

        private void UtNo_CheckedChanged(object sender, EventArgs e)
        {
            Agent.Checked = !Manager.Checked;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
