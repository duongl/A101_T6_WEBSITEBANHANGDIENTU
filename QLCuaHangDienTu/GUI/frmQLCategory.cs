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
    public partial class frmQLCategory : Form
    {
        CategoryBLL catebll = new CategoryBLL();
        public frmQLCategory()
        {
            InitializeComponent();
            btn_Luu.Enabled = false;
        }
        public void reset()
        {
            btn_Luu.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            txt_id.Clear();
            txt_Name.Clear();

        }
        public void loadcate()
        {
            dtgv_cate.DataSource = catebll.GetCategorys();
            reset();
        }
        private void frmQLCategory_Load(object sender, EventArgs e)
        {
            loadcate();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_cate.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Account từ danh sách.");
                return;
            }
            else
            {
                if (catebll.deleteCategorys(Convert.ToInt32(dtgv_cate.SelectedRows[0].Cells[0].Value.ToString())) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    loadcate();
                    reset();
                }
                else
                    MessageBox.Show("Xóa Thát bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_cate.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Account từ danh sách.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    if (string.IsNullOrEmpty(txt_Name.Text))
                    {
                        txt_Name.Focus();
                    }
                    
                }
                else
                {
                    laptopCategory cate = new laptopCategory();
                    cate.id = Convert.ToInt32(dtgv_cate.SelectedRows[0].Cells[0].Value.ToString());
                    cate.Name = txt_Name.Text;                  
                    if (catebll.updateCategorys(cate) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        loadcate();
                        reset();
                    }
                    else
                        MessageBox.Show("Sửa Thát bại");

                }

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    txt_Name.Focus();
                }
                
            }
            else
            {
                laptopCategory cate = new laptopCategory();              
                cate.Name = txt_Name.Text;
                if (catebll.addCategorys(cate) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    loadcate();
                    reset();
                }
                else
                    MessageBox.Show("Thêm Thát bại");

            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_cate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_cate.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv_cate.SelectedRows[0];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();               
            }
        }

        private void frmQLCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
