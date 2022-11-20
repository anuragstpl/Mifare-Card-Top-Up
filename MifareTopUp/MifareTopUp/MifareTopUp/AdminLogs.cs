using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MifareTopUp
{
    public partial class AdminLogs : Form
    {
        public AdminLogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                try
                {
                    SqlConnection sqc = ConnectDB.GetConnection();
                    SqlCommand cmd = new SqlCommand("Select * from Users", sqc);
                    SqlDataAdapter sdra = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sdra.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    SqlCommand cmd1 = new SqlCommand("Select  * from TransactionData", sqc);
                    SqlDataAdapter sdra1 = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    sdra1.Fill(ds1);
                    dataGridView2.DataSource = ds1.Tables[0];

                }
                catch
                {
                    MessageBox.Show("Some Error Occured.");
                }
            }
            else
            {
                MessageBox.Show("Please enter correct password.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
