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
    public partial class PolicyHistory : Form
    {
        private string[,] history;
        public PolicyHistory(string[,] his)
        {
            InitializeComponent();
            history = his;
            for (int i = 0; i < history.GetLength
                 (0); i++)
            {
                string[] row = new string[history.GetLength(1)];
                for (int j = 0; j < history.GetLength(1); j++)
                {
                    row[j] = history[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PolicyHistory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
