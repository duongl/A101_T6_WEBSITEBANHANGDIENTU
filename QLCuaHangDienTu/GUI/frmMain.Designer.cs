
namespace GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýAcccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLaptopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiLaptopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.quảnLýLaptopToolStripMenuItem,
            this.quảnLýLoạiLaptopToolStripMenuItem,
            this.quảnLýAcccountToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýAcccountToolStripMenuItem
            // 
            this.quảnLýAcccountToolStripMenuItem.Name = "quảnLýAcccountToolStripMenuItem";
            this.quảnLýAcccountToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.quảnLýAcccountToolStripMenuItem.Text = "Quản Lý Acccount";
            this.quảnLýAcccountToolStripMenuItem.Click += new System.EventHandler(this.quảnLýAcccountToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý Hóa đơn";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // quảnLýLaptopToolStripMenuItem
            // 
            this.quảnLýLaptopToolStripMenuItem.Name = "quảnLýLaptopToolStripMenuItem";
            this.quảnLýLaptopToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.quảnLýLaptopToolStripMenuItem.Text = "Quản Lý Laptop";
            this.quảnLýLaptopToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLaptopToolStripMenuItem_Click);
            // 
            // quảnLýLoạiLaptopToolStripMenuItem
            // 
            this.quảnLýLoạiLaptopToolStripMenuItem.Name = "quảnLýLoạiLaptopToolStripMenuItem";
            this.quảnLýLoạiLaptopToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.quảnLýLoạiLaptopToolStripMenuItem.Text = "Quản Lý Loại Laptop";
            this.quảnLýLoạiLaptopToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiLaptopToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay Đổi Mật Khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýAcccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLaptopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiLaptopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
    }
}