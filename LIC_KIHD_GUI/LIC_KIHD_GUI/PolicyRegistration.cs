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
        
        public PolicyRegistration()
        {
            InitializeComponent();
        }

        private void HDYes_CheckedChanged(object sender, EventArgs e)
        {
            HDNo.Checked = !HDYes.Checked;
            HeartDisease = "Y";
        }

        private void HDNo_CheckedChanged(object sender, EventArgs e)
        {
            HDYes.Checked = !HDNo.Checked;
            HeartDisease = "N";
        }

        private void CancerYes_CheckedChanged(object sender, EventArgs e)
        {
            CancerNo.Checked = !CancerYes.Checked;
            cancer = "Y";
        }

        private void CancerNo_CheckedChanged(object sender, EventArgs e)
        {
            CancerYes.Checked = !CancerNo.Checked;
            cancer = "N";
        }

        private void HosYes_CheckedChanged(object sender, EventArgs e)
        {
            HosNo.Checked = !HosYes.Checked;
            hospital = "Y";
        }

        private void HosNo_CheckedChanged(object sender, EventArgs e)
        {
            HosYes.Checked = !HosNo.Checked;
            hospital = "N";
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
            if(!fieldFilled)
            {
                MessageBox.Show("You need to fill all the boxes!");
                
            }

            foreach (Control c in this.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)
                    noError = false;
            }

            if(!noError)
            {
                MessageBox.Show("You need to enter valid information!");
            }

        

            if (fieldFilled && comboBox1.SelectedIndex < -1 && noError)
            {
                state = comboBox1.SelectedItem.ToString();
                
                QuoteForm quote = new QuoteForm(FirstNameBox.Text, LastNameBox.Text, BirthBox.Text, AddressBox.Text, CityBox.Text, state, ZipBox.Text, FatherBox.Text, motherBox.Text,
                                    cigBox.Text, smokeBox.Text, bloodBox.Text, aveGramsBox.Text, HeartDisease, cancer, hospital, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text
                                    , textBox1.Text);
                quote.Show();
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
            try
            {
                int i = Int32.Parse(BirthBox.Text.Trim());
                errorProvider1.SetError(BirthBox, "");
            }
            catch
            {
                errorProvider1.SetError(BirthBox, "Please enter a valid date！");
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
            try
            {
                int i = Int32.Parse(ZipBox.Text.Trim());
                errorProvider1.SetError(ZipBox, "");
            }
            catch
            {
                errorProvider1.SetError(ZipBox, "Please enter a valid zip code！");
            }
        }

        private void FatherBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(FatherBox.Text.Trim());
                errorProvider1.SetError(FatherBox, "");
            }
            catch
            {
                errorProvider1.SetError(FatherBox, "Please enter a valid date！");
            }
        }

        private void motherBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(motherBox.Text.Trim());
                errorProvider1.SetError(motherBox, "");
            }
            catch
            {
                errorProvider1.SetError(motherBox, "Please enter a valid date！");
            }
        }

        private void cigBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(cigBox.Text.Trim());
                errorProvider1.SetError(cigBox, "");
            }
            catch
            {
                errorProvider1.SetError(cigBox, "Please enter a valid number！");
            }
        }

        private void smokeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(smokeBox.Text.Trim());
                errorProvider1.SetError(smokeBox, "");
            }
            catch
            {
                errorProvider1.SetError(smokeBox, "Please enter a valid date！");
            }
        }

        private void bloodBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(bloodBox.Text.Trim());
                errorProvider1.SetError(bloodBox, "");
            }
            catch
            {
                errorProvider1.SetError(bloodBox, "Please enter a valid number！");
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(textBox15.Text.Trim());
                errorProvider1.SetError(textBox15, "");
            }
            catch
            {
                errorProvider1.SetError(textBox15, "Please enter a valid number！");
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
                    errorProvider1.SetError(textBox16, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBox16, "");
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
                    errorProvider1.SetError(textBox17, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBox17, "");
                }
            }
        }

        private void PolicyRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
