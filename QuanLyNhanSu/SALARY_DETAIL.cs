//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanSu
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALARY_DETAIL
    {
        public int EMPLOYEEID { get; set; }
        public int SALARYID { get; set; }
        public Nullable<System.DateTime> TIMEGETSALARY { get; set; }
        public short COEFFICIENTSALARY { get; set; }
        public short COEFFICIENTALLOWANCE { get; set; }
    
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual SALARY SALARY { get; set; }
    }
}
