
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace RazorClassLibrary1.Models
{
    [Serializable]
    public class MDM_Patient : ISerializable
    {
        public Guid PatientID { get; set; } // uniqueidentifier
        public string FacID { get; set; } // varchar(10)
        public int? CheckSum_PatientHospitalID { get; set; } // int
        public string PatientHospitalID { get; set; } // nvarchar(50)
        public string MOHID { get; set; } // nvarchar(50)
        public string FullName { get; set; } // nvarchar(100)
        public string FullNameUnUnicode { get; set; } // varchar(100)
        public int GenderID { get; set; } // bit
        public string GenderName { get; set; } // nvarchar(50)
        public DateTime DoB { get; set; } // datetime
        public int? DobAccuracyCode { get; set; } // tinyint
        public string DoB_DD { get; set; } // varchar(50)
        public string DoB_MM { get; set; } // varchar(50)
        public string DoB_YYYY { get; set; } // varchar(50)
        public string NameRelation { get; set; } // nvarchar(150)
        public string TelRelation { get; set; } // nvarchar(50)
        public string ArmyLevel { get; set; } // nvarchar(150)
        public string ArmyPlace { get; set; } // nvarchar(250)
        public int? ArmyStatus { get; set; } // tinyint
        public string Ethnicity { get; set; } // nvarchar(50)
        public string MaritalStatus { get; set; } // nvarchar(50)
        public string Occupation { get; set; } // nvarchar(250)
        public string NationalIDNo { get; set; } // nvarchar(200)
        public string DiaChi { get; set; } // nvarchar(1000)
        public string Address { get; set; } // nvarchar(1000)
        public string Street { get; set; } // nvarchar(500)
        public string Country { get; set; } // nvarchar(50)
        public string ProvinceName { get; set; } // nvarchar(50)
        public string DistrictName { get; set; } // nvarchar(50)
        public string WardName { get; set; } // nvarchar(200)
        public string Address2 { get; set; } // nvarchar(1000)
        public string Street2 { get; set; } // nvarchar(500)
        public string Country2 { get; set; } // nvarchar(50)
        public string Province2 { get; set; } // nvarchar(50)
        public string District2 { get; set; } // nvarchar(50)
        public string Ward2 { get; set; } // nvarchar(50)
        public string HomePhone { get; set; } // nvarchar(100)
        public string MobilePhone { get; set; } // nvarchar(100)
        public string WorkPhone { get; set; } // nvarchar(100)
        public string Company { get; set; } // nvarchar(300)
        public string MaSoThue { get; set; } // varchar(50)
        public string SoTaiKhoan { get; set; } // varchar(50)
        public string CustomerCode { get; set; } // varchar(50)
        public string CustomerID { get; set; } // varchar(50)
        public bool? IsNameless { get; set; } // bit
        public Guid? CreatedBy { get; set; } // uniqueidentifier
        public DateTime? CreatedOn { get; set; } // datetime
        public Guid? ModifiedBy { get; set; } // uniqueidentifier
        public DateTime? ModifiedOn { get; set; } // datetime
        public bool? IsDuSinh { get; set; } // bit
        public string EventID { get; set; } // varchar(100)
        public string MaTiemChung { get; set; } // varchar(100)
        public string GhiChu { get; set; } // nvarchar(500)
        public int? CreatedItemAsInt { get; set; } // int
        public bool? IsTaoBNTuWeb { get; set; } // bit
        public string PatientPortalUsername { get; set; } // nvarchar(300)
        public string PatientPortalPassword { get; set; } // nvarchar(300)
        public int? MaNhaMang { get; set; } // int
        public string Note { get; set; } // nvarchar(500)
        public string ProvinceID { get; set; } // varchar(10)
        public string DistrictID { get; set; } // varchar(10)
        public string WardID { get; set; } // varchar(10)
        public string Email { get; set; } // nvarchar(200)
        public string GiayChungSinhN { get; set; } // nvarchar(100)
        public string NoiCongTac { get; set; } // nvarchar(200)
        public string CMND_Passport { get; set; } // nvarchar(50)
        public string SoNha { get; set; } // nvarchar(100)
        public string TuoiThaiKhiSinh { get; set; } // nvarchar(100)
        public bool? DaTuVong { get; set; } // bit
        public string LeadID { get; set; } // varchar(50)
        public int? Created_Year { get; set; } // int
        public bool? IsMerge { get; set; } // bit
        public string ThongTinVungDichTeID { get; set; } // varchar(10)
        public string ThongTinVungDichTeText { get; set; } // nvarchar(200)
        public bool IsDeleted { get; set; } // bit
        public DateTime? CMND_Passport_NgayCap { get; set; } // datetime
        public string CMND_Passport_NoiCap { get; set; } // nvarchar(100)
        public string OccupationName { get; set; } // nvarchar(500)
        public int EthnicityID { get; set; } // int
        public int NationalID { get; set; } // int
        public string CompanyAddress { get; set; } // nvarchar(500)
        public int? TuanMangThai { get; set; } // int
        public string PatientSignature { get; set; } // varchar(max)
        public int? PaperID { get; set; }
        public int SortOrder { get; set; }
        public string AgeFormatYMD { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue("PatientID", this.PatientID); // uniqueidentifier
            info.AddValue("FacID", this.FacID); // varchar(10)
            info.AddValue("CheckSum_PatientHospitalID", this.CheckSum_PatientHospitalID); // int
            info.AddValue("PatientHospitalID", this.PatientHospitalID); // nvarchar(50)
            info.AddValue("MOHID", this.MOHID); // nvarchar(50)
            info.AddValue("FullName", this.FullName); // nvarchar(100)
            info.AddValue("FullNameUnUnicode", this.FullNameUnUnicode); // varchar(100)
            info.AddValue("GenderID", this.GenderID); // bit
            info.AddValue("GenderName", this.GenderName); // nvarchar(50)
            info.AddValue("DoB", this.DoB); // datetime
            info.AddValue("DobAccuracyCode", this.DobAccuracyCode); // tinyint
            info.AddValue("DoB_DD", this.DoB_DD); // varchar(50)
            info.AddValue("DoB_MM", this.DoB_MM); // varchar(50)
            info.AddValue("DoB_YYYY", this.DoB_YYYY); // varchar(50)
            info.AddValue("NameRelation", this.NameRelation); // nvarchar(150)
            info.AddValue("TelRelation", this.TelRelation); // nvarchar(50)
            info.AddValue("ArmyLevel", this.ArmyLevel); // nvarchar(150)
            info.AddValue("ArmyPlace", this.ArmyPlace); // nvarchar(250)
            info.AddValue("ArmyStatus", this.ArmyStatus); // tinyint
            info.AddValue("Ethnicity", this.Ethnicity); // nvarchar(50)
            info.AddValue("MaritalStatus", this.MaritalStatus); // nvarchar(50)
            info.AddValue("Occupation", this.Occupation); // nvarchar(250)
            info.AddValue("NationalIDNo", this.NationalIDNo); // nvarchar(200)
            info.AddValue("DiaChi", this.DiaChi); // nvarchar(1000)
            info.AddValue("Address", this.Address); // nvarchar(1000)
            info.AddValue("Street", this.Street); // nvarchar(500)
            info.AddValue("Country", this.Country); // nvarchar(50)
            info.AddValue("ProvinceName", this.ProvinceName); // nvarchar(50)
            info.AddValue("DistrictName", this.DistrictName); // nvarchar(50)
            info.AddValue("WardName", this.WardName); // nvarchar(200)
            info.AddValue("Address2", this.Address2); // nvarchar(1000)
            info.AddValue("Street2", this.Street2); // nvarchar(500)
            info.AddValue("Country2", this.Country2); // nvarchar(50)
            info.AddValue("Province2", this.Province2); // nvarchar(50)
            info.AddValue("District2", this.District2); // nvarchar(50)
            info.AddValue("Ward2", this.Ward2); // nvarchar(50)
            info.AddValue("HomePhone", this.HomePhone); // nvarchar(100)
            info.AddValue("MobilePhone", this.MobilePhone); // nvarchar(100)
            info.AddValue("WorkPhone", this.WorkPhone); // nvarchar(100)
            info.AddValue("Company", this.Company); // nvarchar(300)
            info.AddValue("MaSoThue", this.MaSoThue); // varchar(50)
            info.AddValue("SoTaiKhoan", this.SoTaiKhoan); // varchar(50)
            info.AddValue("CustomerCode", this.CustomerCode); // varchar(50)
            info.AddValue("CustomerID", this.CustomerID); // varchar(50)
            info.AddValue("IsNameless", this.IsNameless); // bit
            info.AddValue("CreatedBy", this.CreatedBy); // uniqueidentifier
            info.AddValue("CreatedOn", this.CreatedOn); // datetime
            info.AddValue("ModifiedBy", this.ModifiedBy); // uniqueidentifier
            info.AddValue("ModifiedOn", this.ModifiedOn); // datetime
            info.AddValue("IsDuSinh", this.IsDuSinh); // bit
            info.AddValue("EventID", this.EventID); // varchar(100)
            info.AddValue("MaTiemChung", this.MaTiemChung); // varchar(100)
            info.AddValue("GhiChu", this.GhiChu); // nvarchar(500)
            info.AddValue("CreatedItemAsInt", this.CreatedItemAsInt); // int
            info.AddValue("IsTaoBNTuWeb", this.IsTaoBNTuWeb); // bit
            info.AddValue("PatientPortalUsername", this.PatientPortalUsername); // nvarchar(300)
            info.AddValue("PatientPortalPassword", this.PatientPortalPassword); // nvarchar(300)
            info.AddValue("MaNhaMang", this.MaNhaMang); // int
            info.AddValue("Note", this.Note); // nvarchar(500)
            info.AddValue("ProvinceID", this.ProvinceID); // varchar(10)
            info.AddValue("DistrictID", this.DistrictID); // varchar(10)
            info.AddValue("WardID", this.WardID); // varchar(10)
            info.AddValue("Email", this.Email); // nvarchar(200)
            info.AddValue("GiayChungSinhN", this.GiayChungSinhN); // nvarchar(100)
            info.AddValue("NoiCongTac", this.NoiCongTac); // nvarchar(200)
            info.AddValue("CMND_Passport", this.CMND_Passport); // nvarchar(50)
            info.AddValue("SoNha", this.SoNha); // nvarchar(100)
            info.AddValue("TuoiThaiKhiSinh", this.TuoiThaiKhiSinh); // nvarchar(100)
            info.AddValue("DaTuVong", this.DaTuVong); // bit
            info.AddValue("LeadID", this.LeadID); // varchar(50)
            info.AddValue("Created_Year", this.Created_Year); // int
            info.AddValue("IsMerge", this.IsMerge); // bit
            info.AddValue("ThongTinVungDichTeID", this.ThongTinVungDichTeID); // varchar(10)
            info.AddValue("ThongTinVungDichTeText", this.ThongTinVungDichTeText); // nvarchar(200)
            info.AddValue("IsDeleted", this.IsDeleted); // bit
            info.AddValue("CMND_Passport_NgayCap", this.CMND_Passport_NgayCap); // datetime
            info.AddValue("CMND_Passport_NoiCap", this.CMND_Passport_NoiCap); // nvarchar(100)
            info.AddValue("OccupationName", this.OccupationName); // nvarchar(500)
            info.AddValue("EthnicityID", this.EthnicityID); // int
            info.AddValue("NationalID", this.NationalID); // int
            info.AddValue("CompanyAddress", this.CompanyAddress); // nvarchar(500)
            info.AddValue("TuanMangThai", this.TuanMangThai); // int
            info.AddValue("PatientSignature", this.PatientSignature); // varchar(max)
            info.AddValue("PaperID", this.PaperID); // int
            info.AddValue("SortOrder", this.SortOrder); // int
            info.AddValue("AgeFormatYMD", this.AgeFormatYMD); // nvarchar(100)
        }
    }
}
