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
        private string HeartDisease;
        private string cancer;
        private string hospital;
        private string state;
        private string HDPassToQuote;
        private string cancerToQ;
        private string hospitalToQ;
        
        public PolicyRegistration()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void HDYes_CheckedChanged(object sender, EventArgs e)
        {
            HDNo.Checked = !HDYes.Checked;
            HeartDisease = "1";
            HDPassToQuote = "Yes";
        }

        private void HDNo_CheckedChanged(object sender, EventArgs e)
        {
            HDYes.Checked = !HDNo.Checked;
            HeartDisease = "0";
            HDPassToQuote = "No";
        }

        private void CancerYes_CheckedChanged(object sender, EventArgs e)
        {
            CancerNo.Checked = !CancerYes.Checked;
            cancer = "1";
            cancerToQ = "Yes";
        }

        private void CancerNo_CheckedChanged(object sender, EventArgs e)
        {
            CancerYes.Checked = !CancerNo.Checked;
            cancer = "0";
            cancerToQ = "No";
        }

        private void HosYes_CheckedChanged(object sender, EventArgs e)
        {
            HosNo.Checked = !HosYes.Checked;
            hospital = "1";
            hospitalToQ = "Yes";
        }

        private void HosNo_CheckedChanged(object sender, EventArgs e)
        {
            HosYes.Checked = !HosNo.Checked;
            hospital = "0";
            hospitalToQ = "No";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aveGramsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(aveGramsBox.Text.Trim());
                errorProvider1.SetError(aveGramsBox, "");
            }
            catch
            {
                errorProvider1.SetError(aveGramsBox, "Please enter a valid number！");
            }
        }

        private void addBeneficiary_Click(object sender, EventArgs e)
        {
            bool fieldFilled = true;
            bool noError = true; 
            foreach (TextBox tb in GetControls(this).OfType<TextBox>())
            {

                if (string.IsNullOrEmpty(tb.Text))
                {
                    fieldFilled = false;

                }
            }
            foreach (Control c in this.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)
                    noError = false;
            }
         
        

            if (fieldFilled /*&& comboBox1.SelectedIndex < -1*/ && noError || string.IsNullOrWhiteSpace(textBox14.Text))
            {
                state = comboBox1.SelectedItem.ToString();
                DateTime txtMyDate = DateTime.Parse(BirthBox.Text);
                double premium = LIC_KIHD_MW.Policy.CalculatePremium(textBox15.Text, txtMyDate, FatherBox.Text, motherBox.Text, cigBox.Text, smokeBox.Text, bloodBox.Text,
                        aveGramsBox.Text, HeartDisease, cancer, hospital, textBox14.Text);


                QuoteForm quote = new QuoteForm(FirstNameBox.Text, LastNameBox.Text, BirthBox.Text, AddressBox.Text, CityBox.Text, state, ZipBox.Text, FatherBox.Text, motherBox.Text,
                                    cigBox.Text, smokeBox.Text, bloodBox.Text, aveGramsBox.Text, HDPassToQuote, cancerToQ, hospitalToQ, textBox14.Text, textBox15.Text, premium.ToString()
                                    );
                quote.Closed += (s, arges) => this.Close();
                quote.ShowDialog();
            }
            else if(!fieldFilled)
            {
                MessageBox.Show("You need to fill all the boxes!");
            }
            else if(!noError)
            {
                MessageBox.Show("You need to enter valid information!");
            }
            else
            {
                MessageBox.Show("You need to enter valid information!");
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
                    errorProvider1.SetError(FirstNameBox, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(FirstNameBox, "");
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
                    errorProvider1.SetError(LastNameBox, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(LastNameBox, "");
                }
            }
        }

        private void BirthBox_TextChanged(object sender, EventArgs e)
        {
            string tString = CityBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    errorProvider1.SetError(BirthBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(BirthBox, "");
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
                    errorProvider1.SetError(CityBox, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(CityBox, "");
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
                    errorProvider1.SetError(ZipBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(ZipBox, "");
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
                    errorProvider1.SetError(FatherBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(FatherBox, "");
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
                    errorProvider1.SetError(motherBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(motherBox, "");
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
                    errorProvider1.SetError(cigBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(cigBox, "");
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
                    errorProvider1.SetError(smokeBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(smokeBox, "");
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
                    errorProvider1.SetError(bloodBox, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(bloodBox, "");
                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string tString = textBox15.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    errorProvider1.SetError(textBox15, "Please enter the number");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBox15, "");
                }
            }
        }

        

        

        private void PolicyRegistration_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
