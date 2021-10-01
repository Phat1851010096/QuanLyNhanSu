using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;

namespace QuanLyNhanSu
{
    public partial class FQuanLyChucVu : Form
    {
        BUS_ChucVu busCV;
        public FQuanLyChucVu()
        {
            InitializeComponent();
            busCV = new BUS_ChucVu();
        }

        private void HienDSCV()
        {
            gVChucVu.DataSource = null;
            busCV.HienDSCV(gVChucVu);
            gVChucVu.Columns[0].Width = ((int)(gVChucVu.Width * 0.3)); 
            gVChucVu.Columns[1].Width = ((int)(gVChucVu.Width * 0.3));
            gVChucVu.Columns[2].Width = ((int)(gVChucVu.Width * 0.3));

        }

       

        private void btThem_Click(object sender, EventArgs e)
        {
            POSITION p = new POSITION();
            p.DEPARTMENTID = int.Parse(cbPhongBan.SelectedValue.ToString());
            p.NAME = txtTenChucVu.Text;
           

            if (busCV.ThemCV(p))
            {
                MessageBox.Show("Thêm chức vụ thành công");
                busCV.HienDSCV(gVChucVu);
            }
            else
            {
                MessageBox.Show("Thêm chức vụ thất bại");
            }
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            POSITION p = new POSITION();
            txtMaChucVu.Enabled = false;

            p.POSITIONID = int.Parse(txtMaChucVu.Text);
            p.DEPARTMENTID = int.Parse(cbPhongBan.SelectedValue.ToString());
            p.NAME = txtTenChucVu.Text;

            busCV.HienDSCV(gVChucVu);




            //Gọi sự kiện sửa của BUS
            if (busCV.SuaCV(p))
            {
                MessageBox.Show("Sửa thông tin thành công");
                busCV.HienDSCV(gVChucVu);
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            POSITION p = new POSITION();
            p.POSITIONID = int.Parse(txtMaChucVu.Text);


            //Gọi sự kiện xóa của BUS
            if (busCV.XoaCV(p))
            {
                MessageBox.Show("Xóa chức vụ thành công");
                busCV.HienDSCV(gVChucVu);
            }
            else
            {
                MessageBox.Show("Xóa chức vụ thất bại");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gVChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVChucVu.Rows.Count)
            {
                txtMaChucVu.Enabled = false;
                txtMaChucVu.Text = gVChucVu.Rows[e.RowIndex].Cells["POSITIONID"].Value.ToString();
                txtTenChucVu.Text = gVChucVu.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
                cbPhongBan.Text = gVChucVu.Rows[e.RowIndex].Cells["DEPARTMENTNAME"].Value.ToString();
            }
        }

        private void FQuanLyChucVu_Load(object sender, EventArgs e)
        {
            HienDSCV();
            busCV.LayDSPhongBan(cbPhongBan);
        }
    }
}
