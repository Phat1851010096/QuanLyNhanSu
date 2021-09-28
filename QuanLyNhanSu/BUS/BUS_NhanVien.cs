using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    class BUS_NhanVien
    {
        //Phat
        DAO_NhanVien dNhanVien;
        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
        }

        public void HienThiDSNhanVien(DataGridView dg)
        {
            dg.DataSource = dNhanVien.LayDSNV();
        }

        public void LayDSChucVu(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSChucVu();
            cb.DisplayMember = "NAME";
            cb.ValueMember = "POSITIONID";
        }

        public void LayDSPhongBan(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSPhongBan();
            cb.DisplayMember = "DEPARTMENTNAME";
            cb.ValueMember = "DEPARTMENTID";
        }

        public void LayDSGoiTinh(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSGioiTinh();
            cb.DisplayMember = "SEX";
        }










        //Dang















        //Dung







    }
}
