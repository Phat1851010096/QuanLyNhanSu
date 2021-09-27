namespace QuanLyNhanSu
{
    partial class FQuanLyChucVu
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
            this.tenchucvu = new System.Windows.Forms.Label();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tenchucvu);
            this.groupBox1.Controls.Add(this.cbPhongBan);
            this.groupBox1.Controls.Add(this.txtMaChucVu);
            this.groupBox1.Controls.Add(this.txtTenChucVu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // tenchucvu
            // 
            this.tenchucvu.AutoSize = true;
            this.tenchucvu.Location = new System.Drawing.Point(31, 91);
            this.tenchucvu.Name = "tenchucvu";
            this.tenchucvu.Size = new System.Drawing.Size(57, 15);
            this.tenchucvu.TabIndex = 3;
            this.tenchucvu.Text = "Phòng ban";
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(104, 88);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(121, 23);
            this.cbPhongBan.TabIndex = 2;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(101, 41);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(149, 21);
            this.txtMaChucVu.TabIndex = 1;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(349, 38);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(149, 21);
            this.txtTenChucVu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chức vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(75, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btThoat
            // 
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(452, 20);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(70, 28);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát ";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btXoa.Location = new System.Drawing.Point(356, 20);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(70, 28);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa   ";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(180, 20);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(70, 28);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm ";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(265, 20);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(70, 28);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa   ";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
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
            // FQuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FQuanLyChucVu";
            this.Text = "PHÒNG BAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tenchucvu;
        private System.Windows.Forms.ComboBox cbPhongBan;
    }
}