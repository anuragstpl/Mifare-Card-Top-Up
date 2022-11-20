using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MifareTopUp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void viewLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeductBalance dedbal = new DeductBalance();
            dedbal.MdiParent = this;
            dedbal.Show();
            CloseAll();
        }

        private void deductBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBalance hme = new AddBalance();
            hme.MdiParent = this;
            hme.Show();
            CloseAll();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeSelfTopUp hme = new HomeSelfTopUp();
            hme.MdiParent = this;
            hme.Show();
            CloseAll();
        }

        private void topUpBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hme = new Home();
            hme.MdiParent = this;
            hme.Show();
            CloseAll();
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogs hme = new AdminLogs();
            hme.MdiParent = this;
            hme.Show();
            CloseAll();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            HomeSelfTopUp hme = new HomeSelfTopUp();
            hme.MdiParent = this;
            hme.Show();
            CloseAll();
        }

        public void CloseAll()
        {
            foreach (Form aForm in this.OwnedForms)
            {
                aForm.Close();
            }
        }
    }
}
