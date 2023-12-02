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
    public partial class frmQLStaff : Form
    {
        StaffBLL staffbll = new StaffBLL();

        public frmQLStaff()
        {
            InitializeComponent();
        }
        public void loadStaff()
        {
            dtgv_Staff.DataSource = staffbll.GetStaffs();
            reset();
        }
        public void loadcbbsex()
        {
            cbb_sex.DataSource = staffbll.cbbsex();
            cbb_sex.DisplayMember = "DisplayMember";
            cbb_sex.ValueMember = "DisplayMember";
        }

        public void reset()
        {
            btn_Luu.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            txt_id.Clear();
            txt_Name.Clear();
            txt_phone.Clear();
            txt_idac.Clear();
        }
        private void frmQLStaff_Load(object sender, EventArgs e)
        {
            loadStaff();
            loadcbbsex();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_Staff.SelectedRows.Count <= 0 || string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Vui lòng nhập id của Staff hoặc chọn một Staff từ danh sách.");
                return;
            }
            else
            {
                if (staffbll.deleteStaffs(Convert.ToInt32(txt_id.Text)) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    loadStaff();
                    reset();
                }
                else
                    MessageBox.Show("Xóa Thát bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    txt_Name.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_phone.Text))
                {
                    txt_phone.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    txt_id.Focus();
                }

            }
            else
            {

                staff s = new staff();
                s.id = Convert.ToInt32( txt_id.Text);
                s.Name = txt_Name.Text;
                s.Phone = txt_phone.Text;
                s.Sex = cbb_sex.SelectedValue.ToString();
                if (string.IsNullOrEmpty(txt_idac.Text))
                    s.idAccount = null;
                else
                s.idAccount = Convert.ToInt32(txt_idac.Text);
                if (staffbll.updateStaffs(s) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    loadStaff();
                    reset();
                }
                else
                    MessageBox.Show("Sửa Thất bại");

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    txt_Name.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_phone.Text))
                {
                    txt_phone.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    txt_id.Focus();
                }

            }
            else
            {

                staff s = new staff();

                s.id = Convert.ToInt32(txt_id.Text);
                s.Name = txt_Name.Text;
                s.Phone = txt_phone.Text;
                s.Sex = cbb_sex.SelectedValue.ToString();
                if (Convert.ToString( staffbll.CheckUserName(txt_Name.Text))!= null)
                    s.idAccount = staffbll.CheckUserName(txt_Name.Text);
                else
                    s.idAccount = null;
                if (staffbll.addStaffs(s) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    loadStaff();
                    reset();
                }
                else
                    MessageBox.Show("Thêm Thát bại");

            }
        }

        private void frmQLStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void dtgv_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Staff.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv_Staff.SelectedRows[0];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();
                cbb_sex.Text = row.Cells[2].Value.ToString();
                txt_phone.Text = row.Cells[3].Value.ToString();
                txt_idac.Text = row.Cells[4].Value.ToString();

            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
