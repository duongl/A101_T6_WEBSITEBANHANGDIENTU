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

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(type == "admin")
            {
                quảnLýLaptopToolStripMenuItem1.Enabled = true;
                quảnLýLoạiLaptopToolStripMenuItem1.Enabled = true;
                quảnLýAcccountToolStripMenuItem1.Enabled = true;
                quảnLýHóaĐơnToolStripMenuItem.Enabled = true;
                thayĐổiMậtKhẩuToolStripMenuItem1.Enabled = true;
                thoátToolStripMenuItem.Enabled = true;
                thôngKêToolStripMenuItem.Enabled = true;
                quảnLýNhânViênToolStripMenuItem.Enabled = true;
            }   
            else if(type == "NhanVien")
            {
                quảnLýLaptopToolStripMenuItem1.Enabled = false;
                quảnLýLoạiLaptopToolStripMenuItem1.Enabled = false;
                quảnLýAcccountToolStripMenuItem1.Enabled = false;
                quảnLýHóaĐơnToolStripMenuItem.Enabled = false;
                thôngKêToolStripMenuItem.Enabled = true;
                thayĐổiMậtKhẩuToolStripMenuItem1.Enabled = true;
                thoátToolStripMenuItem.Enabled = true;
                quảnLýNhânViênToolStripMenuItem.Enabled = false;
            }    
            
        }

      

        private void quảnLýLaptopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLLaptop frm = new frmQLLaptop();
            frm.Show();
        }

        private void quảnLýLoạiLaptopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLCategory frm = new frmQLCategory();
            frm.Show();
        }

        private void quảnLýAcccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLAccounts frm = new frmQLAccounts();
            frm.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBills frm = new frmQLBills();

            frm.Show();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.useName = useName;
            frm.id = id;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();

        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLStaff frm = new frmQLStaff();
            frm.Show();
        }
    }
}
