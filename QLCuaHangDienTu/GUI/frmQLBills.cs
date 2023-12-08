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
    public partial class frmQLBills : Form
    {
        BillBLL billbll = new BillBLL();
        public frmQLBills()
        {
            InitializeComponent();
        }
        public void reset()
        {         
            txt_id.Clear();
            txt_IDA.Clear();
            txt_Status.Clear();
            
        }
        public void loadBill()
        {
            dtgv_Bill.DataSource = billbll.GetBills();
            reset();
        }
        private void frmQLBills_Load(object sender, EventArgs e)
        {
            loadBill();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_Bill.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Bill từ danh sách.");
                return;
            }
            else
            {
                if (billbll.deleteBills(Convert.ToInt32(txt_id.Text)) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    loadBill();
                    reset();
                }
                else
                    MessageBox.Show("Xóa Thát bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_Bill.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một Account từ danh sách.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_IDA.Text) || string.IsNullOrEmpty(txt_Status.Text) || string.IsNullOrEmpty(dtp_DP.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    if (string.IsNullOrEmpty(txt_IDA.Text))
                    {
                        txt_IDA.Focus();
                    }
                    else
                    if (string.IsNullOrEmpty(txt_Status.Text))
                    {
                        txt_Status.Focus();
                    }
                    else
                    if (string.IsNullOrEmpty(dtp_DP.Text))
                    {
                        dtp_DP.Focus();
                    }
                    
                }
                else
                {
                    bill bil = new bill();
                    bil.id = Convert.ToInt32(dtgv_Bill.SelectedRows[0].Cells[0].Value.ToString());
                    bil.idAccount = Convert.ToInt32( txt_IDA.Text);
                    bil.status = Convert.ToInt32(txt_Status.Text);
                    bil.datepay = dtp_DP.Value;
                    if (billbll.updateBills(bil) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        loadBill();
                        reset();
                    }
                    else
                        MessageBox.Show("Sửa Thát bại");

                }

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_TK_Click(object sender, EventArgs e)
        {
            dtgv_Bill.DataSource = billbll.searchBills(dtp_TK.Value);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            loadBill();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Bill.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv_Bill.SelectedRows[0];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_IDA.Text = row.Cells[1].Value.ToString();
                txt_Status.Text = row.Cells[2].Value.ToString();
                dtp_DP.Text = row.Cells[3].Value.ToString();
                dtgv_billinfo.DataSource = billbll.BillInfos(Convert.ToInt32( row.Cells[0].Value));
            }
        }

        private void frmQLBills_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_IDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
