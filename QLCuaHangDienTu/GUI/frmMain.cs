using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public string useName = "";
        public string type = "";
        public int id;
        Login a = new Login();

        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLýAcccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLAccounts frm = new frmQLAccounts();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (type == "admin")
            {
                // Enable all features for admin
                quảnLýAcccountToolStripMenuItem.Enabled = true;
                quảnLýToolStripMenuItem.Enabled = true;
                quảnLýLaptopToolStripMenuItem.Enabled = true;
                quảnLýLoạiLaptopToolStripMenuItem.Enabled = true;
                thayĐổiMậtKhẩuToolStripMenuItem.Enabled = true;
            }
            else
            {
                // Disable certain features for non-admin users
                quảnLýAcccountToolStripMenuItem.Enabled = false;
                quảnLýToolStripMenuItem.Enabled = false;
                quảnLýLaptopToolStripMenuItem.Enabled = true;  
                quảnLýLoạiLaptopToolStripMenuItem.Enabled = false;
                thayĐổiMậtKhẩuToolStripMenuItem.Enabled = true;
            }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBills frm = new frmQLBills();

            frm.Show();
        }

        private void quảnLýLaptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLLaptop frm = new frmQLLaptop();
            frm.Show();
        }

        private void quảnLýLoạiLaptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLCategory frm = new frmQLCategory();
            frm.Show();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.useName = useName;
            frm.id = id;
            frm.Show();
        }
    }
}
