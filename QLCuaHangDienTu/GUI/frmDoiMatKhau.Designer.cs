
namespace GUI
{
    partial class frmDoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_MatKhau_Moi = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_MatKhau_Cu = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(511, 55);
            this.label8.TabIndex = 23;
            this.label8.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_MatKhau_Moi);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Controls.Add(this.txt_MaNV);
            this.panel2.Controls.Add(this.txt_MatKhau_Cu);
            this.panel2.Controls.Add(this.txt_TaiKhoan);
            this.panel2.Location = new System.Drawing.Point(431, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 293);
            this.panel2.TabIndex = 22;
            // 
            // txt_MatKhau_Moi
            // 
            this.txt_MatKhau_Moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau_Moi.Location = new System.Drawing.Point(12, 171);
            this.txt_MatKhau_Moi.Name = "txt_MatKhau_Moi";
            this.txt_MatKhau_Moi.Size = new System.Drawing.Size(225, 26);
            this.txt_MatKhau_Moi.TabIndex = 22;
            this.txt_MatKhau_Moi.TextChanged += new System.EventHandler(this.txt_MatKhau_Moi_TextChanged);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(12, 236);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(146, 41);
            this.btn_Luu.TabIndex = 21;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(12, 16);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(225, 26);
            this.txt_MaNV.TabIndex = 0;
            // 
            // txt_MatKhau_Cu
            // 
            this.txt_MatKhau_Cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau_Cu.Location = new System.Drawing.Point(12, 116);
            this.txt_MatKhau_Cu.Name = "txt_MatKhau_Cu";
            this.txt_MatKhau_Cu.Size = new System.Drawing.Size(225, 26);
            this.txt_MatKhau_Cu.TabIndex = 7;
            this.txt_MatKhau_Cu.TextChanged += new System.EventHandler(this.txt_MatKhau_Cu_TextChanged);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(12, 68);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.ReadOnly = true;
            this.txt_TaiKhoan.Size = new System.Drawing.Size(225, 26);
            this.txt_TaiKhoan.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(243, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 293);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã tài khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mật khẩu cũ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tài khoản:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 556);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmThongTinCaNhan";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_MatKhau_Moi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_MatKhau_Cu;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}