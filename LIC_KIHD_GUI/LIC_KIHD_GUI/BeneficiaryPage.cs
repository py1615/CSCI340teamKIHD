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
    public partial class BeneficiaryPage : Form
    {
        private string[,] bene;
        public BeneficiaryPage(string[,] beneficiary )
        {
            InitializeComponent();
            bene = beneficiary;
            for (int i = 0; i < bene.GetLength(0); i++)
            {
                string[] row = new string[bene.GetLength(1)];
                for (int j = 0; j < bene.GetLength(1); j++)
                {

                    row[j] = bene[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BeneficiaryPage_Load(object sender, EventArgs e)
        {

        }
    }
}
