
namespace GUI
{
    partial class frmQLLaptop
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_PDCom = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dtgv_LT = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.txt_RAM = new System.Windows.Forms.TextBox();
            this.txt_CPU = new System.Windows.Forms.TextBox();
            this.txt_Monitor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_HD = new System.Windows.Forms.TextBox();
            this.txt_GPU = new System.Windows.Forms.TextBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_TK = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cbb_IDCate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LT)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "ProductCompany:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "IDCategory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(1416, 718);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 33;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(317, 12);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 32;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(216, 12);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(114, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_PDCom
            // 
            this.txt_PDCom.Location = new System.Drawing.Point(1091, 59);
            this.txt_PDCom.Name = "txt_PDCom";
            this.txt_PDCom.Size = new System.Drawing.Size(126, 20);
            this.txt_PDCom.TabIndex = 28;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(845, 59);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(126, 20);
            this.txt_Price.TabIndex = 27;
            this.txt_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyDown);
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(196, 59);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(351, 20);
            this.txt_name.TabIndex = 25;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(63, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(67, 20);
            this.txt_id.TabIndex = 24;
            // 
            // dtgv_LT
            // 
            this.dtgv_LT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_LT.Location = new System.Drawing.Point(29, 169);
            this.dtgv_LT.Name = "dtgv_LT";
            this.dtgv_LT.Size = new System.Drawing.Size(1450, 543);
            this.dtgv_LT.TabIndex = 23;
            this.dtgv_LT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_LT_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1221, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Image:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "RAM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "CPU:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Monitor:";
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(1278, 95);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(213, 20);
            this.txt_Image.TabIndex = 45;
            // 
            // txt_RAM
            // 
            this.txt_RAM.Location = new System.Drawing.Point(464, 95);
            this.txt_RAM.Name = "txt_RAM";
            this.txt_RAM.Size = new System.Drawing.Size(126, 20);
            this.txt_RAM.TabIndex = 44;
            // 
            // txt_CPU
            // 
            this.txt_CPU.Location = new System.Drawing.Point(230, 95);
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.Size = new System.Drawing.Size(162, 20);
            this.txt_CPU.TabIndex = 43;
            // 
            // txt_Monitor
            // 
            this.txt_Monitor.Location = new System.Drawing.Point(77, 95);
            this.txt_Monitor.Name = "txt_Monitor";
            this.txt_Monitor.Size = new System.Drawing.Size(83, 20);
            this.txt_Monitor.TabIndex = 42;
            this.txt_Monitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monitor_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1015, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "HasdDisk:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(630, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "GPU:";
            // 
            // txt_HD
            // 
            this.txt_HD.Location = new System.Drawing.Point(1077, 95);
            this.txt_HD.Name = "txt_HD";
            this.txt_HD.Size = new System.Drawing.Size(126, 20);
            this.txt_HD.TabIndex = 51;
            // 
            // txt_GPU
            // 
            this.txt_GPU.Location = new System.Drawing.Point(678, 95);
            this.txt_GPU.Name = "txt_GPU";
            this.txt_GPU.Size = new System.Drawing.Size(314, 20);
            this.txt_GPU.TabIndex = 50;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(464, 14);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(188, 20);
            this.txt_TimKiem.TabIndex = 39;
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(658, 12);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(61, 24);
            this.txt_TK.TabIndex = 40;
            this.txt_TK.Text = "Tìm Kiếm";
            this.txt_TK.UseVisualStyleBackColor = true;
            this.txt_TK.Click += new System.EventHandler(this.txt_TK_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(725, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 41;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cbb_IDCate
            // 
            this.cbb_IDCate.FormattingEnabled = true;
            this.cbb_IDCate.Location = new System.Drawing.Point(678, 59);
            this.cbb_IDCate.Name = "cbb_IDCate";
            this.cbb_IDCate.Size = new System.Drawing.Size(90, 21);
            this.cbb_IDCate.TabIndex = 56;
            // 
            // frmQLLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 774);
            this.Controls.Add(this.cbb_IDCate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_HD);
            this.Controls.Add(this.txt_GPU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Image);
            this.Controls.Add(this.txt_RAM);
            this.Controls.Add(this.txt_CPU);
            this.Controls.Add(this.txt_Monitor);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_PDCom);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dtgv_LT);
            this.Name = "frmQLLaptop";
            this.Text = "frmQLLaptop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLLaptop_FormClosing);
            this.Load += new System.EventHandler(this.frmQLLaptop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_PDCom;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dtgv_LT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.TextBox txt_RAM;
        private System.Windows.Forms.TextBox txt_CPU;
        private System.Windows.Forms.TextBox txt_Monitor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_HD;
        private System.Windows.Forms.TextBox txt_GPU;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button txt_TK;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cbb_IDCate;
    }
}