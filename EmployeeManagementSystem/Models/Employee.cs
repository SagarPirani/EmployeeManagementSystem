using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeContactNo { get; set; }
        public string EmployeeGander { get; set; }
        public decimal EmployeeSalary { get; set; }
        public DateTime EmployeeJoinDate { get; set; }
        public string EmployeePhoto { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public int DesignationID { get; set; }
        public virtual Designation Designation { get; set; }

    }
}