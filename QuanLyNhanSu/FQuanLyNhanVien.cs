using QuanLyNhanSu.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FQuanLyNhanVien : Form
    {
        BUS_NhanVien busNhanVien;

        public FQuanLyNhanVien()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void HienThiDSNhanVien()
        {
            gVNhanVien.DataSource = null;
            busNhanVien.HienThiDSNhanVien(gVNhanVien);
            gVNhanVien.Columns[0].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[1].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[2].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[3].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[4].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[5].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[6].Width = ((int)(gVNhanVien.Width * 0.2));
            gVNhanVien.Columns[7].Width = ((int)(gVNhanVien.Width * 0.2));
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVNhanVien.Rows.Count)
            {
                txtMaNV.Enabled = false;
                txtMaNV.Text = gVNhanVien.Rows[e.RowIndex].Cells["EMPLOYEEID"].Value.ToString();
                txtHoTen.Text = gVNhanVien.Rows[e.RowIndex].Cells["FULLNAME"].Value.ToString();
                dateTimePicker_NgaySinh.Text = gVNhanVien.Rows[e.RowIndex].Cells["BIRTHDATE"].Value.ToString();
                txtDiaChi.Text = gVNhanVien.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString();
                txtSDT.Text = gVNhanVien.Rows[e.RowIndex].Cells["PHONE"].Value.ToString();
                dateTimePicker_NgayVaoLam.Text = gVNhanVien.Rows[e.RowIndex].Cells["DATESTARTWORKING"].Value.ToString();
                txtGioiTinh.Text = gVNhanVien.Rows[e.RowIndex].Cells["SEX"].Value.ToString();
                cbPhongBan.Text = gVNhanVien.Rows[e.RowIndex].Cells["DEPARTMENTNAME"].Value.ToString();
                cbChucVu.Text = gVNhanVien.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            }
        }

        private void FQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            busNhanVien.LayDSChucVu(cbChucVu);
            busNhanVien.LayDSPhongBan(cbPhongBan);
            //busNhanVien.LayDSGoiTinh(cbGioiTinh);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            EMPLOYEE nhanVien = new EMPLOYEE();
            nhanVien.DATESTARTWORKING = dateTimePicker_NgayVaoLam.Value;
            nhanVien.BIRTHDATE = dateTimePicker_NgaySinh.Value;
            nhanVien.POSITIONID = int.Parse(cbChucVu.SelectedValue.ToString());
            nhanVien.DEPARTMENTID = int.Parse(cbPhongBan.SelectedValue.ToString());
            nhanVien.SEX = txtGioiTinh.Text;
            nhanVien.FULLNAME = txtHoTen.Text;
            nhanVien.PHONE = decimal.Parse(txtSDT.Text);
            nhanVien.ADDRESS = txtDiaChi.Text;

            //Gọi sự kiện thêm của BUS
            if (busNhanVien.ThemNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                busNhanVien.HienThiDSNhanVien(gVNhanVien);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }

        
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            EMPLOYEE d = new EMPLOYEE();
            d.EMPLOYEEID = int.Parse(txtMaNV.Text);

            //Gọi sự kiện xóa của BUS
            if (busNhanVien.XoaNhanVien(d))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                busNhanVien.HienThiDSNhanVien(gVNhanVien);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            EMPLOYEE d = new EMPLOYEE();
            d.EMPLOYEEID = int.Parse(txtMaNV.Text);
            d.FULLNAME = txtHoTen.Text;
            d.POSITIONID = int.Parse(cbChucVu.SelectedValue.ToString());
            d.BIRTHDATE = dateTimePicker_NgaySinh.Value;
            d.DATESTARTWORKING = dateTimePicker_NgayVaoLam.Value;
            d.DEPARTMENTID = int.Parse(cbPhongBan.SelectedValue.ToString());
            d.ADDRESS = txtDiaChi.Text;
            d.PHONE = decimal.Parse(txtSDT.Text);
            d.SEX = txtGioiTinh.Text;

            //Gọi sự kiện sửa của BUS
            if (busNhanVien.SuaNhanVien(d))
            {
                MessageBox.Show("Sửa thông tin thành công");
                busNhanVien.HienThiDSNhanVien(gVNhanVien);
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại");
            }
        }
    }
}
