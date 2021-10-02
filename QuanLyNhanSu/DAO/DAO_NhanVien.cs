using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Linq;
using System.Data.SqlClient;
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
                s.DEPARTMENT.DEPARTMENTNAME,
                s.DATESTARTWORKING,
                s.PHONE,
                s.ADDRESS,
                s.BIRTHDATE,
                s.SEX
            }).ToList();
            return ds;
        }


        public List<EMPLOYEE> LayDSNVReport()
        {
            var ds = db.EMPLOYEEs.Select(s => s).ToList();
            return ds;
        }


        public dynamic LayDSChucVu()
        {
            var ds = db.POSITIONs.Select(s => new
            {
                s.POSITIONID,
                s.NAME
            }).ToList();
            return ds;
        }

        public dynamic LayDSPhongBan()
        {
            var ds = db.DEPARTMENTs.Select(s => new
            {
                s.DEPARTMENTID,
                s.DEPARTMENTNAME
            }).ToList();
            return ds;
        }

        public void ThemNhanVien(EMPLOYEE e)
        {
            try
            {
                db.EMPLOYEEs.Add(e);
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        public bool KiemTraNhanVien(EMPLOYEE e)
        {
            EMPLOYEE o = db.EMPLOYEEs.Find(e.EMPLOYEEID);
            if (e != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void XoaNhanVien(EMPLOYEE e)
        {
            EMPLOYEE o = db.EMPLOYEEs.Find(e.EMPLOYEEID);
            db.EMPLOYEEs.Remove(o);
            db.SaveChanges();
        }

        public void SuaNhanVien(EMPLOYEE e)
        {
            EMPLOYEE o = db.EMPLOYEEs.Find(e.EMPLOYEEID);
            o.FULLNAME = e.FULLNAME;
            o.POSITIONID = e.POSITIONID;
            o.DEPARTMENTID = e.DEPARTMENTID;
            o.DATESTARTWORKING = e.DATESTARTWORKING;
            o.PHONE = e.PHONE;
            o.ADDRESS = e.ADDRESS;
            o.BIRTHDATE = e.BIRTHDATE;
            o.SEX = e.SEX;

            db.SaveChanges();
        }



        //Dang















        //Dung







    }
}
