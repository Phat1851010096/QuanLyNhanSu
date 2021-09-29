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
    public partial class FTimKiemNV : Form
    {
        BUS_NhanVien busNhanVien;
        QLNhanSuEntities db;

        public FTimKiemNV()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
            db = new QLNhanSuEntities();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();
            gVNhanVien.DataSource = db.EMPLOYEEs.Where(emp => emp.FULLNAME.Contains(keyword)
                                                        || emp.DEPARTMENT.DEPARTMENTNAME.Contains(cbPhongBan.Text)   
                                                        || emp.POSITION.NAME.Contains(cbChucVu.Text)
                                            ).Select(emp => new
                                            {
                                                emp.EMPLOYEEID,
                                                emp.FULLNAME,
                                                emp.POSITION.NAME,
                                                emp.DEPARTMENT.DEPARTMENTNAME,
                                                emp.DATESTARTWORKING,
                                                emp.PHONE,
                                                emp.ADDRESS,
                                                emp.BIRTHDATE,
                                                emp.SEX
                                            }).ToList();

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

        private void FTimKiemNV_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            busNhanVien.LayDSChucVu(cbChucVu);
            busNhanVien.LayDSPhongBan(cbPhongBan);
        }


        private void Reload_Click(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
        }
    }
}
