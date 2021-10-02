using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

        public List<EMPLOYEE> HienThiDSNhanVien()
        {
            return dNhanVien.LayDSNVReport();
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

        public bool ThemNhanVien(EMPLOYEE e)
        {

            try
            {
                dNhanVien.ThemNhanVien(e);
                return true;
            }
            catch (System.Data.Linq.DuplicateKeyException)
            {
                return false;
            }
        }

        public bool XoaNhanVien(EMPLOYEE e)
        {
            if (dNhanVien.KiemTraNhanVien(e))
            {
                try
                {
                    dNhanVien.XoaNhanVien(e);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool SuaNhanVien(EMPLOYEE e)
        {
            if (dNhanVien.KiemTraNhanVien(e))
            {
                try
                {
                    dNhanVien.SuaNhanVien(e);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }




        //Dang















        //Dung







    }
}
