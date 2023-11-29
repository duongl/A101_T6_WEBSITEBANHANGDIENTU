
namespace GUI
{
    partial class frmThongKe
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
            this.dtgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.dTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ThongKe
            // 
            this.dtgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThongKe.Location = new System.Drawing.Point(28, 28);
            this.dtgv_ThongKe.Name = "dtgv_ThongKe";
            this.dtgv_ThongKe.Size = new System.Drawing.Size(920, 366);
            this.dtgv_ThongKe.TabIndex = 1;
            // 
            // dTP_DenNgay
            // 
            this.dTP_DenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_DenNgay.Location = new System.Drawing.Point(259, 448);
            this.dTP_DenNgay.Name = "dTP_DenNgay";
            this.dTP_DenNgay.Size = new System.Drawing.Size(126, 22);
            this.dTP_DenNgay.TabIndex = 37;
            // 
            // dTP_TuNgay
            // 
            this.dTP_TuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_TuNgay.Location = new System.Drawing.Point(114, 448);
            this.dTP_TuNgay.Name = "dTP_TuNgay";
            this.dTP_TuNgay.Size = new System.Drawing.Size(126, 22);
            this.dTP_TuNgay.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(295, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thống kê:";
            // 
            // btn_Loc
            // 
            this.btn_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loc.Location = new System.Drawing.Point(403, 448);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(74, 26);
            this.btn_Loc.TabIndex = 34;
            this.btn_Loc.Text = "Xem";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.ForeColor = System.Drawing.Color.Red;
            this.txt_TongTien.Location = new System.Drawing.Point(194, 492);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(95, 22);
            this.txt_TongTien.TabIndex = 32;
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(499, 448);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(74, 26);
            this.btn_reset.TabIndex = 38;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(874, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 39;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.dTP_DenNgay);
            this.Controls.Add(this.dTP_TuNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.dtgv_ThongKe);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKe_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ThongKe;
        private System.Windows.Forms.DateTimePicker dTP_DenNgay;
        private System.Windows.Forms.DateTimePicker dTP_TuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button button1;
    }
}