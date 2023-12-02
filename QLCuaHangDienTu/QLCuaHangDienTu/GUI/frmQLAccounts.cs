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
    public partial class frmQLAccounts : Form
    {

        AccountBLL accbll = new AccountBLL();
        public frmQLAccounts()
        {
            InitializeComponent();
        }
        public void loadCBB()
        {
            DataTable accountTypes = accbll.cbbtype();
            cbb_Type.DataSource = accountTypes;
            cbb_Type.DisplayMember = "DisplayMember";
            cbb_Type.ValueMember = "ValueMember";
            
        }
        public void loadACC()
        {
            loadCBB();
            dtgv_Acc.DataSource = accbll.GetAccounts();
            reset();
        }
        public void reset()
        {
            btn_Luu.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            txt_id.Clear();
            txt_dpn.Clear();
            txt_un.Clear();
            txt_pw.Clear();
        }
        private void frmQLAccounts_Load(object sender, EventArgs e)
        {

            loadACC();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dpn.Text) || string.IsNullOrEmpty(txt_un.Text) || string.IsNullOrEmpty(txt_pw.Text) || string.IsNullOrEmpty(cbb_Type.SelectedIndex.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                if (string.IsNullOrEmpty(txt_dpn.Text))
                {
                    txt_dpn.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_un.Text))
                {
                    txt_un.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_pw.Text))
                {
                    txt_pw.Focus();
                }
                else
                if (string.IsNullOrEmpty(cbb_Type.SelectedItem.ToString()))
                {
                    cbb_Type.Focus();
                }
            }
            else
            {
                if (txt_pw.Text.Length < 5)
                {
                    MessageBox.Show("Mật khẩu phải trên 5 ký tự");
                    txt_pw.Focus();
                }
                else
                { 
                account acc = new account();

                acc.displayName = txt_dpn.Text;
                acc.userName = txt_un.Text;
                acc.password = txt_pw.Text;
                acc.type = Convert.ToInt32(cbb_Type.SelectedValue.ToString());
                if (accbll.addAccounts(acc) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    loadACC();
                    reset();
                }
                else
                    MessageBox.Show("Thêm Thát bại");
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void txt_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_Acc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Account từ danh sách.");
                return;
            }
            else
            {
                if (accbll.deleteAccounts(Convert.ToInt32(dtgv_Acc.SelectedRows[0].Cells[0].Value.ToString())) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    loadACC();
                    reset();
                }
                else
                    MessageBox.Show("Xóa Thát bại");
            }
        }

        private void dtgv_Acc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Acc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv_Acc.SelectedRows[0];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_dpn.Text = row.Cells[1].Value.ToString();
                txt_un.Text = row.Cells[2].Value.ToString();
                txt_pw.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "0")
                    cbb_Type.Text = "Khách hàng";
                else if(row.Cells[4].Value.ToString() == "1")
                    cbb_Type.Text = "Admin";
                else cbb_Type.Text = "Nhân viên";

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_Acc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Account từ danh sách.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_dpn.Text) || string.IsNullOrEmpty(txt_un.Text) || string.IsNullOrEmpty(txt_pw.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    if (string.IsNullOrEmpty(txt_dpn.Text))
                    {
                        txt_dpn.Focus();
                    }
                    else
                    if (string.IsNullOrEmpty(txt_un.Text))
                    {
                        txt_un.Focus();
                    }
                    else
                    if (string.IsNullOrEmpty(txt_pw.Text))
                    {
                        txt_pw.Focus();
                    }
                    else
                    if (string.IsNullOrEmpty(cbb_Type.SelectedIndex.ToString()))
                    {
                        cbb_Type.Focus();
                    }
                }
                else
                {
                    if (txt_pw.Text.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu phải trên 5 ký tự");
                        txt_pw.Focus();
                    }
                    else
                    { 
                    account acc = new account();
                    acc.id = Convert.ToInt32(dtgv_Acc.SelectedRows[0].Cells[0].Value.ToString());
                    acc.displayName = txt_dpn.Text;
                    acc.userName = txt_un.Text;
                    acc.password = txt_pw.Text;
                    acc.type = Convert.ToInt32(cbb_Type.SelectedValue.ToString());
                    if (accbll.updateAccounts(acc) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        loadACC();
                        reset();
                    }
                    else
                        MessageBox.Show("Sửa Thát bại");
                    }
                }

            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

       

        private void btn_reset_Click(object sender, EventArgs e)
        {
            loadACC();
            reset();
        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
