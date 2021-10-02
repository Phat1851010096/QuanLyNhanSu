using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    class BUS_Luong
    {
        DAO_Luong dLuong;
        //Phat


        //Dang



        //Dung
        public BUS_Luong()
        {
            dLuong = new DAO_Luong();
        }

        public void LayDSLuong(DataGridView dg)
        {
            dg.DataSource = dLuong.LayDSLuong();
        }

        public List<SALARY> LayDSLuongReport()
        {
            return dLuong.LayDSLuongReport();
        }

        public List<SALARY_DETAIL> LayDSChiTietLuongReport()
        {
            return dLuong.LayDSChiTietLuongReport();
        }

        public void LayDSChucVu(ComboBox cb)
        {
            cb.DataSource = dLuong.LayDSChucVu();
            cb.DisplayMember = "Name";
            cb.ValueMember = "PositionID";
        }

        public bool TaoLuongChoChucVu(int maChucVu, double luongCoBan)
        {
            return dLuong.TaoLuongChoChucVu(maChucVu, luongCoBan);
        }

        public bool SuaLuongTheoPositionID(SALARY s)
        {
            if (dLuong.SuaLuongTheoPositionID(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaLuongTheoSalaryID(SALARY s)
        {
            if (dLuong.XoaLuongTheoSalaryID(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
