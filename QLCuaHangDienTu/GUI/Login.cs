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

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;
        
            if( accountBLL.GetMK(userName) != null)
            {
                if(accountBLL.GetMK(userName) == password)
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
                    else if (Convert.ToInt32(role) == 0)
                    {
                        frmMain frm = new frmMain();
                        frm.type = "nv";
                        frm.useName = userName;
                        frm.id = Convert.ToInt32(accountBLL.GetID(userName));
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xác định vai trò của người dùng.");
                    }
                } 
                else
                    MessageBox.Show("Sai mật khảu. Mời thử lại.");
            }    
            else
                MessageBox.Show("Sai tài khoản. Mời xem lại tài khoản.");
            
        }
    }
}
