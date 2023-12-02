using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class Login : Form
    {
        public int type;
        private AccountBLL accountBLL = new AccountBLL();
        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;
        
            if( accountBLL.GetMK(userName) != null)
            {
                if(accountBLL.GetMK(userName) == password )
                {
                    string role = accountBLL.GetType(userName);

                    if (Convert.ToInt32(role) == 1)
                    {
                        frmMain frm = new frmMain();
                        frm.type = "admin";
                        frm.useName = userName;
                        frm.id = Convert.ToInt32( accountBLL.GetID(userName));
                        frm.Show();
                        this.Hide();
                    }                 
                    else
                    if (Convert.ToInt32(role) == 2)
                    {
                        frmMain frm = new frmMain();
                        frm.type = "NhanVien";
                        frm.useName = userName;
                        frm.id = Convert.ToInt32(accountBLL.GetID(userName));
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền đăng nhập.");
                    }
                } 
                else
                    MessageBox.Show("Sai mật khảu. Mời thử lại.");
            }    
            else
                MessageBox.Show("Sai tài khoản. Mời xem lại tài khoản.");
            
        }

        private void cb_MatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_MatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
