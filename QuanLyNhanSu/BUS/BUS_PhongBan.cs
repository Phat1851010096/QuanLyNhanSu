using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    class BUS_PhongBan
    {

        //Phat

        //Dang
        DAO_PhongBan dPhongban;
        public BUS_PhongBan()
        {
            dPhongban = new DAO_PhongBan();
        }

        public void HienDSPB(DataGridView dg)
        {
            dg.DataSource = dPhongban.LayDSPhongban1();
        }

        public bool ThemPB(DEPARTMENT d)
        {

            try
            {
                dPhongban.ThemPB(d);
                return true;
            }
            catch (System.Data.Linq.DuplicateKeyException)
            {
                return false;
            }


        }

        public bool XoaPB(DEPARTMENT d)
        {
            if (dPhongban.KiemTraNhanVien(d))
            {
                try
                {
                    dPhongban.XoaPB(d);
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

        public bool SuaPB(DEPARTMENT d)
        {
            if (dPhongban.KiemTraNhanVien(d))
            {
                try
                {
                    dPhongban.SuaPB(d);
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

        //Dung
    }

}

