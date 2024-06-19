using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorClassLibrary1.Models
{
    public class CN_DoctorDecision
    {
        public Guid PhysicianAdmissionID { get; set; }// uniqueidentifier
        public Guid? DocumentID { get; set; }// uniqueidentifier
        public Guid? PatientID { get; set; }// uniqueidentifier
        public Guid? FacAdmissionID { get; set; }// uniqueidentifier
        public string FacID { get; set; }//varchar(10)
        public int FinalDecisionID { get; set; }//tinyint
        public string TomTatBenhAn {  get; set; }//nvarchar(2000)
        public string DeNghiKhamChuyenKhoa { get; set; }//nvarchar(2000)
        public int HospitalCode { get; set; }//int
        public int DepartmentID { get; set; }//int
        public int RoomID { get; set; }//int
        public int PatientOutcomeID { get; set;}//int
        public DateTime? CompletedOn { get; set; } // datetime
        public Guid? CompletedBy { get; set; } // uniqueidentifier
        public DateTime? CreatedOn { get; set; } // datetime
        public Guid? CreatedBy { get; set; } // uniqueidentifier
        public DateTime? ModifiedOn { get; set; } // datetime
        public Guid? ModifiedBy { get; set; } // uniqueidentifier
        public string Reason { get; set; }//nvarchar(Max)
        public string Description { get; set; }//nvarchar(Max)
    }
}
