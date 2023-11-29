
namespace GUI
{
    partial class frmQLAccounts
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
            this.dtgv_Acc = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dpn = new System.Windows.Forms.TextBox();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Acc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Acc
            // 
            this.dtgv_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Acc.Location = new System.Drawing.Point(250, 125);
            this.dtgv_Acc.Name = "dtgv_Acc";
            this.dtgv_Acc.Size = new System.Drawing.Size(531, 320);
            this.dtgv_Acc.TabIndex = 0;
            this.dtgv_Acc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Acc_CellClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(91, 138);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(126, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_dpn
            // 
            this.txt_dpn.Location = new System.Drawing.Point(91, 177);
            this.txt_dpn.Name = "txt_dpn";
            this.txt_dpn.Size = new System.Drawing.Size(126, 20);
            this.txt_dpn.TabIndex = 2;
            // 
            // txt_un
            // 
            this.txt_un.Location = new System.Drawing.Point(91, 221);
            this.txt_un.Name = "txt_un";
            this.txt_un.Size = new System.Drawing.Size(126, 20);
            this.txt_un.TabIndex = 3;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(91, 267);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(126, 20);
            this.txt_pw.TabIndex = 4;
            this.txt_pw.TextChanged += new System.EventHandler(this.txt_pw_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(114, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(216, 12);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(317, 12);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(754, 469);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DisplayName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Type:";
            // 
            // cbb_Type
            // 
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Location = new System.Drawing.Point(91, 307);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(126, 21);
            this.cbb_Type.TabIndex = 23;
            // 
            // frmQLAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.cbb_Type);
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
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_un);
            this.Controls.Add(this.txt_dpn);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dtgv_Acc);
            this.Name = "frmQLAccounts";
            this.Text = "frmQLAccounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLAccounts_FormClosing);
            this.Load += new System.EventHandler(this.frmQLAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Acc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Acc;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_dpn;
        private System.Windows.Forms.TextBox txt_un;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_Type;
    }
}