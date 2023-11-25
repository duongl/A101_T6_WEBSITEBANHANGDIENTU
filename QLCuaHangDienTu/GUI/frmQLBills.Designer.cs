
namespace GUI
{
    partial class frmQLBills
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_TK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_IDA = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.dtp_TK = new System.Windows.Forms.DateTimePicker();
            this.dtp_DP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            this.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "IDAccount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(754, 469);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 33;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(110, 13);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(29, 13);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(91, 221);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(126, 20);
            this.txt_Status.TabIndex = 26;
            this.txt_Status.TextChanged += new System.EventHandler(this.txt_Status_TextChanged);
            this.txt_Status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Status_KeyPress);
            // 
            // txt_IDA
            // 
            this.txt_IDA.Location = new System.Drawing.Point(91, 177);
            this.txt_IDA.Name = "txt_IDA";
            this.txt_IDA.Size = new System.Drawing.Size(126, 20);
            this.txt_IDA.TabIndex = 25;
            this.txt_IDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDA_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(91, 138);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(126, 20);
            this.txt_id.TabIndex = 24;
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.Location = new System.Drawing.Point(250, 125);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.Size = new System.Drawing.Size(531, 320);
            this.dtgv_Bill.TabIndex = 23;
            this.dtgv_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Bill_CellClick);
            // 
            // dtp_TK
            // 
            this.dtp_TK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TK.Location = new System.Drawing.Point(513, 12);
            this.dtp_TK.Name = "dtp_TK";
            this.dtp_TK.Size = new System.Drawing.Size(139, 20);
            this.dtp_TK.TabIndex = 42;
            // 
            // dtp_DP
            // 
            this.dtp_DP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DP.Location = new System.Drawing.Point(91, 264);
            this.dtp_DP.Name = "dtp_DP";
            this.dtp_DP.Size = new System.Drawing.Size(139, 20);
            this.dtp_DP.TabIndex = 43;
            // 
            // frmQLBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 523);
            this.Controls.Add(this.dtp_DP);
            this.Controls.Add(this.dtp_TK);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_IDA);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dtgv_Bill);
            this.Name = "frmQLBills";
            this.Text = "frmQLBills";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLBills_FormClosing);
            this.Load += new System.EventHandler(this.frmQLBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button txt_TK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_IDA;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dtgv_Bill;
        private System.Windows.Forms.DateTimePicker dtp_TK;
        private System.Windows.Forms.DateTimePicker dtp_DP;
    }
}