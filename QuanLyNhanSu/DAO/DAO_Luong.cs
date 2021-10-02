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

        public List<SALARY> LayDSLuongReport()
        {
            var ds = db.SALARies.Select(s => s).ToList();
            return ds;
        }

        public List<SALARY_DETAIL> LayDSChiTietLuongReport()
        {
            var ds = db.SALARY_DETAIL.Select(s => s).ToList();
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


        public bool KiemTraLuongTheoSalaryID(SALARY s)
        {
            SALARY o = db.SALARies.Find(s.SALARYID);
            if (s != null)
            {
                return true;
            }
            else return false;
        }


        public int TimSalaryID_Tu_PositionID(SALARY s)
        {
            try
            {
                var query = (from sa in db.SALARies
                             where sa.POSITIONID == s.POSITIONID
                             select sa.SALARYID).ToList();
                int value = query[0];
                    Console.WriteLine("SalaryID = " + value + " ---PositionID = " + s.POSITIONID);

                return value;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }

        public bool SuaLuongTheoPositionID(SALARY s)
        {
            try
            {
                int ID = TimSalaryID_Tu_PositionID(s);

                SALARY o = db.SALARies.Find(ID);
                o.BASICSALARY = s.BASICSALARY;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở CSDL!!!");
                Console.WriteLine("-- DAO -> SuaLuongTheoPositionID");
                Console.WriteLine(ex.Message +"\n--");
                return false;
            }
            return true;
        }

        public bool XoaLuongTheoSalaryID(SALARY s)
        {
            try
            {
                
                SALARY salary = db.SALARies.Find(s.SALARYID);
                db.SALARies.Remove(salary);
                db.SaveChanges();      
            }
            catch (Exception ex)
            {
                Console.WriteLine("s.SALARYID " + s.SALARYID + " - " +  ex.Message);
                MessageBox.Show("Không thể xóa mã lương này! \nMã lương tồn tại ở bảng Chi tiết lương");
                return false;
                
            }
            return true;
        }

    }
}
