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
    public partial class addBeneficiary : Form
    {
        private string fn;
        private string ln;
        public string FN
        {
            get { return fn; }
            set { fn = value; }

        }
        public string LN
        {
            get { return ln ; }
            set { ln = value; }

        }
        public addBeneficiary()
        {
            InitializeComponent();
            
        }
        
       

        private void add_Click(object sender, EventArgs e)
        {
            FN = firstName.Text;
            LN = lastName.Text;
        }

        private void addBeneficiary_Load(object sender, EventArgs e)
        {

        }
    }
}
