
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LIC_KIHD_GUI
{
    public partial class UserRegister : Form
    {
        static Func<Control, IEnumerable<Control>> GetControls =
        (control) => control
            .Controls
            .Cast<Control>().SelectMany(x => GetControls(x))
            .Concat(control.Controls.Cast<Control>());
        private string userType;
        private string ID;
        private string FirstName;
        private string LastName;
        private string Department;
        private string Username;
        private string password;

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
            userType = "A";
        }

        private void UtNo_CheckedChanged(object sender, EventArgs e)
        {
            Agent.Checked = !Manager.Checked;
            userType = "M";
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            bool fieldFilled = true;
            foreach (TextBox tb in GetControls(this).OfType<TextBox>())
            {

                if (string.IsNullOrEmpty(tb.Text))
                {
                    fieldFilled = false;

                }
            }

            if (fieldFilled && comboBox1.SelectedIndex > -1)
            {
                
                LIC_KIHD_MW.Manager agentRegister = new LIC_KIHD_MW.Manager(IDBOX.Text, FNameBox.Text, LNameBox.Text, userType, comboBox1.Text, UserNameBox.Text, PasswordBox.Text);
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

        private void IDBOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(IDBOX.Text.Trim());
                errorProvider1.SetError(IDBOX, "");
            }
            catch
            {
                errorProvider1.SetError(IDBOX, "Please enter a valid ID！");
            }
        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {
            string tString = FNameBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    errorProvider1.SetError(FNameBox, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(FNameBox, "");
                }
            }
        }

        private void LNameBox_TextChanged(object sender, EventArgs e)
        {
            string tString = LNameBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    errorProvider1.SetError(LNameBox, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(LNameBox, "");
                }
            }
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
            string tString = UserNameBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsLetter(tString[i]))
                {
                    errorProvider1.SetError(UserNameBox, "Please enter a valid information");//MessageBox.Show("Please enter a valid information");     
                    return;
                }
                else
                {
                    errorProvider1.SetError(UserNameBox, "");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DATABASE" + "\\" + "CSCI3400011030;Initial Catalog=LIC_KIHD;"
       + "Integrated Security=false;user='LIC_KIHD_MW';pwd='KIHD';";
            SqlConnection conn = new SqlConnection(connectionString);
            string ID = "";
            IDBOX.Text = ID;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
