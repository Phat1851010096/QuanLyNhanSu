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
     class BUS_ChucVu
    {
        //Phat
        //Dang
        DAO_ChucVu dChucVu; 
        public BUS_ChucVu()
        {
            dChucVu = new DAO_ChucVu();
        }

        public void HienDSCV(DataGridView dg)
        {
            dg.DataSource = dChucVu.LayDSChucVu();
        }

        public void LayDSChucVu(ComboBox cb)
        {
            cb.DataSource = dChucVu.LayDSChucVu();
            cb.DisplayMember = "NAME";
            cb.ValueMember = "POSITIONID";
        }

        public void LayDSPhongBan(ComboBox cb)
        {
            cb.DataSource = dChucVu.LayDSPhongBan();
            cb.DisplayMember = "DEPARTMENTNAME";
            cb.ValueMember = "DEPARTMENTID";
        }


        public bool ThemCV(POSITION p)
        {

            try
            {
                dChucVu.ThemCV(p);
                return true;
            }
            catch (System.Data.Linq.DuplicateKeyException)
            {
                return false;
            }
        }

        public bool XoaCV(POSITION p)
        {
            if (dChucVu.KiemTraChucVu(p))
            {
                try
                {
                    dChucVu.XoaCV(p);
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


        public bool SuaCV(POSITION p)
        {
            if (dChucVu.KiemTraChucVu(p))
            {
                try
                {
                    dChucVu.SuaCV(p);
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

