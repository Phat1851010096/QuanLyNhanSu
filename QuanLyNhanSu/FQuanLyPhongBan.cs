using QuanLyNhanSu.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FQuanLyPhongBan : Form
    {
        BUS_PhongBan busPB;
        public FQuanLyPhongBan()
        {

            InitializeComponent();
            busPB = new BUS_PhongBan();
        }


        private void HienDSPB()
        {
            gVPhongBan.DataSource = null;
            busPB.HienDSPB(gVPhongBan);
            gVPhongBan.Columns[0].Width = ((int)(gVPhongBan.Width * 0.3));
            gVPhongBan.Columns[1].Width = ((int)(gVPhongBan.Width * 0.3));
            gVPhongBan.Columns[2].Width = ((int)(gVPhongBan.Width * 0.3));
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DEPARTMENT dh = new DEPARTMENT();
            dh.DEPARTMENTNAME = txtTenPhong.Text;
            dh.FOUNDEDDATE = dateTime_NTL.Value;

            if (busPB.ThemPB(dh))
            {
                MessageBox.Show("Thêm phòng ban thành công");
                busPB.HienDSPB(gVPhongBan);
            }
            else
            {
                MessageBox.Show("Thêm phòng ban thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DEPARTMENT d = new DEPARTMENT();
            d.DEPARTMENTID = int.Parse(txtMaPhong.Text);
            d.DEPARTMENTNAME = txtTenPhong.Text;

            //Gọi sự kiện sửa của BUS
            if (busPB.SuaPB(d))
            {
                MessageBox.Show("Sửa thông tin thành công");
                busPB.HienDSPB(gVPhongBan);
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DEPARTMENT d = new DEPARTMENT();
            d.DEPARTMENTID = int.Parse(txtMaPhong.Text);

            //Gọi sự kiện xóa của BUS
            if (busPB.XoaPB(d))
            {
                MessageBox.Show("Xóa phòng ban thành công");
                busPB.HienDSPB(gVPhongBan);
            }
            else
            {
                MessageBox.Show("Xóa phòng ban thất bại");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gVPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPhongBan.Rows.Count)
            {
                txtMaPhong.Enabled = false;
                txtMaPhong.Text = gVPhongBan.Rows[e.RowIndex].Cells["DEPARTMENTID"].Value.ToString();
                txtTenPhong.Text = gVPhongBan.Rows[e.RowIndex].Cells["DEPARTMENTNAME"].Value.ToString();
                dateTime_NTL.Text = gVPhongBan.Rows[e.RowIndex].Cells["FOUNDEDDATE"].Value.ToString();
            }
        }

        private void FQuanLyPhongBan_Load(object sender, EventArgs e)
        {
            HienDSPB();
        }
    }


}
