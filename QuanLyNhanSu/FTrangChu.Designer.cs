namespace QuanLyNhanSu
{
    partial class FTrangChu
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
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtinNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiemNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýPhòngBanToolStripMenuItem,
            this.quảnLýChứcVụToolStripMenuItem,
            this.quảnLýLươngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongtinNVToolStripMenuItem,
            this.timKiemNVToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // thongtinNVToolStripMenuItem
            // 
            this.thongtinNVToolStripMenuItem.Name = "thongtinNVToolStripMenuItem";
            this.thongtinNVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thongtinNVToolStripMenuItem.Text = "Thông tin nhân viên";
            this.thongtinNVToolStripMenuItem.Click += new System.EventHandler(this.thongtinNVToolStripMenuItem_Click);
            // 
            // timKiemNVToolStripMenuItem
            // 
            this.timKiemNVToolStripMenuItem.Name = "timKiemNVToolStripMenuItem";
            this.timKiemNVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timKiemNVToolStripMenuItem.Text = "Tìm kiếm nhân viên";
            this.timKiemNVToolStripMenuItem.Click += new System.EventHandler(this.timKiemNVToolStripMenuItem_Click);
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.quảnLýPhòngBanToolStripMenuItem.Text = "Quản lý phòng ban";
            this.quảnLýPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngBanToolStripMenuItem_Click);
            // 
            // quảnLýChứcVụToolStripMenuItem
            // 
            this.quảnLýChứcVụToolStripMenuItem.Name = "quảnLýChứcVụToolStripMenuItem";
            this.quảnLýChứcVụToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.quảnLýChứcVụToolStripMenuItem.Text = "Quản lý chức vụ";
            this.quảnLýChứcVụToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChứcVụToolStripMenuItem_Click);
            // 
            // quảnLýLươngToolStripMenuItem
            // 
            this.quảnLýLươngToolStripMenuItem.Name = "quảnLýLươngToolStripMenuItem";
            this.quảnLýLươngToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.quảnLýLươngToolStripMenuItem.Text = "Quản lý lương";
            this.quảnLýLươngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLươngToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(271, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ứng dụng Quản lý nhân sự";
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.stt_vui_ve_bien_jpg7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongtinNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiemNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLươngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

