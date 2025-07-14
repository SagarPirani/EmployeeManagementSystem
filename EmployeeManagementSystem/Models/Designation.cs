using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class Designation
    {
        public int DesignationID { get; set; }
        public string DesignationTitle { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        
    }
}