using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIC_KIHD_GUI
{
    public partial class AgentSearch : Form
    {
        public AgentSearch(string ID)
        {
            InitializeComponent();
            string agentId = ID;
        }

        private void AgentSearch_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You are successfully logged out"));
            Hide();
            loginPage login = new loginPage();
            login.Closed += (s, arges) => this.Close();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
           
            PolicyRegistration policyRegiser = new PolicyRegistration();
            
            policyRegiser.ShowDialog();
        }

        private void agentSearchButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            
           // List<LIC_KIHD_MW.Policy> policy = LIC_KIHD_MW.Agent.search(policyNumBox.Text, false);
            //string[][] searchResult;
            /*if(policy != null)
            {
               table = ToDataTable(policy);

                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("The information you entered is wrong!");
                policyNumBox.Clear();
                clientNameBox.Clear();
            }*/
        }
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void clientNameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private DataTable convertToDataTable(string[,] search)
        {
            DataTable dt = new DataTable();
            for(int i = 0; i < search.GetLength(1); i ++)
            {

            }
            return dt;
        }
    }
}
