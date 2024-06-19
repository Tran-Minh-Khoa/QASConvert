using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorClassLibrary1.Models
{
    public class CN_VitalSign
    {
        public Guid VitalSignID { get; set; } // uniqueidentifier
        public string FacID { get; set; } // varchar(10)
        public Guid? ParentClinicalSessionID { get; set; } // uniqueidentifier
        public Guid? VisitAdmissionID { get; set; } // uniqueidentifier
        public Guid? PhysicianAdmissionID { get; set; } // uniqueidentifier
        public Guid? FacAdmissionID { get; set; } // uniqueidentifier
        public Guid? PatientID { get; set; } // uniqueidentifier
        public Guid? DocumentID { get; set; } // uniqueidentifier
        public int? Pulse { get; set; } // int
        public double? Temperature { get; set; } // decimal(18,3)
        public int? BloodPressureUpper { get; set; } // int
        public int? BloodPressureLower { get; set; } // int
        public string BloodPressure { get; set; } // varchar(7)
        public int? Breath { get; set; } // int
        public double? SpO2 { get; set; } // decimal(18,3)
        public double? VongMong { get; set; } // decimal(18,3)
        public double? VongEo { get; set; } // decimal(18,3)
        public bool? IsSelectedTemperatureIntoProgressNote { get; set; } // bit
        public int? Respiration { get; set; } // int
        public bool? IsSelectedRespirationIntoProgressNote { get; set; } // bit
        public bool? IsSelectedBloodPressureIntoProgressNote { get; set; } // bit
        public bool? IsSelectedPulseIntoProgressNote { get; set; } // bit
        public double? Height { get; set; } // decimal(18,3)
        public double? Weight { get; set; } // decimal(18,3)
        public double? BMI { get; set; } // decimal(18,3)
        public double? MoToanThan { get; set; } // decimal(5,1)
        public double? MoBung { get; set; } // decimal(5,1)
        public bool? AnUong { get; set; } // bit
        public bool? Bia { get; set; } // bit
        public bool? Ruou { get; set; } // bit
        public bool? ThuocLa { get; set; } // bit
        public bool? CoThai { get; set; } // bit
        public int? KinhNguyet { get; set; } // int
        public string GhiChu { get; set; } // nvarchar(max)
        public bool? IsLeftHand { get; set; } // bit
        public Guid? NguoiDo { get; set; } // uniqueidentifier
        public Guid? NguoiDanhMay { get; set; } // uniqueidentifier
        public DateTime? ThoiGianDo { get; set; } // datetime
        public string Pupil { get; set; } // nvarchar(500)
        public int? Glasgow { get; set; } // int
        public string NutritionalClassification { get; set; }
        public DateTime? VitalSignOn { get; set; } // datetime
        public Guid? VitalSignBy { get; set; } // uniqueidentifier
        public DateTime? CompletedOn { get; set; } // datetime
        public Guid? CompletedBy { get; set; } // uniqueidentifier
        public DateTime? CreatedOn { get; set; } // datetime
        public Guid? CreatedBy { get; set; } // uniqueidentifier
        public DateTime? ModifiedOn { get; set; } // datetime
        public Guid? ModifiedBy { get; set; } // uniqueidentifier
       
    }
}
