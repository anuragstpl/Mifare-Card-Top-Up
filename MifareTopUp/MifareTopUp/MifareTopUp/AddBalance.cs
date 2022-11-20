using MifareTopUp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MifareTopUp
{
    public partial class AddBalance : Form
    {
        public AddBalance()
        {
            InitializeComponent();
        }

        byte[] antennaON = { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x0c, 0x01, 0x01, 0x0c };
        byte[] cardrequest = { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x01, 0x02, 0x52, 0x51 };
        byte[] collision = { 0xAA, 0xBB, 0x05, 0x00, 0x00, 0x00, 0x02, 0x02, 0x00 };
        byte[] selectcard = { 0xAA, 0xBB, 0x09, 0x00, 0x00, 0x00, 0x03, 0x02, 0x97, 0x14, 0xAC, 0xE4, 0xCA };
        byte[] auth = { 0xAA, 0xBB, 0x0D, 0x00, 0x00, 0x00, 0x07, 0x02, 0x60, 0x01, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x64 };
        byte[] balance = { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x0B, 0x02, 0x01, 0x08 };
        byte[] zero = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0A, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00, 0x09 };
        byte[] inc10 = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x02, 0x01, 0x0A, 0x00, 0x00, 0x00, 0x04 };
        byte[] inc30 = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x02, 0x01, 0x1E, 0x00, 0x00, 0x00, 0x10 };
        byte[] inc50 = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x02, 0x01, 0x32, 0x00, 0x00, 0x00, 0x3C };
        byte[] ded10 = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0C, 0x02, 0x01, 0x0A, 0x00, 0x00, 0x00, 0x05 };
        byte[] ded30 = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0C, 0x02, 0x01, 0x1E, 0x00, 0x00, 0x00, 0x11 };
        byte[] ded50 = { 0xAA, 0xBB, 0x0A, 0x00, 0x00, 0x00, 0x0C, 0x02, 0x01, 0x32, 0x00, 0x00, 0x00, 0x3D };

        byte[] NUID = new byte[4];

        public bool OpenPort()
        {
            try
            {
                serialPort1.PortName = cbCOM.Text;
                serialPort1.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Unable to open COM Port!");
                return false;
            }
        }

        public bool CardAccess(byte[] nuid)
        {
            byte[] data = new byte[208];

            serialPort1.Write(antennaON, 0, antennaON.Length);
            if (!Receive(data))
                return false;

            serialPort1.Write(cardrequest, 0, cardrequest.Length);
            if (!Receive(data))
                return false;

            serialPort1.Write(collision, 0, collision.Length);
            if (!Receive(data))
                return false;

            nuid[0] = data[5];
            nuid[1] = data[6];
            nuid[2] = data[7];
            nuid[3] = data[8];

            serialPort1.Write(selectcard, 0, selectcard.Length);
            if (!Receive(data))
                return false;

            serialPort1.Write(auth, 0, auth.Length);
            if (!Receive(data))
                return false;

            return true;
        }

        public bool CheckPorts(ComboBox cbCOM)
        {
            bool port_status = true;

            //clear all item inside combo box
            cbCOM.Items.Clear();

            //get available port
            foreach (string port in SerialPort.GetPortNames())
            {
                cbCOM.Items.Add(port);
            }

            //check if portname list also contain same portname as setting
            if (cbCOM.Items.Contains(Settings.Default.COM))
            {
                cbCOM.SelectedItem = Settings.Default.COM;
            }
            else if (cbCOM.Items.Count > 0)
            {
                cbCOM.SelectedIndex = 0;
            }
            else
            {
                port_status = false;
            }

            return port_status;
        }

        public bool Receive(byte[] data)
        {
            byte start1, start2, status = 0x01; ;
            int length;

            start1 = (byte)serialPort1.ReadByte();
            start2 = (byte)serialPort1.ReadByte();
            length = serialPort1.ReadByte();
            length = serialPort1.ReadByte() * 256 + length;

            //byte[] buf = new byte[length];

            for (int i = 0; i < length; i++)
            {
                data[i] = (byte)serialPort1.ReadByte();
            }
            status = data[4];
            if (status == 0x00)
            {
                //copy buf array to data array;
                return true;
            }
            else return false;
        }

        public int readBalance()
        {
            byte[] data = new byte[208];
            int bal;

            serialPort1.Write(balance, 0, balance.Length);
            if (Receive(data))
            {
                bal = (int)data[5] + (int)data[6] * 256 + (int)data[7] * 65536 + (int)data[8] * 16777216;
                return bal;
            }
            else
                return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] carddetails = new string[] { "1111111111111111", "22222222222222222", "3333333333333333", "4444444444444444" };
            if (Array.IndexOf(carddetails, txtcreditcards.Text) == 1)
            {
                byte[] data = new byte[208];
                int nuid;
                try
                {
                    if (OpenPort())
                    {
                        if (CardAccess(NUID))
                        {
                            int amount = 0;
                            if (radioButton1.Checked)
                            {
                                serialPort1.Write(inc10, 0, inc10.Length);
                                amount = 10;
                            }
                            else if (radioButton2.Checked)
                            {
                                serialPort1.Write(inc30, 0, inc30.Length);
                                amount = 30;
                            }
                            else if (radioButton3.Checked)
                            {
                                serialPort1.Write(inc50, 0, inc50.Length);
                                amount = 50;
                            }


                            if (Receive(data))
                            {
                                try
                                {
                                    SqlConnection sqc = ConnectDB.GetConnection();
                                    SqlCommand cmd = new SqlCommand("insert into transactiondata values(@UserId,@Store,@Amount,getdate(),'TopUp');", sqc);
                                    cmd.Parameters.Add("@UserId", comboBox1.SelectedValue);
                                    cmd.Parameters.Add("@Store", comboBox2.Text);
                                    cmd.Parameters.Add("@amount", readBalance().ToString());
                                    int insertCount = cmd.ExecuteNonQuery();
                                    if (insertCount > 0)
                                    {
                                        MessageBox.Show("Card recharged successfully.");
                                        lblCurrentBalance.Text = readBalance().ToString();
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
                            else
                                MessageBox.Show("Operation error! Please try again.");
                        }
                        else
                            MessageBox.Show("Card read error.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid Card Details....");
            }

            serialPort1.Close();
        }

        public void GetBalance()
        {
            int nuid;
            try
            {
                if (OpenPort())
                {
                    if (CardAccess(NUID))
                    {
                        lblCurrentBalance.Text = readBalance().ToString();
                    }
                    else
                        MessageBox.Show("Card read error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            serialPort1.Close();
        }

        private void AddBalance_Load(object sender, EventArgs e)
        {
            try
            {

                if (CheckPorts(cbCOM) == false)
                {
                    MessageBox.Show("No COM Ports found on this computer.\nTry reconnecting USB cable and restart application.",
                        "No COM Ports detected.",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                SqlConnection sqc = ConnectDB.GetConnection();
                SqlCommand cmd = new SqlCommand("Select Firstname,Id from Users", sqc);
                SqlDataAdapter sdra = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sdra.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Firstname";

                GetBalance();


            }
            catch
            {
                MessageBox.Show("Some Error Occured.");
            }
        }

        private void cbCOM_DropDown(object sender, EventArgs e)
        {
            CheckPorts(cbCOM);
        }

    }
}
