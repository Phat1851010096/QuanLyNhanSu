namespace QuanLyNhanSu
{
    partial class FTimKiemNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.radioButton_PhongBan = new System.Windows.Forms.RadioButton();
            this.radioButton_ChucVu = new System.Windows.Forms.RadioButton();
            this.radioButton_Ten = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.radioButton_PhongBan);
            this.groupBox1.Controls.Add(this.radioButton_ChucVu);
            this.groupBox1.Controls.Add(this.radioButton_Ten);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(367, 146);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(171, 146);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // radioButton_PhongBan
            // 
            this.radioButton_PhongBan.AutoSize = true;
            this.radioButton_PhongBan.Location = new System.Drawing.Point(450, 66);
            this.radioButton_PhongBan.Name = "radioButton_PhongBan";
            this.radioButton_PhongBan.Size = new System.Drawing.Size(75, 19);
            this.radioButton_PhongBan.TabIndex = 4;
            this.radioButton_PhongBan.TabStop = true;
            this.radioButton_PhongBan.Text = "Phòng ban";
            this.radioButton_PhongBan.UseVisualStyleBackColor = true;
            // 
            // radioButton_ChucVu
            // 
            this.radioButton_ChucVu.AutoSize = true;
            this.radioButton_ChucVu.Location = new System.Drawing.Point(281, 66);
            this.radioButton_ChucVu.Name = "radioButton_ChucVu";
            this.radioButton_ChucVu.Size = new System.Drawing.Size(66, 19);
            this.radioButton_ChucVu.TabIndex = 3;
            this.radioButton_ChucVu.TabStop = true;
            this.radioButton_ChucVu.Text = "Chức vụ";
            this.radioButton_ChucVu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ten
            // 
            this.radioButton_Ten.AutoSize = true;
            this.radioButton_Ten.Location = new System.Drawing.Point(103, 66);
            this.radioButton_Ten.Name = "radioButton_Ten";
            this.radioButton_Ten.Size = new System.Drawing.Size(64, 19);
            this.radioButton_Ten.TabIndex = 2;
            this.radioButton_Ten.TabStop = true;
            this.radioButton_Ten.Text = "Tên NV";
            this.radioButton_Ten.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(223, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(335, 21);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(75, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 169);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // FTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTimKiemNV";
            this.Text = "PHÒNG BAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton_PhongBan;
        private System.Windows.Forms.RadioButton radioButton_ChucVu;
        private System.Windows.Forms.RadioButton radioButton_Ten;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTimKiem;
    }
}