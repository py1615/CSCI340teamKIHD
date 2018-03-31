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
        static Func<Control, IEnumerable<Control>> GetControls =
        (control) => control
            .Controls
            .Cast<Control>().SelectMany(x => GetControls(x))
            .Concat(control.Controls.Cast<Control>());

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aveGramsBox_TextChanged(object sender, EventArgs e)
        {
            string tString = aveGramsBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    aveGramsBox.Text = "";
                    return;
                }
            }
        }

        private void addBeneficiary_Click(object sender, EventArgs e)
        {
            bool fieldFilled = true;
            foreach (TextBox tb in GetControls(this).OfType<TextBox>())
            {

                if (string.IsNullOrEmpty(tb.Text))
                {
                    fieldFilled = false;

                }
            }

            if (fieldFilled)
            {
                Hide();
                managerSearch manaSearch = new managerSearch();
                manaSearch.Closed += (s, arges) => this.Close();
                manaSearch.Show();
            }
            else
            {
                MessageBox.Show(String.Format("You need to fill all the boxes"));
            }
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            string tString = FirstNameBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    FirstNameBox.Text = "";
                    return;
                }
            }
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            string tString = LastNameBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    LastNameBox.Text = "";
                    return;
                }
            }
        }

        private void BirthBox_TextChanged(object sender, EventArgs e)
        {
            string tString = BirthBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    BirthBox.Text = "";
                    return;
                }
            }
        }

        private void CityBox_TextChanged(object sender, EventArgs e)
        {
            string tString = CityBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    CityBox.Text = "";
                    return;
                }
            }
        }

        private void ZipBox_TextChanged(object sender, EventArgs e)
        {
            string tString = ZipBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    ZipBox.Text = "";
                    return;
                }
            }
        }

        private void FatherBox_TextChanged(object sender, EventArgs e)
        {
            string tString = FatherBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    FatherBox.Text = "";
                    return;
                }
            }
        }

        private void motherBox_TextChanged(object sender, EventArgs e)
        {
            string tString = motherBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    motherBox.Text = "";
                    return;
                }
            }
        }

        private void cigBox_TextChanged(object sender, EventArgs e)
        {
            string tString = cigBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    cigBox.Text = "";
                    return;
                }
            }
        }

        private void smokeBox_TextChanged(object sender, EventArgs e)
        {
            string tString = smokeBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    smokeBox.Text = "";
                    return;
                }
            }
        }

        private void bloodBox_TextChanged(object sender, EventArgs e)
        {
            string tString = bloodBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    bloodBox.Text = "";
                    return;
                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string tString = textBox14.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    textBox14.Text = "";
                    return;
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string tString = textBox15.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    textBox15.Text = "";
                    return;
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            string tString = textBox16.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    textBox16.Text = "";
                    return;
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            string tString = textBox17.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    MessageBox.Show("Please enter a valid information");
                    textBox17.Text = "";
                    return;
                }
            }
        }
    }
}
