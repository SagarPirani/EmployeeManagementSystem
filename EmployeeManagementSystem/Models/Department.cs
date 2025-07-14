using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
       
        public virtual ICollection<Designation> Designations { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}