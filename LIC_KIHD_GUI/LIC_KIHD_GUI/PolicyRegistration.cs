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
    public partial class PolicyRegistration : Form
    {
        public PolicyRegistration()
        {
            InitializeComponent();
        }

        private void HDYes_CheckedChanged(object sender, EventArgs e)
        {
            HDNo.Checked = !HDYes.Checked;
        }

        private void HDNo_CheckedChanged(object sender, EventArgs e)
        {
            HDYes.Checked = !HDNo.Checked;
        }

        private void CancerYes_CheckedChanged(object sender, EventArgs e)
        {
            CancerNo.Checked = !CancerYes.Checked;
        }

        private void CancerNo_CheckedChanged(object sender, EventArgs e)
        {
            CancerYes.Checked = !CancerNo.Checked;
        }

        private void HosYes_CheckedChanged(object sender, EventArgs e)
        {
            HosNo.Checked = !HosYes.Checked;
        }

        private void HosNo_CheckedChanged(object sender, EventArgs e)
        {
            HosYes.Checked = !HosNo.Checked;
        }
    }
}
