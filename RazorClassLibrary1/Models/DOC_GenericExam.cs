using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RazorClassLibrary1.Models
{
    public class DOC_GenericExam
    {
        public Guid DocumentID { get; set; } // uniqueidentifier
        public Guid? PatientID { get; set; } // uniqueidentifier
        public Guid? FacAdmissionID { get; set; } // uniqueidentifier
        public Guid? PhysicianAdmissionID { get; set; } // uniqueidentifier
        public Guid? VisitAdmissionID { get; set; } // uniqueidentifier
        public Guid? ParentClinicalSessionID { get; set; } // uniqueidentifier
        public string FacID { get; set; } // varchar(10)
        public string PatientHospitalID { get; set; } // nvarchar(50)
        public string FullName { get; set; } // nvarchar(100)
        public DateTime? DoB { get; set; } // datetime
        public string DoBName { get; set; } // nvarchar(50)
        public int? Age { get; set; } // int
        public bool? GenderID { get; set; } // bit
        public string GenderName { get; set; } // nvarchar(50)
        public int? RoomID { get; set; } // int
        public string RoomName { get; set; } // nvarchar(500)
        public string NationalIDNo { get; set; } // nvarchar(200)
        public string Address { get; set; } // nvarchar(500)
        public string Mobile { get; set; } // nvarchar(100)
        public DateTime? AdmitOn { get; set; } // datetime
        public string PresentComplaint { get; set; } // nvarchar(max)
        public string PathologicalProcess { get; set; } // nvarchar(max)
        public string PersonalHistory { get; set; } // nvarchar(max)
        public string FamilyHistory { get; set; } // nvarchar(max)
        public int? Pulse { get; set; } // int
        public double? Temperature { get; set; } // decimal(18,3)
        public int? BloodPressureUpper { get; set; } // int
        public int? BloodPressureLower { get; set; } // int
        public string BloodPressure { get; set; } // varchar(7)
        public int? Breath { get; set; } // int
        public double? SpO2 { get; set; } // decimal(18,3)
        public string Pupil { get; set; } // nvarchar(500)
        public int? Glasgow { get; set; } // int
        public double? Height { get; set; } // decimal(18,3)
        public double? Weight { get; set; } // decimal(18,3)
        public double? BMI { get; set; } // decimal(18,3)
        public string NutritionalClassification { get; set; } // nvarchar(100)
        public string ClinicalBody { get; set; } // nvarchar(max)
        public string ClinicalPart { get; set; } // nvarchar(max)
        public string SubClinical { get; set; } // nvarchar(max)
        public string AllergyHistory { get; set; } // nvarchar(500)
        public string ProductUsing { get; set; } // nvarchar(500)
        public string TreatmentOther { get; set; } // nvarchar(max)
        public string FinalDecision { get; set; } // nvarchar(3000)
        public string MedicalHistory { get; set; } // nvarchar(3000)
        public string SurgicalHistory { get; set; } // nvarchar(3000)
        public DateTime? DocumentDate { get; set; } // datetime
        public Guid? DoctorBy { get; set; } // uniqueidentifier
        public string DoctorName { get; set; } // nvarchar(500)
        public DateTime? CompletedOn { get; set; } // datetime
        public Guid? CompletedBy { get; set; } // uniqueidentifier
        public DateTime? CreatedOn { get; set; } // datetime
        public Guid? CreatedBy { get; set; } // uniqueidentifier
        public DateTime? ModifiedOn { get; set; } // datetime
        public Guid? ModifiedBy { get; set; } // uniqueidentifier
    }
}
