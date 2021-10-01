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
    class DAO_ChucVu
    {

        
        QLNhanSuEntities db;
        //Phat

        //Dang
        public DAO_ChucVu() // ket noi database
        {
            db = new QLNhanSuEntities();
        }

        public dynamic LayDSChucVu()
        {
            var ds = db.POSITIONs.Select(s => new
            {
                s.POSITIONID,
                s.DEPARTMENT.DEPARTMENTNAME,
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

        public void ThemCV(POSITION p)
        {
            try
            {
                db.POSITIONs.Add(p);
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


        public bool KiemTraChucVu(POSITION p)
        {
            POSITION de = db.POSITIONs.Find(p.POSITIONID);
            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void XoaCV(POSITION p)
        {
            POSITION de = db.POSITIONs.Find(p.POSITIONID);
            db.POSITIONs.Remove(de);
            db.SaveChanges();
        }

        public void SuaCV(POSITION p)
        {
            POSITION de = db.POSITIONs.Find(p.POSITIONID);
            try {

                de = db.POSITIONs.First(s => s.POSITIONID == p.POSITIONID);
                //de.POSITIONID = p.POSITIONID;
                de.DEPARTMENTID = p.DEPARTMENTID;
                de.NAME = p.NAME;

                db.SaveChanges();
                }
            catch(Exception)
            {           
            }

            db.SaveChanges();
        }


        //Dung

    }
}
