using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    class DAO_Luong
    {
        QLNhanSuEntities db;
        //Phat


        //Dang



        //Dung

        public DAO_Luong()
        {
            db = new QLNhanSuEntities();
        }


        public dynamic LayDSLuong()
        {
            var ds = db.SALARies.Select(s => new
            {
                s.SALARYID,
                s.POSITION.NAME,
                s.BASICSALARY

            }).ToList();
            return ds;
        }

        public dynamic LayDSChucVu()
        {
            var ds = db.POSITIONs.Select(s => new {
                s.POSITIONID,
                s.NAME
            }).ToList();
            return ds;
        }


    }
}
