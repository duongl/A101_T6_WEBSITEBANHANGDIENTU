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
    public partial class frmThongKe : Form
    {
        ThongKeBLL tkbll = new ThongKeBLL();
        public frmThongKe()
        {
            InitializeComponent();
        }
        public void TinhTong()
        {
            float x = 0;
            int sc = dtgv_ThongKe.Rows.Count;
            for (int i = 0; i < sc - 1; i++)
            {
                x += float.Parse(dtgv_ThongKe.Rows[i].Cells[7].Value.ToString());
            }
            txt_TongTien.Text = x.ToString("#,####.####");
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dtgv_ThongKe.DataSource = tkbll.GetThongKe();
            TinhTong();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            dtgv_ThongKe.DataSource = tkbll.search(dTP_TuNgay.Value, dTP_DenNgay.Value);
            TinhTong();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dtgv_ThongKe.DataSource = tkbll.GetThongKe();
            TinhTong();
        }

        private void frmThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
