using System;
using System.Collections.Generic;
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

        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = dLuong.LayDSLuong();
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



    }
}
