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
    public partial class frmQLLaptop : Form
    {
        LaptopBLL ltbll = new LaptopBLL();
        CategoryBLL ctbll = new CategoryBLL();
        public frmQLLaptop()
        {
            InitializeComponent();
            
        }
        public void reset()
        {
            btn_Luu.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            loadcbbCategory();
            txt_id.Clear();
            txt_name.Clear();         
            txt_Price.Clear();
            txt_PDCom.Clear();
            txt_Monitor.Clear();
            txt_CPU.Clear();
            txt_RAM.Clear();
            txt_Image.Clear();
            txt_GPU.Clear();
            txt_HD.Clear();
            txt_quantity.Clear();
        }
        public void loadcbbCategory()
        {
            cbb_IDCate.DataSource = ctbll.GetCategorys();
            cbb_IDCate.DisplayMember = "Name";
            cbb_IDCate.ValueMember = "id";

        }
        public void loadLT()
        {

            dtgv_LT.DataSource = ltbll.GetLaptops();
            reset();
        }
        private void frmQLLaptop_Load(object sender, EventArgs e)
        {
            loadcbbCategory();
            loadLT();

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_LT.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Laptop từ danh sách");
                return;
            }
            else
            {
                if (ltbll.deleteLaptops(Convert.ToInt32(dtgv_LT.SelectedRows[0].Cells[0].Value.ToString())) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    loadLT();
                    reset();
                }
                else
                    MessageBox.Show("Xóa Thát bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Vui lòng chọn một Laptop từ danh sách");
            }    
            else
            if (string.IsNullOrEmpty(txt_name.Text) ||
               string.IsNullOrEmpty(cbb_IDCate.Text) ||
               string.IsNullOrEmpty(txt_Price.Text) ||
               string.IsNullOrEmpty(txt_PDCom.Text) ||
               string.IsNullOrEmpty(txt_Monitor.Text) ||
               string.IsNullOrEmpty(txt_CPU.Text) ||
               string.IsNullOrEmpty(txt_RAM.Text) ||
               string.IsNullOrEmpty(txt_Image.Text) ||
               string.IsNullOrEmpty(txt_GPU.Text) ||
               string.IsNullOrEmpty(txt_HD.Text) ||
               string.IsNullOrEmpty(txt_quantity.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    txt_name.Focus();
                }
                else
                if (string.IsNullOrEmpty(cbb_IDCate.Text))
                {
                    cbb_IDCate.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_Price.Text))
                {
                    txt_Price.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_PDCom.Text))
                {
                    txt_PDCom.Focus();
                }
                if (string.IsNullOrEmpty(txt_Monitor.Text))
                {
                    txt_Monitor.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_CPU.Text))
                {
                    txt_CPU.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_RAM.Text))
                {
                    txt_RAM.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_Image.Text))
                {
                    txt_Image.Focus();
                }
                if (string.IsNullOrEmpty(txt_GPU.Text))
                {
                    txt_GPU.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_HD.Text))
                {
                    txt_HD.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_quantity.Text))
                {
                    txt_quantity.Focus();
                }

            }
            else
            {
                laptop lt = new laptop();
                lt.id = Convert.ToInt32(txt_id.Text);
                lt.Name = txt_name.Text;
                lt.idCategory = Convert.ToInt32(cbb_IDCate.SelectedValue);
                lt.price = Convert.ToDouble(txt_Price.Text);
                lt.productCompany = txt_PDCom.Text;
                lt.monitor = Convert.ToDouble(txt_Monitor.Text);
                lt.CPU = txt_CPU.Text;
                lt.RAM = txt_RAM.Text;
                lt.Image = txt_Image.Text;
                lt.GPU = txt_GPU.Text;
                lt.HardDisk = txt_HD.Text;
                lt.quantity = Convert.ToInt32( txt_quantity.Text);
                if (ltbll.updateLaptops(lt) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    loadLT();
                    reset();
                }
                else
                    MessageBox.Show("Sửa Thát bại");

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) ||
                string.IsNullOrEmpty(cbb_IDCate.Text) ||
                string.IsNullOrEmpty(txt_Price.Text) ||
                string.IsNullOrEmpty(txt_PDCom.Text) ||
                string.IsNullOrEmpty(txt_Monitor.Text) ||
                string.IsNullOrEmpty(txt_CPU.Text) ||
                string.IsNullOrEmpty(txt_RAM.Text) ||
                string.IsNullOrEmpty(txt_Image.Text) ||
                string.IsNullOrEmpty(txt_GPU.Text) ||
                string.IsNullOrEmpty(txt_HD.Text) ||
               string.IsNullOrEmpty(txt_quantity.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    txt_name.Focus();
                }
                else
                if (string.IsNullOrEmpty(cbb_IDCate.Text))
                {
                    cbb_IDCate.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_Price.Text))
                {
                    txt_Price.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_PDCom.Text))
                {
                    txt_PDCom.Focus();
                }
                if (string.IsNullOrEmpty(txt_Monitor.Text))
                {
                    txt_Monitor.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_CPU.Text))
                {
                    txt_CPU.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_RAM.Text))
                {
                    txt_RAM.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_Image.Text))
                {
                    txt_Image.Focus();
                }
                if (string.IsNullOrEmpty(txt_GPU.Text))
                {
                    txt_GPU.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_HD.Text))
                {
                    txt_HD.Focus();
                }
                else
                if (string.IsNullOrEmpty(txt_quantity.Text))
                {
                    txt_quantity.Focus();
                }

            }
            else
            {
                laptop lt = new laptop();

                lt.Name = txt_name.Text;
                lt.idCategory = Convert.ToInt32(cbb_IDCate.SelectedValue);
                lt.price = Convert.ToDouble(txt_Price.Text);
                lt.productCompany = txt_PDCom.Text;
                lt.monitor = Convert.ToDouble(txt_Monitor.Text);
                lt.CPU = txt_CPU.Text;
                lt.RAM = txt_RAM.Text;
                lt.Image = txt_Image.Text;
                lt.GPU = txt_GPU.Text;
                lt.HardDisk = txt_HD.Text;
                lt.quantity = Convert.ToInt32(txt_quantity.Text);
                if (ltbll.addLaptops(lt) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    loadLT();
                    reset();
                }
                else
                    MessageBox.Show("Thêm Thát bại");

            }
        }

        private void txt_TK_Click(object sender, EventArgs e)
        {
            dtgv_LT.DataSource = ltbll.searchLaptops(txt_TimKiem.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            loadLT();
            reset();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLLaptop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void dtgv_LT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_LT.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv_LT.SelectedRows[0];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "1")
                    cbb_IDCate.Text = "Gaming";
                else
                    cbb_IDCate.Text = "Văn Phòng";
                txt_Price.Text = row.Cells[3].Value.ToString();
                txt_PDCom.Text = row.Cells[4].Value.ToString();
                txt_Monitor.Text = row.Cells[5].Value.ToString();
                txt_CPU.Text = row.Cells[6].Value.ToString();
                txt_RAM.Text = row.Cells[7].Value.ToString();
                txt_Image.Text = row.Cells[8].Value.ToString();
                txt_GPU.Text = row.Cells[9].Value.ToString();
                txt_HD.Text = row.Cells[10].Value.ToString();
                txt_quantity.Text = row.Cells[11].Value.ToString();


            }
        }

      

        private void txt_Monitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
