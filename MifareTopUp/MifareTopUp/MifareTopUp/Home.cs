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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqc = ConnectDB.GetConnection();
                SqlCommand cmd = new SqlCommand("insert into users values(@firstname,@lastname,@email,@phone,@address);", sqc);
                cmd.Parameters.Add("@firstname", txtFirstName.Text);
                cmd.Parameters.Add("@lastname", txtLastName.Text);
                cmd.Parameters.Add("@email", txtEmail.Text);
                cmd.Parameters.Add("@phone", txtPhoneNo.Text);
                cmd.Parameters.Add("@address", txtAddress.Text);
                int insertCount = cmd.ExecuteNonQuery();
                if (insertCount > 0)
                {
                    MessageBox.Show("User Registered Successfully.");
                }
                else
                {
                    MessageBox.Show("Some Error Occured.");
                }
            }
            catch 
            {
                MessageBox.Show("Some Error Occured.");
            }
        }
    }
}
