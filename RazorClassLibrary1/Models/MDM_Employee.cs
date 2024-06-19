using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorClassLibrary1.Models
{
    public class MDM_Employee
    {
        public string FacID { get; set; }//varchar(10)
        public Guid EmployeeID { get; set; } // uniqueidentifier
        public string EmployeeCode { get; set; }//nvarchar(15)
        public int? PositionID { get; set; }//int 
        public string PositionCode { get; set; }//nvarchar(50)
        public string PositionName { get; set; }//nvarchar(500)
        public int? TechniqueID { get; set; }//int
        public string TechniqueCode { get; set; }//nvarchar(50)
        public string TechniqueName { get; set; }//nvarchar(500)
        public Guid? UserID { get; set; } // uniqueidentifier
        public string UserName { get; set; }//varchar(100)
        public string FullName { get; set; }//nvarchar(500)
        public string FullNameWithTechniqueCode { get; set; }//nvarchar(500)
        public string FullNameWithPositionCode { get; set; }//nvarchar(500)
        public int? EmpDepartmentID { get; set; }//int
        public string EmpDepartmentName { get; set;}//nvarchar(200)
        public string Email { get; set;}//nvarchar200

    }
}
