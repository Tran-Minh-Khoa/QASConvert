using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RazorClassLibrary1.Models
{
    public class CN_PhysicianAdmissions
    {
        public Guid PhysicianAdmissionID { get; set; } // uniqueidentifier
        public string FacID { get; set; } // varchar(10)
        public Guid? FacAdmissionID { get; set; } // uniqueidentifier
        public Guid? PatientID { get; set; } // uniqueidentifier
        public Guid? PrimaryDoctor { get; set; } // uniqueidentifier
        public int? DeptID { get; set; } // int
        public int? RoomID { get; set; } // int
        public string RoomName { get; set; }
        public int? BedID { get; set; } // int
        public Guid? AdmitBy { get; set; } // uniqueidentifier
        public DateTime? AdmitOn { get; set; } // datetime
        public Guid? DischargedBy { get; set; } // uniqueidentifier
        public DateTime? DischargedOn { get; set; } // datetime
        public string AdmitDate { get; set; } // nvarchar(10)
        public string DischargedDate { get; set; } // nvarchar(10)
        public int? AdmitDateAsInt { get; set; } // int
        public int? DischargedDateAsInt { get; set; } // int
        public bool? IsPracticed { get; set; } // bit
        public DateTime? TGBatDauKham { get; set; } // datetime
        public bool? IsKhongKham { get; set; } // bit
        public int? SpecialistID { get; set; } // int
        public Guid? NurseEmpID { get; set; } // uniqueidentifier
        public bool? IsPriority { get; set; } // bit
        public bool? IsTrucTiep { get; set; } // bit
        public string ThongTinChuyenPhong { get; set; } // nvarchar(1000)
        public int? STTKham { get; set; } // int
        public Guid? TransferID { get; set; } // uniqueidentifier
        public bool? IsKhongDuocTiem { get; set; } // bit
        public bool? IsTrongGoi { get; set; } // bit
        public bool? HasNoNurse { get; set; } // bit
        public Guid? CreatedBy { get; set; } // uniqueidentifier
        public DateTime? CreatedOn { get; set; } // datetime
        public Guid? ModifiedBy { get; set; } // uniqueidentifier
        public DateTime? ModifiedOn { get; set; } // datetime
        public string IPUser { get; set; } // varchar(255)
        public string MacAddressUser { get; set; } // varchar(255)
        public int? DoiTuongThanhToanID { get; set; } // int
        public int? DoiTuongID { get; set; } // int
        public Guid? DocumentID { get; set; } // uniqueidentifier
        public string DoiTuongUuTien { get; set; } // nvarchar(250)
        public int? ProgramID { get; set; } // int
        public bool? IsPracticedNurse { get; set; } // bit
        public DateTime? NursePracticedOn { get; set; } // datetime
        public bool? IsDieuTriNgoaiTru { get; set; } // bit
        public int? IDRange { get; set; } // int
        public Guid? ClinicalSessionID { get; set; } // uniqueidentifier
        public Guid? DischargeConditionID { get; set; } // uniqueidentifier
    }
}
