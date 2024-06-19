using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QA.Shared.Practice.DataModels;
using System.Data;
using System.Globalization;
using DevExpress.XtraSpellChecker.Parser;

using RazorClassLibrary1.Models;
using QABlazor;
namespace RazorClassLibrary1
{
    public class FUNCTION
    {
        public List<L_ICD> ToLICD(DataTable dt)
        {
            List<L_ICD> list = new List<L_ICD>();
            if (dt == null)
            {
                return list;
            }
            list = dt.AsEnumerable().Select(r => new L_ICD()
            {
                ICDID = r.Item("ICDID"),
                ICDName = r.Item("ICDName"),
                ICDYHCTID = r.Item("ICDYHCTID"),
                ICDYHCTName = r.Item("ICDYHCTName"),
                ICDDescription = r.Item("ICDDescription")
            }).ToList();
            return list;
        }


        public List<CN_Diagnosis> ToCNDiagnosis(DataTable dt)
        {
            List<CN_Diagnosis> list = new List<CN_Diagnosis>();
            if (dt == null)
            {
                return list;
            }
            list = dt.AsEnumerable().Select(r => new CN_Diagnosis()
            {
                ICDID = r.Item("ICDID"),
                ICDName = r.Item("ICDName"),
                ICDDescription = r.Item("ICDDescription"),
                ICDYHCTID = r.Item("ICDYHCT"),
                ICDYHCTName = r.Item("ICDYHCTName"),
                ICDYHCTDescription = r.Item("ICDYHCTDescription"),
                ICDNote = r.Item("ICDNote"),
                ICDYHCTNote = r.Item("ICDYHCTNote"),
                OrderIndex = ConvertSafe.ToInt32(r.Item("OrderIndex")),
                IsMain = ConvertSafe.ToBoolean(r.Item("IsMain")),
                IsRegimen = ConvertSafe.ToBoolean(r.Item("IsRegimen")),
                IsShowICDNote = ConvertSafe.ToBoolean(r.Item("IsShowICDNote"))
            }).ToList();
            return list;
        }


        public List<DocumentTypeSettings> ToDocumentTypeSettings(DataTable dt)
        {
            List<DocumentTypeSettings> list = new List<DocumentTypeSettings>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new DocumentTypeSettings()
            {
                SettingID = r.Item("SettingID"),
                DocumentTypeID = r.Item("DocumentTypeID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("DocumentTypeID")),
                SettingCategory = r.Item("SettingCategory"),
                SettingName = r.Item("SettingName"),
                Value = r.Item("Value")
            }).ToList();
            return list;
        }


