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
    class DAO_PhongBan
    {


        //Phat



        //Dang   
        QLNhanSuEntities db;


        public DAO_PhongBan() // ket noi database
        {
            db = new QLNhanSuEntities();
        }

        public dynamic LayDSPhongban1()
        {
            var ds = db.DEPARTMENTs.Select(s => new
            {
                s.DEPARTMENTID,
                s.DEPARTMENTNAME,
                s.FOUNDEDDATE
            }).ToList();
            return ds;

        }

        public void ThemPB(DEPARTMENT d)
        {
            try
            {
                db.DEPARTMENTs.Add(d);
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


        public bool KiemTraNhanVien(DEPARTMENT d)
        {
            DEPARTMENT de = db.DEPARTMENTs.Find(d.DEPARTMENTID);
            if (d != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void XoaPB(DEPARTMENT d)
        {
            DEPARTMENT de = db.DEPARTMENTs.Find(d.DEPARTMENTID);
            db.DEPARTMENTs.Remove(de);
            db.SaveChanges();
        }

        public void SuaPB(DEPARTMENT d)
        {
            DEPARTMENT de = db.DEPARTMENTs.Find(d.DEPARTMENTID);
            de.DEPARTMENTID = d.DEPARTMENTID;
            de.DEPARTMENTNAME = d.DEPARTMENTNAME;
            de.FOUNDEDDATE = d.FOUNDEDDATE;
            db.SaveChanges();
        }



        //Dung

    }
}
