using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ModelEx.Models
{
    public class Emp
    {
        public Int64    EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public decimal Salary { get; set; }
        public Emp()
        {
            this.EmpID = 121;
            this.EmpName = "Sunil";
            this.DeptName = "Sales";
            this.Salary = 45000;
        }

        public static List<Emp> GetEmps()
        {
            List<Emp> emps = new List<Emp>() {
            new Emp() { EmpID = 121, EmpName = "Sunil", DeptName = "Computer", Salary = 55000 },
            new Emp() { EmpID = 122, EmpName = "Amol", DeptName = "Sales", Salary = 65000 },
            new Emp() { EmpID = 123, EmpName = "Sudhir", DeptName = "Computer", Salary = 55000 },
            new Emp() { EmpID = 124, EmpName = "Ajit", DeptName = "Marketing", Salary = 35000 },
            new Emp() { EmpID = 125, EmpName = "Amol", DeptName = "Sales", Salary = 95000 }
            };

            return emps;
        }
    }
}
