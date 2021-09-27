using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    class DAO_NhanVien
    {
        //Phat
        QLNhanSuEntities db;

        public DAO_NhanVien()
        {
            db = new QLNhanSuEntities();
        }

        public dynamic LayDSNV()
        {
            var ds = db.EMPLOYEEs.Select(s => new
            {
                s.EMPLOYEEID,
                s.FULLNAME,
                s.POSITION.NAME,
                s.DATESTARTWORKING,
                s.PHONE,
                s.ADDRESS,
                s.BIRTHDATE,
                s.SEX
            }).ToList();
            return ds;
        }







        //Dang















        //Dung







    }
}
