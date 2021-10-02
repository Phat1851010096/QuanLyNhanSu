using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

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
                s.POSITIONID,
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

        public bool TaoLuongChoChucVu(int maChucVu, double luongCoBan)
        {
            bool ketQua = false;

            using (var tran = new TransactionScope())
            {
                try
                {
                    SALARY s = new SALARY();
                    s.POSITIONID = maChucVu;
                    s.BASICSALARY = (decimal)luongCoBan;

                    db.SALARies.Add(s);
                    db.SaveChanges();

                    tran.Complete();
                    ketQua = true;
                }
                catch (Exception ex)
                {
                    ketQua = false; //Quay lui giao tac
                    MessageBox.Show(ex.Message);
                }

            }

            return ketQua;
        }
    }
}