        public List<DOC_GenericExam> ToDOCGenericExam(DataTable dt)
        {
            List<DOC_GenericExam> list = new List<DOC_GenericExam>();
            if (dt == null)
            {
                return list;
            }
            list = dt.AsEnumerable().Select(r => new DOC_GenericExam()
            {
                DocumentID = r.Item("DocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("DocumentID")),
                PatientID = r.Item("PatientID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("PatientID")),
                FacAdmissionID = r.Item("FacAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("FacAdmissionID")),
                PhysicianAdmissionID = r.Item("PhysicianAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("PhysicianAdmissionID")),
                VisitAdmissionID = r.Item("VisitAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("VisitAdmissionID")),
                ParentClinicalSessionID = r.Item("ParentClinicalSessionID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("ParentClinicalSessionID")),
                FacID = r.Item("FacID"),
                PatientHospitalID = r.Item("PatientHospitalID"),
                FullName = r.Item("FullName"),
                DoB = r.Item("DoB") + "" == "" ? (DateTime?)null : Convert.ToDateTime(r.Item("DoB") + "", CultureInfo.CurrentCulture),
                DoBName = r.Item("DoBName"),
                Age = r.Item("Age") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Age")),
                GenderID = r.Item("GenderID") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("GenderID")),
                GenderName = r.Item("GenderName"),
                NationalIDNo = r.Item("NationalIDNo"),
                Address = r.Item("Address"),
                Mobile = r.Item("Mobile"),
                AdmitOn = r.Item("AdmitOn") + "" == "" ? (DateTime?)null : Convert.ToDateTime(r.Item("AdmitOn") + "", CultureInfo.CurrentCulture),
                RoomID = r.Item("RoomID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("RoomID")),
                RoomName = r.Item("RoomName"),
                PresentComplaint = r.Item("PresentComplaint"),
                PathologicalProcess = r.Item("PathologicalProcess"),
                PersonalHistory = r.Item("PersonalHistory"),
                FamilyHistory = r.Item("FamilyHistory"),
                Pulse = r.Item("Pulse") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Pulse")),
                Temperature = r.Item("Temperature") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("Temperature") + "").Replace(",", ".")),
                BloodPressureUpper = r.Item("BloodPressureUpper") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("BloodPressureUpper")),
                BloodPressureLower = r.Item("BloodPressureLower") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("BloodPressureLower")),
                BloodPressure = r.Item("BloodPressure"),
                Breath = r.Item("Breath") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Breath")),
                SpO2 = r.Item("SpO2") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("SpO2") + "").Replace(",", ".")),
                Pupil = r.Item("Pupil"),
                Glasgow = r.Item("Glasgow") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Glasgow")),
                Height = r.Item("Height") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("Height") + "").Replace(",", ".")),
                Weight = r.Item("Weight") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("Weight") + "").Replace(",", ".")),
                BMI = r.Item("BMI") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("BMI") + "").Replace(",", ".")),
                NutritionalClassification = r.Item("NutritionalClassification"),
                ClinicalBody = r.Item("ClinicalBody"),
                ClinicalPart = r.Item("ClinicalPart"),
                SubClinical = r.Item("SubClinical"),
                AllergyHistory = r.Item("AllergyHistory"),
                ProductUsing = r.Item("ProductUsing"),
                MedicalHistory = r.Item("MedicalHistory"),
                SurgicalHistory = r.Item("SurgicalHistory"),
                TreatmentOther = r.Item("TreatmentOther"),
                FinalDecision = r.Item("FinalDecision"),
                DocumentDate = r.Item("DocumentDate") + "" == "" ? (DateTime?)null : Convert.ToDateTime(r.Item("DocumentDate") + "", CultureInfo.CurrentCulture),
                DoctorBy = r.Item("DoctorBy") + "" == "" ? (Guid?)null : new Guid(r.Item("DoctorBy")),
                DoctorName = r.Item("DoctorName"),
                CompletedOn = r.Item("CompletedOn") + "" == "" ? (DateTime?)null : Convert.ToDateTime(r.Item("CompletedOn") + "", CultureInfo.CurrentCulture),
                CompletedBy = r.Item("CompletedBy") + "" == "" ? (Guid?)null : new Guid(r.Item("CompletedBy"))
            }).ToList();
            return list;
        }




        public List<MDM_Patient> ToMDMPatient(DataTable dt)
        {
            List<MDM_Patient> list = new List<MDM_Patient>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new MDM_Patient()
            {
                PatientID = r.Item("PatientID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PatientID")),
                FacID = r.Item("FacID"),
                CheckSum_PatientHospitalID = ConvertSafe.ToInt32(r.Item("CheckSum_PatientHospitalID")),
                PatientHospitalID = r.Item("PatientHospitalID"),
                MOHID = r.Item("MOHID"),
                FullName = r.Item("FullName"),
                FullNameUnUnicode = r.Item("FullNameUnUnicode"),
                GenderID = ConvertSafe.ToInt32(r.Item("GenderID")),
                GenderName = r.Item("GenderName"),
                DoB = r.Item("DoB") + "" == "" ? DateTime.MinValue : DateTime.Parse(r.Item("DoB"), CultureInfo.CurrentCulture),
                DobAccuracyCode = ConvertSafe.ToInt32(r.Item("DobAccuracyCode")),
                DoB_DD = r.Item("DoB_DD"),
                DoB_MM = r.Item("DoB_MM"),
                DoB_YYYY = r.Item("DoB_YYYY"),
                NameRelation = r.Item("NameRelation"),
                TelRelation = r.Item("TelRelation"),
                ArmyLevel = r.Item("ArmyLevel"),
                ArmyPlace = r.Item("ArmyPlace"),
                ArmyStatus = ConvertSafe.ToInt32(r.Item("ArmyStatus")),
                Ethnicity = r.Item("Ethnicity"),
                MaritalStatus = r.Item("MaritalStatus"),
                Occupation = r.Item("Occupation"),
                NationalIDNo = r.Item("NationalIDNo"),
                DiaChi = r.Item("DiaChi"),
                Address = r.Item("Address"),
                Street = r.Item("Street"),
                Country = r.Item("Country"),
                ProvinceName = r.Item("Province"),
                DistrictName = r.Item("District"),
                WardName = r.Item("Ward"),
                Address2 = r.Item("Address2"),
                Street2 = r.Item("Street2"),
                Country2 = r.Item("Country2"),
                Province2 = r.Item("Province2"),
                District2 = r.Item("District2"),
                Ward2 = r.Item("Ward2"),
                HomePhone = r.Item("HomePhone"),
                MobilePhone = r.Item("Mobile"),
                WorkPhone = r.Item("WorkPhone"),
                Company = r.Item("Company"),
                MaSoThue = r.Item("MaSoThue"),
                SoTaiKhoan = r.Item("SoTaiKhoan"),
                CustomerCode = r.Item("CustomerCode"),
                CustomerID = r.Item("CustomerID"),
                IsNameless = ConvertSafe.ToBoolean(r.Item("IsVoDanh")),
                CreatedBy = r.Item("CreatedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("CreatedBy")),
                CreatedOn = r.Item("CreatedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("CreatedOn"), CultureInfo.CurrentCulture),
                ModifiedBy = r.Item("ModifiedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ModifiedBy")),
                ModifiedOn = r.Item("ModifiedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("ModifiedOn"), CultureInfo.CurrentCulture),
                IsDuSinh = ConvertSafe.ToBoolean(r.Item("IsDuSinh")),
                EventID = r.Item("EventID"),
                MaTiemChung = r.Item("MaTiemChung"),
                GhiChu = r.Item("GhiChu"),
                CreatedItemAsInt = ConvertSafe.ToInt32(r.Item("CreatedItemAsInt")),
                IsTaoBNTuWeb = ConvertSafe.ToBoolean(r.Item("IsTaoBNTuWeb")),
                PatientPortalUsername = r.Item("PatientPortalUsername"),
                PatientPortalPassword = r.Item("PatientPortalPassword"),
                MaNhaMang = ConvertSafe.ToInt32(r.Item("MaNhaMang")),
                Note = r.Item("Note"),
                ProvinceID = r.Item("ProvinceID"),
                DistrictID = r.Item("DistrictID"),
                WardID = r.Item("WardID"),
                Email = r.Item("Email"),
                GiayChungSinhN = r.Item("GiayChungSinhN"),
                NoiCongTac = r.Item("NoiCongTac"),
                CMND_Passport = r.Item("CMDN"),
                SoNha = r.Item("SoNha"),
                TuoiThaiKhiSinh = r.Item("TuoiThaiKhiSinh"),
                DaTuVong = ConvertSafe.ToBoolean(r.Item("DaTuVong")),
                LeadID = r.Item("LeadID"),
                Created_Year = ConvertSafe.ToInt32(r.Item("Created_Year")),
                IsMerge = ConvertSafe.ToBoolean(r.Item("IsMerge")),
                ThongTinVungDichTeID = r.Item("ThongTinVungDichTeID"),
                ThongTinVungDichTeText = r.Item("ThongTinVungDichTeText"),
                IsDeleted = ConvertSafe.ToBoolean(r.Item("IsDeleted")),
                CMND_Passport_NgayCap = r.Item("CMND_Passport_NgayCap") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("CMND_Passport_NgayCap"), CultureInfo.CurrentCulture),
                CMND_Passport_NoiCap = r.Item("CMND_Passport_NoiCap"),
                OccupationName = r.Item("OccupationName"),
                EthnicityID = ConvertSafe.ToInt32(r.Item("EthnicityID")),
                NationalID = ConvertSafe.ToInt32(r.Item("NationalID")),
                CompanyAddress = r.Item("CompanyAddress"),
                TuanMangThai = ConvertSafe.ToInt32(r.Item("TuanMangThai")),
                PatientSignature = r.Item("PatientSignature"),
                PaperID = ConvertSafe.ToInt32(r.Item("PaperID"))
            }).ToList();
            return list;
        }
        public List<CN_VitalSign> ToCN_VitalSign(DataTable dt)
        {
            List<CN_VitalSign> list = new List<CN_VitalSign>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_VitalSign()
            {
                VitalSignID = r.Item("VitalSignID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("VitalSignID")),
                FacID = r.Item("FacID"),
                ParentClinicalSessionID = r.Item("ParentClinicalSessionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ParentClinicalSessionID")),
                VisitAdmissionID = r.Item("VisitAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("VisitAdmissionID")),
                PhysicianAdmissionID = r.Item("PhysicianAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PhysicianAdmissionID")),
                FacAdmissionID = r.Item("FacAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("FacAdmissionID")),
                PatientID = r.Item("PatientID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PatientID")),
                DocumentID = r.Item("DocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("DocumentID")),
                Pulse = r.Item("Pulse") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Pulse")),
                Temperature = r.Item("Temperature") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("Temperature") + "").Replace(",", ".")),
                BloodPressureUpper = r.Item("BloodPressureUpper") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("BloodPressureUpper")),
                BloodPressureLower = r.Item("BloodPressureLower") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("BloodPressureLower")),
                BloodPressure = r.Item("BloodPressure"),
                Breath = r.Item("Breath") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Breath")),
                SpO2 = r.Item("SpO2") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("SpO2") + "").Replace(",", ".")),
                VongMong = r.Item("VongMong") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("VongMong") + "").Replace(",", ".")),
                VongEo = r.Item("VongEo") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("VongEo") + "").Replace(",", ".")),
                IsSelectedTemperatureIntoProgressNote = r.Item("IsSelectedTemperatureIntoProgressNote") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsSelectedTemperatureIntoProgressNote")),
                Respiration = r.Item("Respiration") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Respiration")),
                IsSelectedRespirationIntoProgressNote = r.Item("IsSelectedRespirationIntoProgressNote") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsSelectedRespirationIntoProgressNote")),
                IsSelectedBloodPressureIntoProgressNote = r.Item("IsSelectedBloodPressureIntoProgressNote") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsSelectedBloodPressureIntoProgressNote")),
                IsSelectedPulseIntoProgressNote = r.Item("IsSelectedPulseIntoProgressNote") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsSelectedPulseIntoProgressNote")),
                Height = r.Item("Height") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("Height") + "").Replace(",", ".")),
                Weight = r.Item("Weight") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("Weight") + "").Replace(",", ".")),
                BMI = r.Item("BMI") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("BMI") + "").Replace(",", ".")),
                MoToanThan = r.Item("MoToanThan") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("MoToanThan") + "").Replace(",", ".")),
                MoBung = r.Item("MoBung") + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((r.Item("MoBung") + "").Replace(",", ".")),
                AnUong = r.Item("AnUong") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("AnUong")),
                Bia = r.Item("Bia") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("Bia")),
                Ruou = r.Item("Ruou") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("Ruou")),
                ThuocLa = r.Item("ThuocLa") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("ThuocLa")),
                CoThai = r.Item("CoThai") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("CoThai")),
                KinhNguyet = r.Item("KinhNguyet") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("KinhNguyet")),
                GhiChu = r.Item("GhiChu"),
                IsLeftHand = r.Item("IsLeftHand") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsLeftHand")),
                NguoiDo = r.Item("NguoiDo") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("NguoiDo")),
                NguoiDanhMay = r.Item("NguoiDanhMay") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("NguoiDanhMay")),
                ThoiGianDo = r.Item("ThoiGianDo") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("ThoiGianDo"), CultureInfo.CurrentCulture),
                Pupil = r.Item("Pupil"),
                Glasgow = r.Item("Glasgow") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("Glasgow")),
                NutritionalClassification = r.Item("NutritionalClassification"),
                VitalSignOn = r.Item("VitalSignOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("VitalSignOn"), CultureInfo.CurrentCulture),
                VitalSignBy = r.Item("VitalSignBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("VitalSignBy")),
                CompletedOn = r.Item("CompletedOn") + "" == "" ? (DateTime?)null : Convert.ToDateTime(r.Item("CompletedOn") + "", CultureInfo.CurrentCulture),
                CompletedBy = r.Item("CompletedBy") + "" == "" ? (Guid?)null : new Guid(r.Item("CompletedBy")),
                CreatedOn = r.Item("CreatedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("CreatedOn"), CultureInfo.CurrentCulture),
                CreatedBy = r.Item("CreatedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("CreatedBy")),
                ModifiedOn = r.Item("ModifiedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("ModifiedOn"), CultureInfo.CurrentCulture),
                ModifiedBy = r.Item("ModifiedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ModifiedBy"))
            }).ToList();
            return list;
        }

        public List<CN_PhysicianAdmissions> ToCN_PhysicianAdmissions(DataTable dt)
        {
            List<CN_PhysicianAdmissions> list = new List<CN_PhysicianAdmissions>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_PhysicianAdmissions()
            {
                PhysicianAdmissionID = r.Item("PhysicianAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PhysicianAdmissionID")),
                FacID = r.Item("FacID"),
                FacAdmissionID = r.Item("FacAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("FacAdmissionID")),
                PatientID = r.Item("PatientID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PatientID")),
                PrimaryDoctor = r.Item("PrimaryDoctor") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PrimaryDoctor")),
                DeptID = r.Item("DeptID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("DeptID")),
                RoomID = r.Item("RoomID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("RoomID")),
                RoomName = r.Item("RoomName"),
                BedID = r.Item("BedID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("BedID")),
                AdmitBy = r.Item("AdmitBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("AdmitBy")),
                AdmitOn = r.Item("AdmitOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("AdmitOn"), CultureInfo.CurrentCulture),
                DischargedBy = r.Item("DischargedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("DischargedBy")),
                DischargedOn = r.Item("DischargedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("DischargedOn"), CultureInfo.CurrentCulture),
                AdmitDate = r.Item("AdmitDate"),
                DischargedDate = r.Item("DischargedDate"),
                AdmitDateAsInt = r.Item("AdmitDateAsInt") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("AdmitDateAsInt")),
                DischargedDateAsInt = r.Item("DischargedDateAsInt") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("DischargedDateAsInt")),
                IsPracticed = r.Item("IsPracticed") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsPracticed")),
                TGBatDauKham = r.Item("TGBatDauKham") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("TGBatDauKham"), CultureInfo.CurrentCulture),
                IsKhongKham = r.Item("IsKhongKham") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsKhongKham")),
                SpecialistID = r.Item("SpecialistID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("SpecialistID")),
                NurseEmpID = r.Item("NurseEmpID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("NurseEmpID")),
                IsPriority = r.Item("IsPriority") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsPriority")),
                IsTrucTiep = r.Item("IsTrucTiep") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsTrucTiep")),
                ThongTinChuyenPhong = r.Item("ThongTinChuyenPhong"),
                STTKham = r.Item("STTKham") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("STTKham")),
                TransferID = r.Item("TransferID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("TransferID")),
                IsKhongDuocTiem = r.Item("IsKhongDuocTiem") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsKhongDuocTiem")),
                IsTrongGoi = r.Item("IsTrongGoi") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsTrongGoi")),
                HasNoNurse = r.Item("HasNoNurse") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("HasNoNurse")),
                CreatedBy = r.Item("CreatedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("CreatedBy")),
                CreatedOn = r.Item("CreatedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("CreatedOn"), CultureInfo.CurrentCulture),
                ModifiedBy = r.Item("ModifiedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ModifiedBy")),
                ModifiedOn = r.Item("ModifiedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("ModifiedOn"), CultureInfo.CurrentCulture),
                IPUser = r.Item("IPUser"),
                MacAddressUser = r.Item("MacAddressUser"),
                DoiTuongThanhToanID = r.Item("DoiTuongThanhToanID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("DoiTuongThanhToanID")),
                DoiTuongID = r.Item("DoiTuongID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("DoiTuongID")),
                DocumentID = r.Item("DocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("DocumentID")),
                DoiTuongUuTien = r.Item("DoiTuongUuTien"),
                ProgramID = r.Item("ProgramID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("ProgramID")),
                IsPracticedNurse = r.Item("IsPracticedNurse") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsPracticedNurse")),
                NursePracticedOn = r.Item("NursePracticedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("NursePracticedOn"), CultureInfo.CurrentCulture),
                IsDieuTriNgoaiTru = r.Item("IsDieuTriNgoaiTru") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsDieuTriNgoaiTru")),
                IDRange = r.Item("IDRange") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("IDRange")),
                ClinicalSessionID = r.Item("ClinicalSessionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ClinicalSessionID")),
                DischargeConditionID = r.Item("DischargeConditionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("DischargeConditionID"))

            }).ToList();
            return list;
        }

        public List<CN_PersonalHistory> ToPersonalHistoryV2(DataTable dt)
        {
            List<CN_PersonalHistory> list = new List<CN_PersonalHistory>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_PersonalHistory()
            {
                SummaryLong = r.Item("PersonalHistory")
            }).ToList();
            return list;
        }
        public List<CN_FamilyHistory> ToFamilyHistory(DataTable dt)
        {
            List<CN_FamilyHistory> list = new List<CN_FamilyHistory>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_FamilyHistory()
            {
                SummaryLong = r.Item("FamilyHistory")
            }).ToList();
            return list;
        }
        public List<CN_AllergyHistory> ToAllergy(DataTable dt)
        {
            List<CN_AllergyHistory> list = new List<CN_AllergyHistory>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_AllergyHistory()
            {
                SummaryLong = r.Item("Allergy")
            }).ToList();
            return list;
        }
        public List<CN_HistoryDiseasePersonal> ToDiseaseHistory(DataTable dt)
        {
            List<CN_HistoryDiseasePersonal> list = new List<CN_HistoryDiseasePersonal>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_HistoryDiseasePersonal()
            {
                DiseaseID = string.IsNullOrEmpty(r.Item("DiseaseID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("DiseaseID")),
                DiseaseName = r.Item("DiseaseName"),
                SpecialistID = string.IsNullOrEmpty(r.Item("SpecialistID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("SpecialistID")),
                SpecialistName = r.Item("SpecialistName")

            }).ToList();
            return list;
        }
        public List<CN_ProductHistory> ToProductUsing(DataTable dt)
        {
            List<CN_ProductHistory> list = new List<CN_ProductHistory>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_ProductHistory()
            {
                ProductID = string.IsNullOrEmpty(r.Item("ProductID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("ProductID")),
                ProductName_TT52 = r.Item("ProductName_TT52")
            }).ToList();
            return list;
        }
        public List<CN_DoctorDecision> ToFinalDecision(DataTable dt)
        {
            List<CN_DoctorDecision> list = new List<CN_DoctorDecision>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_DoctorDecision()
            {
                PhysicianAdmissionID = r.Item("PhysicianAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PhysicianAdmissionID")),
                DocumentID = r.Item("DocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("DocumentID")),
                PatientID = r.Item("PatientID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("PatientID")),
                FacAdmissionID = r.Item("FacAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("FacAdmissionID")),
                FacID = r.Item("FacID"),
                FinalDecisionID = string.IsNullOrEmpty(r.Item("FinalDecisionID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("FinalDecisionID")),
                TomTatBenhAn = r.Item("TomTatBenhAn"),
                DeNghiKhamChuyenKhoa = r.Item("DeNghiKhamChuyenKhoa"),
                HospitalCode = string.IsNullOrEmpty(r.Item("HospitalCode").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("HospitalCode")),
                DepartmentID = string.IsNullOrEmpty(r.Item("DepartmentID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("DepartmentID")),
                RoomID = string.IsNullOrEmpty(r.Item("RoomID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("RoomID")),
                PatientOutcomeID = string.IsNullOrEmpty(r.Item("PatientOutcomeID").ToString()) ? 0 : ConvertSafe.ToInt32(r.Item("PatientOutcomeID")),
                CompletedOn = r.Item("CompletedOn") + "" == "" ? (DateTime?)null : Convert.ToDateTime(r.Item("CompletedOn") + "", CultureInfo.CurrentCulture),
                CompletedBy = r.Item("CompletedBy") + "" == "" ? (Guid?)null : new Guid(r.Item("CompletedBy")),
                CreatedOn = r.Item("CreatedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("CreatedOn"), CultureInfo.CurrentCulture),
                CreatedBy = r.Item("CreatedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("CreatedBy")),
                ModifiedOn = r.Item("ModifiedOn") + "" == "" ? (DateTime?)null : DateTime.Parse(r.Item("ModifiedOn"), CultureInfo.CurrentCulture),
                ModifiedBy = r.Item("ModifiedBy") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ModifiedBy")),
                Reason = r.Item("Reason"),
                Description = r.Item("Description")
            }).ToList();
            return list;
        }
        public List<CN_FinalDecision> ToDecision(DataTable dt)
        {
            List<CN_FinalDecision> list = new List<CN_FinalDecision>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new CN_FinalDecision()
            {
                IsSelected = r.Item("IsSelected") + "" == "" ? (bool?)null : ConvertSafe.ToBoolean(r.Item("IsSelected")),
                DocumentID = r.Item("DocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("DocumentID")),
                PatientID = r.Item("PatientID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("PatientID")),
                FacAdmissionID = r.Item("FacAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("FacAdmissionID")),
                PhysicianAdmissionID = r.Item("PhysicianAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("PhysicianAdmissionID")),
                VisitAdmissionID = r.Item("VisitAdmissionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("VisitAdmissionID")),
                ClinicalSessionID = r.Item("ClinicalSessionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ClinicalSessionID")),
                ParentClinicalSessionID = r.Item("ParentClinicalSessionID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ParentClinicalSessionID")),
                ParentDocumentID = r.Item("ParentDocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("ParentDocumentID")),
                LinkToDocumentID = r.Item("LinkToDocumentID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("LinkToDocumentID")),
                FinalDecisionID = r.Item("FinalDecisionID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("FinalDecisionID")),
                FinalDecisionName = r.Item("FinalDecisionName"),
                DocumentTypeID = r.Item("DocumentTypeID") + "" == "" ? new Guid(QAFunction.DefaultGuid()) : new Guid(r.Item("DocumentTypeID")),
                DocumentName = r.Item("DocumentName"),
                EditorType = r.Item("EditorType"),
                SortOrder = r.Item("SortOrder") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("SortOrder"))

            }).ToList();
            return list;
        }
        public List<MDM_Employee> ToEmployee(DataTable dt)
        {
            List<MDM_Employee> list = new List<MDM_Employee>();
            if (dt == null)
            {
                return list;
            }

            list = dt.AsEnumerable().Select(r => new MDM_Employee()
            {
                FacID = r.Item("FacID"),
                EmployeeID = r.Item("EmployeeID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("EmployeeID")),
                EmployeeCode = r.Item("EmployeeCode"),
                PositionID = r.Item("PositionID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("PositionID")),
                PositionCode = r.Item("PositionCode"),
                PositionName = r.Item("PositionName"),
                TechniqueID = r.Item("TechniqueID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("TechniqueID")),
                TechniqueCode = r.Item("TechniqueCode"),
                TechniqueName = r.Item("TechniqueName"),
                UserID = r.Item("UserID") + "" == "" ? new Guid(QAFunction.DefaultGuid() + "") : new Guid(r.Item("UserID")),
                UserName = r.Item("UserName"),
                FullName = r.Item("FullName"),
                FullNameWithTechniqueCode = r.Item("FullNameWithTechniqueCode"),
                FullNameWithPositionCode = r.Item("FullNameWithPositionCode"),
                EmpDepartmentID = r.Item("EmpDepartmentID") + "" == "" ? (int?)null : ConvertSafe.ToInt32(r.Item("EmpDepartmentID")),
                EmpDepartmentName = r.Item("EmpDepartmentName"),
                Email = r.Item("Email")
            }).ToList();
            return list;
        }
        public int? GetBloodPressureUpper(string bloodPressure)
        {
            int? bloodPressureUpper = null;
            var arrbloodPressure = (bloodPressure +"").Split('/');
            switch (arrbloodPressure.Length)
            {
                case 1:
                    bloodPressureUpper = ConvertSafe.ToInt32(arrbloodPressure[0]);
                    break;
                case 2:
                    bloodPressureUpper = ConvertSafe.ToInt32(arrbloodPressure[0]);
                    break;
            }

            return bloodPressureUpper;
        }


        public int? GetBloodPressureLower(string bloodPressure)
        {
            int? bloodPressureLower = null;
            var arrbloodPressure = (bloodPressure+"").Split('/');
            switch (arrbloodPressure.Length)
            {
                case 1:
                    break;
                case 2:
                    bloodPressureLower = ConvertSafe.ToInt32(arrbloodPressure[1]);
                    break;
            }

            return bloodPressureLower;
        }

        // 23-05-2024: Này làm đỡ nha, sau này có thời gian sẽ phải sửa lại hàm chung
        public string GetNutritionalClassification(string height, string weight)
        {
            double? bmi = null;
            double dWeight, dHeight;
            if (double.TryParse((weight + "").Trim().Replace(".", ","), out dWeight) && double.TryParse((height + "").Trim().Replace(".", ","), out dHeight))
            {
                dHeight = dHeight / 100;
                if (dHeight != 0)
                {
                    bmi = Math.Round((dWeight / (dHeight * dHeight)), 2);
                }
            }
            if (bmi == null)
            {
                return "";
            }
            if (bmi < 18.5)//Ttrường hợp gầy
            {
                return "Gầy";
            }
            if (bmi < 25)//Trường hợp bình thường
            {
                return "Bình thường";
            }
            if (bmi < 30)//Trường hợp hơi béo
            {
                return "Hơi béo";
            }
            if (bmi < 35)//Trường hợp béo phì 1
            {
                return "Béo phì 1";
            }
            if (bmi < 40)//Trường hợp béo phì 2
            {
                return "Béo phì 2";
            }
            //Trường hợp béo phì 3

            return "Béo phì 3";
        }
    }
}
