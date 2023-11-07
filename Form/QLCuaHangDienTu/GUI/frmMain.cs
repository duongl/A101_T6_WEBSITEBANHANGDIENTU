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
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLýAcccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLAccounts frm = new frmQLAccounts();
            frm.Show();
        }
    }
}
