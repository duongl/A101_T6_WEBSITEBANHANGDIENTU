﻿using System;
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
    public partial class frmDoiMatKhau : Form
    {
        public string useName = "";
        public int id;
        AccountBLL accbll = new AccountBLL();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_MaNV.Text = id.ToString();
            txt_TaiKhoan.Text = useName.ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau_Moi.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải trên 5 ký tự");
                txt_MatKhau_Moi.Focus();
            }
            else
            if (accbll.KTDMK(useName.ToString(), txt_MatKhau_Cu.Text, txt_MatKhau_Moi.Text)==1)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
                MessageBox.Show("Đổi mật khẩu thất bại");

        }

        private void txt_MatKhau_Cu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_MatKhau_Moi_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
