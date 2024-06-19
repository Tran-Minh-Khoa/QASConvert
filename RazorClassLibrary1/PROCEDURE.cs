using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QA.Shared.Practice.DataModels;
using System.Data;
using DevExpress.XtraEditors.Filtering;
using QABlazor;
namespace RazorClassLibrary1
{
    public class PROCEDURE
    {
        string DATABASE = "QADocGenericExamDB";
        public RequestCollection ws_DOC_GenericExam_Get(string facID, string patientID, string documentID)
        {
            return DataQuery.Create("Docs", "ws_DOC_GenericExam_Get", new
            {
                FacID = facID,
                PatientID = patientID,
                DocumentID = documentID
            });/*Tables[0]: Thông tin DOC*/
        }


        /*Danh sách chẩn đoán theo DocumentID*/
        public RequestCollection ws_CN_Diagnosis_ByDocument_List(string facID, string patientID, string documentID)
        {
            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            documentID = documentID + "" == "" ? QAFunction.DefaultGuid() + "" : documentID;
            return DataQuery.Create("Docs", "ws_CN_Diagnosis_ByDocument_List", new
            {
                FacID = facID,
                //PatientID=patientID,
                DocumentID = documentID
            });

        }


        /*Danh sách xử trí theo DocumentType của PhysicianAdmission*/
        public RequestCollection ws_CN_DoctorDecision_ForDocumentTypeWithDocumentServiceFolder_List(string facID, string clinicalSessionID, string documentTypeID)
        {
            clinicalSessionID = clinicalSessionID + "" == "" ? QAFunction.DefaultGuid() + "" : clinicalSessionID;
            documentTypeID = documentTypeID + "" == "" ? QAFunction.DefaultGuid() + "" : documentTypeID;
            return DataQuery.Create("QAHosGenericDB", "ws_CN_DoctorDecision_ForDocumentTypeWithDocumentServiceFolder_List", new
            {
                FacID = facID,
                ClinicalSessionID = clinicalSessionID,
                DocumentTypeID = documentTypeID
            });
        }

        /*Lấy thông tin bệnh nhân trong bảng MDM_Patient*/
        public RequestCollection ws_MDM_Patient_Default_Get(string patientID)
        {
            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            return DataQuery.Create(/*this.DATABASE*/ "QAHosGenericDB", "ws_MDM_Patient_Default_Get", new
            {
                //FacID = facID,
                PatientID = patientID
            });
        }

        /*Thông tin sinh hiệu đo lần cuối cùng của bệnh nhân => lấy từng chỉ số cuối cùng có tồn tại*/
        public RequestCollection ws_CN_VitalSign_FinalExistsOfPatient_Get(string facID, string patientID)
        {

            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            //return DataAccess.DataQuery.Create(this.DATABASE, "ws_CN_VitalSign_FinalExistsOfPatient_Get", new
            //{
            //    FacID = facID,
            //    PatientID = patientID
            //});
            return DataQuery.Create("QAHosGenericDB", "ws_CN_VitalSign_FinalByPatient_Get", new
            {
                FacID = facID,
                PatientID = patientID
            });
        }

        /*Danh sách nhân viên có tài khoản theo chức danh*/
        public RequestCollection ws_MDM_Employee_HaveUserByPositionName_List(string facID, string positionNames)
        {
            return DataQuery.Create("HR", "ws_MDM_Employee_HaveUserByPositionName_List", new
            {
                FacID = facID,
                PositionNames = positionNames
            });
        }

        /*Thông tin PhysicianAdmissions*/
        public RequestCollection ws_CN_PhysicianAdmissions_Get(string facID, string physicianAdmissionID)
        {
            physicianAdmissionID = physicianAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : physicianAdmissionID;
            return DataQuery.Create(/*this.DATABASE*/ "QAHosGenericDB", "ws_CN_PhysicianAdmissions_GetByPhysicianAdmissionID", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID
            });
        }

        /*Summary Tiền sử bệnh bản thân của bệnh nhân - Trừ dị ứng, nội-ngoại tổng hợp, thuốc*/
        public RequestCollection ws_PersonalHistoryV2_SummaryLongByPatient_Get(string facID, string patientID)
        {

            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            return DataQuery.Create("QAHosGenericDB", "ws_PersonalHistoryV2_SummaryLongByPatient_Get", new
            {
                FacID = facID,
                PatientID = patientID
            });

        }

        /*Summary Tiền sử bệnh gia đình của bệnh nhân*/
        public RequestCollection ws_FamilyHistory_SummaryLongByPatient_Get(string facID, string patientID)
        {

            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            return DataQuery.Create("QAHosGenericDB", "ws_FamilyHistory_SummaryLongByPatient_Get", new
            {
                FacID = facID,
                PatientID = patientID
            });

        }


        /*Danh sách xử trí theo  PhysicianAdmission*/
        public RequestCollection ws_CN_DoctorDecision_ByPhysicianAdmission_List(string facID, string physicianAdmissionID)
        {
            physicianAdmissionID = physicianAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : physicianAdmissionID;
            return DataQuery.Create("QAHosGenericDB", "ws_CN_DoctorDecision_ByPhysicianAdmission_List", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID
            });

        }


        /*Danh sách Tiền sử dị ứng của bệnh nhân*/
        public RequestCollection ws_Allergy_Get(string facID, string patientID)
        {

            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            return DataQuery.Create("QAHosGenericDB", "ws_Allergy_Get", new
            {
                FacID = facID,
                PatientID = patientID
            });

        }

        /*Summary Tiền sử nội-ngoại tổng hợp của bệnh nhân*/
        public RequestCollection ws_CN_HistoryDiseasePersonal_List(string facID, string patientID)
        {
            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            return DataQuery.Create(/*this.DATABASE*/ "QAHosGenericDB", "ws_CN_HistoryDiseasePersonal_List", new
            {
                FacID = facID,
                PatientID = patientID
            });
        }

        /*Danh sách thuốc đang dùng của bệnh nhân*/
        public RequestCollection ws_Patient_HX_Medical_List(string facID, string patientID)
        {
            patientID = patientID + "" == "" ? QAFunction.DefaultGuid() + "" : patientID;
            return DataQuery.Create(/*this.DATABASE*/ "QAHosGenericDB", "ws_Patient_HX_Medical_List", new
            {
                FacID = facID,
                PatientID = patientID
            });

        }

        public RequestCollection ws_L_ICDWithICDYHCT_List()
        {
            return DataQuery.Create("QAHosGenericDB", "ws_L_ICDWithICDYHCT_List", new
            {
            }); /*LastTables(): Danh sách ICD*/
        }


        public RequestCollection ws_L_ICD_Active_List()
        {
            return DataQuery.Create("QAHosGenericDB", "ws_L_ICD_Active_List", new
            {
            }); /*LastTables(): Danh sách ICD*/
        }



        public RequestCollection ws_CN_Diagnosis_Saves(List<CN_Diagnosis> list, string documentID, string parentDocumentID, string patientID,
                                                                  string facAdmissionID, string physicianAdmissionID, string visitAdmissionID, string facID,
                                                                  DateTime diagnosedOn, string diagnosedBy, string fromMenu, string fromControl,
                                                                  string fromPC, string fromMAC, string note)
        {
            note = note + " -> " + "DataAccess.RequestCollection qSaveDiagnosis(DataTable dt,string documentID, string parentDocumentID, string patientID, string facAdmissionID, string physicianAdmissionID, string visitAdmissionID, string facID, DateTime diagnosedOn, string diagnosedBy, string fromMenu, string fromControl, string fromPC, string fromMAC, string note)";
            var query = new RequestCollection();
            if (list == null)
            {
                return query;
            }
            //DataTable dtDiagnosis = new DataTable();
            //dtDiagnosis.Columns.Add("DocumentID", typeof(Guid));
            //dtDiagnosis.Columns.Add("ICDID", typeof(string));
            //dtDiagnosis.Columns.Add("BodyPartID", typeof(int));
            //dtDiagnosis.Columns.Add("ParentDocumentID", typeof(Guid));
            //dtDiagnosis.Columns.Add("PatientID", typeof(Guid));
            //dtDiagnosis.Columns.Add("FacAdmissionID", typeof(Guid));
            //dtDiagnosis.Columns.Add("PhysicianAdmissionID", typeof(Guid));
            //dtDiagnosis.Columns.Add("VisitAdmissionID", typeof(Guid));
            //dtDiagnosis.Columns.Add("FacID", typeof(string));
            //dtDiagnosis.Columns.Add("ICDName", typeof(string));
            //dtDiagnosis.Columns.Add("ICDDescription", typeof(string));
            //dtDiagnosis.Columns.Add("ICDYHCTID", typeof(string));
            //dtDiagnosis.Columns.Add("ICDYHCTName", typeof(string));
            //dtDiagnosis.Columns.Add("ICDYHCTDescription", typeof(string));
            //dtDiagnosis.Columns.Add("BodyPartName", typeof(string));
            //dtDiagnosis.Columns.Add("BodyPartGroupID", typeof(int));
            //dtDiagnosis.Columns.Add("BodyPartGroupName", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10ID", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10DoctorName", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10IDChinhMatTrai", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10MatTrai", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10IDChinhMatPhai", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10MatPhai", typeof(string));
            //dtDiagnosis.Columns.Add("IsTraiPhai", typeof(bool));

            //dtDiagnosis.Columns.Add("ICDPhuText", typeof(string));
            //dtDiagnosis.Columns.Add("ICDYHCT", typeof(string));
            //dtDiagnosis.Columns.Add("ICDNameYHCT", typeof(string));
            //dtDiagnosis.Columns.Add("ICD10Name", typeof(string));
            //dtDiagnosis.Columns.Add("IsMain", typeof(bool));
            //dtDiagnosis.Columns.Add("IsRegimens", typeof(bool));
            //dtDiagnosis.Columns.Add("IsShowICDNote", typeof(bool));
            //dtDiagnosis.Columns.Add("OrderIndex", typeof(int));
            //dtDiagnosis.Columns.Add("DiagnosedOn", typeof(DateTime));
            //dtDiagnosis.Columns.Add("DiagnosedBy", typeof(Guid));
            //dtDiagnosis.Columns.Add("Note", typeof(string));

            ////DataTable dtDiagnosisNote = new DataTable();
            ////dtDiagnosisNote.Columns.Add("DocumentID", typeof(Guid));
            ////dtDiagnosisNote.Columns.Add("ICDID", typeof(string));
            ////dtDiagnosisNote.Columns.Add("BodyPartID", typeof(int));
            //dtDiagnosis.Columns.Add("ICDNote", typeof(string));
            string DocumentIDs = "";
            string ICDIDs = "";
            string BodyPartIDs = "";
            string ParentDocumentIDs = "";
            string PatientIDs = "";
            string FacAdmissionIDs = "";
            string PhysicianAdmissionIDs = "";
            string VisitAdmissionIDs = "";
            string FacIDs = "";
            string ICDNames = "";
            string ICDDescriptions = "";
            string ICDYHCTs = "";
            string ICDNameYHCTs = "";
            string ICDYHCTNames = "";
            string ICDYHCTDescriptions = "";
            string BodyPartNames = "";
            string BodyPartGroupIDs = "";
            string BodyPartGroupNames = "";
            string ICD10IDs = "";
            string ICD10s = "";
            string ICD10DoctorNames = "";
            string ICD10Names = "";
            string ICD10IDChinhMatTrais = "";
            string ICD10IDChinhMatPhais = "";
            string IsMains = "";
            string IsShowICDNotes = "";
            string IsRegimens = "";
            string IsRegimenss = "";
            string OrderIndexs = "";
            string DiagnosedOns = "";
            string DiagnosedBys = "";
            string ICDNotes = "";
            string ICDYHCTNotes = "";
            string Notes = "";
            string FromMenus = "";
            string FromControls = "";
            string FromPCs = "";
            string FromMACs = "";
            if (list.Count == 0)
            {
                DocumentIDs += documentID + "|";
                ICDIDs += "|";
                BodyPartIDs += "|";
                ParentDocumentIDs += parentDocumentID + "|";
                PatientIDs += patientID + "|";
                FacAdmissionIDs += facAdmissionID + "|";
                PhysicianAdmissionIDs += physicianAdmissionID + "|";
                VisitAdmissionIDs += visitAdmissionID + "|";
                FacIDs += facID + "|";
                ICDNames += "|";
                ICDDescriptions += "|";
                ICDYHCTs += "|";
                ICDNameYHCTs += "|";
                ICDYHCTNames += "|";
                ICDYHCTDescriptions += "|";
                BodyPartNames += "|";
                ICD10IDs += "|";
                ICD10s += "|";
                ICD10DoctorNames += "|";
                ICD10Names += "|";
                ICD10IDChinhMatTrais += "|";
                ICD10IDChinhMatPhais += "|";
                IsMains += "|";
                IsShowICDNotes += "|";
                IsRegimens += "False|";
                ICDNotes += "|";
                ICDYHCTNotes += "|";
                IsRegimenss += "|";
                OrderIndexs += "|";
                DiagnosedOns += (diagnosedOn == DateTime.MinValue || diagnosedOn == DateTime.MaxValue || diagnosedOn == null) ? null : diagnosedOn.ToString("yyyy-MM-dd HH:mm:ss") + "|";
                if (diagnosedBy + "" != "")
                {
                    DiagnosedBys += diagnosedBy + "|";
                }

                Notes += "lưu ICD-> QAHosGenericDB..ws_CN_Diagnosis_Saves|";
                FromMenus += fromMenu + "|";
                FromControls += fromControl + "|";
                FromPCs += fromPC + "|";
                FromMACs += fromMAC + "|";
            }
            else
            {
                foreach (CN_Diagnosis row in list)
                {
                    if (row == null)
                    {
                        continue;
                    }
                    //var rowNew = dtDiagnosis.NewRow();
                    //rowNew["DocumentID"] = documentID;
                    //rowNew["ICDID"] = row.ICDID;
                    //rowNew["BodyPartID"] = 0;
                    //rowNew["ParentDocumentID"] = parentDocumentID;
                    //rowNew["PatientID"] = patientID;
                    //rowNew["FacAdmissionID"] = facAdmissionID;
                    //rowNew["PhysicianAdmissionID"] = physicianAdmissionID;
                    //rowNew["VisitAdmissionID"] = visitAdmissionID;
                    //rowNew["FacID"] = facID;
                    //rowNew["ICDName"] = row.ICDName;
                    //rowNew["ICDDescription"] = row.ICDDescription;
                    //rowNew["ICDYHCTID"] = row.ICDYHCTID;
                    //rowNew["ICDYHCTName"] = row.ICDYHCTName;
                    //rowNew["ICDYHCTDescription"] = row.ICDYHCTDescription;
                    //rowNew["ICD10ID"] = row.ICDID;
                    //rowNew["ICD10"] = row.ICDDescription;
                    //rowNew["ICD10DoctorName"] = row.ICDDescription;
                    //rowNew["ICD10IDChinhMatTrai"] = "";
                    //rowNew["ICD10IDChinhMatPhai"] = "";
                    //rowNew["IsMain"] = row.IsMain;
                    //rowNew["IsShowICDNote"] = row.IsShowICDNote;
                    //rowNew["IsRegimens"] = row.IsRegimen;
                    //rowNew["OrderIndex"] = row.OrderIndex;
                    //rowNew["DiagnosedOn"] = diagnosedOn;
                    //rowNew["IsShowICDNote"] = row.IsShowICDNote;
                    //rowNew["ICDNote"] = row.ICDNote;
                    //if (diagnosedBy + "" != "")
                    //{
                    //    rowNew["DiagnosedBy"] = diagnosedBy;
                    //}
                    //rowNew["Note"] = "lưu ICD";
                    //dtDiagnosis.Rows.Add(rowNew);
                    DocumentIDs += documentID + "|";
                    ICDIDs += row.ICDID + "|";
                    BodyPartIDs += "0|";
                    ParentDocumentIDs += parentDocumentID + "|";
                    PatientIDs += patientID + "|";
                    FacAdmissionIDs += facAdmissionID + "|";
                    PhysicianAdmissionIDs += physicianAdmissionID + "|";
                    VisitAdmissionIDs += visitAdmissionID + "|";
                    FacIDs += facID + "|";
                    ICDNames += row.ICDName + "|";
                    ICDDescriptions += row.ICDDescription + "|";
                    ICDYHCTs += row.ICDYHCTID + "|";
                    ICDNameYHCTs += row.ICDYHCTName + "|";
                    ICDYHCTNames += row.ICDYHCTName + "|";
                    ICDYHCTDescriptions += row.ICDYHCTDescription + "|";
                    BodyPartNames += "|";
                    ICD10IDs += row.ICDID + "|";
                    ICD10s += row.ICDName + "|";
                    ICD10DoctorNames += row.ICDName + "|";
                    ICD10Names += row.ICDName + "|";
                    ICD10IDChinhMatTrais += "|";
                    ICD10IDChinhMatPhais += "|";
                    IsMains += row.IsMain + "|";
                    IsShowICDNotes += row.IsShowICDNote + "|";
                    IsRegimens += "False|";
                    ICDNotes += row.ICDNote + "|";
                    ICDYHCTNotes += row.ICDYHCTNote + "|";
                    IsRegimenss += row.IsRegimen + "|";
                    OrderIndexs += row.OrderIndex + "|";
                    DiagnosedOns += (diagnosedOn == DateTime.MinValue || diagnosedOn == DateTime.MaxValue || diagnosedOn == null) ? null : diagnosedOn.ToString("yyyy-MM-dd HH:mm:ss") + "|";
                    if (diagnosedBy + "" != "")
                    {
                        DiagnosedBys += diagnosedBy + "|";
                    }

                    Notes += "lưu ICD-> QAHosGenericDB..ws_CN_Diagnosis_Saves|";
                    FromMenus += fromMenu + "|";
                    FromControls += fromControl + "|";
                    FromPCs += fromPC + "|";
                    FromMACs += fromMAC + "|";
                }
            }



            //if (dtDiagnosis.Rows.Count == 0)
            //{
            //    var rowNew = dtDiagnosis.NewRow();
            //    rowNew["DocumentID"] = documentID;
            //    rowNew["ICDID"] = "";
            //    rowNew["BodyPartID"] = -1;
            //    rowNew["ParentDocumentID"] = parentDocumentID;
            //    rowNew["PatientID"] = patientID;
            //    rowNew["FacAdmissionID"] = facAdmissionID;
            //    rowNew["PhysicianAdmissionID"] = physicianAdmissionID;
            //    rowNew["VisitAdmissionID"] = visitAdmissionID;
            //    rowNew["FacID"] = facID;
            //    rowNew["ICDName"] = "";
            //    rowNew["ICDDescription"] = "";
            //    rowNew["ICDYHCTID"] = "";
            //    rowNew["ICDYHCTName"] = "";
            //    rowNew["ICDYHCTDescription"] = "";
            //    rowNew["BodyPartName"] = "";
            //    rowNew["BodyPartGroupID"] = -1;
            //    rowNew["BodyPartGroupName"] = "";
            //    rowNew["ICD10ID"] = "";
            //    rowNew["ICD10IDChinhMatTrai"] = "";
            //    rowNew["ICD10IDChinhMatPhai"] = "";
            //    rowNew["IsMain"] = false;
            //    rowNew["IsShowICDNote"] = false;
            //    rowNew["IsRegimens"] = false;
            //    rowNew["OrderIndex"] = -1;
            //    rowNew["DiagnosedOn"] = diagnosedOn;
            //    if (diagnosedBy + "" != "")
            //    {
            //        rowNew["DiagnosedBy"] = diagnosedBy;
            //    }
            //    rowNew["Note"] = "lưu ICD";
            //    dtDiagnosis.Rows.Add(rowNew);
            //}



            //this.DATABASE
            query += DataQuery.Create("QAHosGenericDB", "ws_CN_Diagnosis_Saves", new
            {
                DocumentIDs = DocumentIDs,
                ParentDocumentIDs = ParentDocumentIDs,
                ICDIDs = ICDIDs,
                BodyPartIDs = BodyPartIDs,
                PatientIDs = PatientIDs,
                FacAdmissionIDs = FacAdmissionIDs,
                PhysicianAdmissionIDs = PhysicianAdmissionIDs,
                VisitAdmissionIDs = VisitAdmissionIDs,
                FacIDs = FacIDs,
                ICDNames = ICDNames,
                ICDDescriptions = ICDDescriptions,
                ICDYHCTs = ICDYHCTs,
                ICDYHCTIDs = ICDYHCTs,
                ICDYHCTNames = ICDYHCTNames,
                ICDNameYHCTs = ICDNameYHCTs,
                ICDYHCTDescriptions = ICDYHCTDescriptions,
                BodyPartNames = BodyPartNames,
                ICD10IDs = ICD10IDs,
                ICD10s = ICD10s,
                ICD10DoctorNames = ICD10DoctorNames,
                ICD10IDChinhMatTrais = ICD10IDChinhMatTrais,
                ICD10IDChinhMatPhais = ICD10IDChinhMatPhais,
                ICD10Names = ICD10Names,
                IsMains = IsMains,
                IsShowICDNotes = IsShowICDNotes,
                IsRegimens = IsRegimens,
                ICDNotes = ICDNotes,
                ICDYHCTNotes = ICDYHCTNotes,
                OrderIndexs = OrderIndexs,
                DiagnosedOns = DiagnosedOns,
                DiagnosedBys = DiagnosedBys,
                FromMenus = FromMenus,
                FromControls = FromControls,
                FromPCs = FromPCs,
                FromMACs = FromMACs,
                Notes = Notes,
            });

            return query;

        }



        /*Thông tin PhysicianAdmissions*/
        public RequestCollection ws_CN_PhysicianAdmissions_Get(string database, string facID, string physicianAdmissionID)
        {
            var query = new RequestCollection();
            physicianAdmissionID = physicianAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : physicianAdmissionID;
            query += DataQuery.Create(/*this.DATABASE*/ "QAHosGenericDB", "ws_CN_PhysicianAdmissions_GetByPhysicianAdmissionID", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID
            });
            return query;
        }


        public RequestCollection ws_DocumentTypeSettings_WithDocumentTypeByFacility_List(string facID, string documentTypeID)
        {
            documentTypeID = documentTypeID + "" == "" ? QAFunction.DefaultGuid() : documentTypeID;
            return DataQuery.Create("Application", "ws_DocumentTypeSettings_WithDocumentTypeByFacility_List", new
            {
                FacID = facID,
                DocumentTypeID = documentTypeID

            });
        }

        // Hẹn tái khám
        public RequestCollection ws_CN_PatientScheduledVisits_Get(string facID, string physicianAdmissionID)
        {
            physicianAdmissionID = physicianAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : physicianAdmissionID;
            return DataQuery.Create("QAHosGenericDB", "ws_CN_PatientScheduledVisits_Get", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID
            });
        }


        public RequestCollection ws_DOC_PatientDocument_Save(
        string patientID,
        string documentID,
        string facAdmissionID,
        string physicianAdmissionID,
        string visitAdmissionID,
        string parentClinicalSessionID,
        string clinicalSessionID,
        string parentDocumentID,
        string linkToDocumentID,
        string documentTypeID,
        DateTime? documentDate,
        string documentName,
        bool isLocked,
        bool isCompleted,
        bool isBilingual,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note,
        string doctorBy)
        {
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            facAdmissionID = string.IsNullOrEmpty(facAdmissionID) ? QAFunction.DefaultGuid().ToString() : facAdmissionID;
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;

            return DataQuery.Create("Docs", "ws_DOC_PatientDocument_Save", new
            {
                PatientID = patientID,
                DocumentID = documentID,
                FacAdmissionID = facAdmissionID,
                PhysicianAdmissionID = physicianAdmissionID,
                VisitAdmissionID = visitAdmissionID,
                ClinicalSessionID = parentClinicalSessionID,
                ParentDocumentID = parentDocumentID,
                LinkToDocumentID = linkToDocumentID,
                DocumentTypeID = documentTypeID,
                DocumentDate = (documentDate == DateTime.MinValue || documentDate == DateTime.MaxValue || documentDate == null)
                ? null
                : documentDate.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                DocumentBy = doctorBy + "" == "" ? null : doctorBy,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> Docs..ws_DOC_PatientDocument_Save",
            });
        }

        public RequestCollection ws_DOC_Patient_Generic_Examination_Save(
        string patientID,
        string documentID,
        string lyDoVaoVien,
        string quaTrinhBenhLy,
        string khamBenh,
        string toanThan,
        string tienSuBenhBanThan,
        string tienSuBenhGiaDinh,
        string tomTatKetQuaCLS,
        string daXuLy)
        {
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            return DataQuery.Create(QAFunction.DefaultDatabase(), "ws_DOC_Patient_Generic_Examination_Save", new
            {
                PatientID = patientID,
                DocumentID = documentID,
                LyDoVaoVien = lyDoVaoVien,
                QuaTrinhBenhLy = quaTrinhBenhLy,
                KhamBenh = khamBenh,
                ToanThan = toanThan,
                TienSuBenhBanThan = tienSuBenhBanThan,
                TienSuBenhGiaDinh = tienSuBenhGiaDinh,
                TomTatKetQuaCLS = tomTatKetQuaCLS,
                DaXuLy = daXuLy
            });
        }


        public RequestCollection ws_DOC_GenericExam_Save(
        string documentID,
        string patientID,
        string facAdmissionID,
        string physicianAdmissionID,
        string visitAdmissionID,
        string parentClinicalSessionID,
        string facID,
        string patientHospitalID,
        string fullName,
        DateTime? doB,
        string doBName,
        int? age,
        bool? genderID,
        string genderName,
        string roomID,
        string roomName,
        string nationalIDNo,
        string address,
        DateTime? admitOn,
        string mobile,
        string presentComplaint,
        string pathologicalProcess,
        string personalHistory,
        string familyHistory,
        int? pulse,
        string temperature,
        int? bloodPressureUpper,
        int? bloodPressureLower,
        string bloodPressure,
        int? breath,
        string pupil,
        int? glasgow,
        string height,
        string weight,
        string bMI,
        string nutritionalClassification,
        string clinicalBody,
        string clinicalPart,
        string subClinical,
        string allergy,
        string medicalHistory,
        string surgicalHistory,
        string productUsing,
        string treatmentOther,
        DateTime? documentDate,
        string doctorBy,
        string doctorName,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            facAdmissionID = string.IsNullOrEmpty(facAdmissionID) ? QAFunction.DefaultGuid().ToString() : facAdmissionID;
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;
            return DataQuery.Create("Docs", "ws_DOC_GenericExam_Save", new
            {
                DocumentID = documentID,
                PatientID = patientID,
                FacAdmissionID = facAdmissionID,
                PhysicianAdmissionID = physicianAdmissionID,
                VisitAdmissionID = visitAdmissionID,
                ParentClinicalSessionID = parentClinicalSessionID,
                FacID = facID,
                PatientHospitalID = patientHospitalID,
                FullName = fullName,
                DoB = doB == null || doB == DateTime.MinValue || doB == DateTime.MaxValue ? null : doB.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                DoBName = doBName,
                Age = age,
                GenderID = genderID,
                GenderName = genderName,
                RoomID = roomID,
                RoomName = roomName,
                NationalIDNo = nationalIDNo,
                Address = address,
                AdmitOn = admitOn == null || admitOn == DateTime.MinValue || admitOn == DateTime.MaxValue ? null : admitOn.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                Mobile = mobile,
                PresentComplaint = presentComplaint,
                PathologicalProcess = pathologicalProcess,
                PersonalHistory = personalHistory,
                FamilyHistory = familyHistory,
                Pulse = pulse + "" == "" ? (int?)null : pulse,
                Temperature = temperature + "" == "" ? null : temperature,
                BloodPressureUpper = bloodPressureUpper + "" == "" ? (int?)null : bloodPressureUpper,
                BloodPressureLower = bloodPressureLower + "" == "" ? (int?)null : bloodPressureLower,
                BloodPressure = bloodPressure + "" == "" ? null : bloodPressure,
                Breath = breath + "" == "" ? (int?)null : breath,
                Pupil = pupil + "",
                Glasgow = (int?)null,
                Height = height + "" == "" ? null : height,
                Weight = weight + "" == "" ? null : weight,
                BMI = bMI + "" == "" ? null : bMI,
                NutritionalClassification = nutritionalClassification,
                ClinicalBody = clinicalBody,
                ClinicalPart = clinicalPart,
                SubClinical = subClinical,
                Allergy = allergy,
                MedicalHistory = medicalHistory,
                SurgicalHistory = surgicalHistory,
                ProductUsing = productUsing,
                TreatmentOther = treatmentOther,
                DocumentDate = documentDate == null || documentDate == DateTime.MinValue || documentDate == DateTime.MaxValue ? null : documentDate.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                DoctorBy = doctorBy + "" == "" ? null : doctorBy,
                DoctorName = doctorName,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> QADocGenericExamDB..ws_DOC_GenericExam_Save"
            });
        }
        public RequestCollection ws_CN_GenericExam_Save(
        string documentID,
        string patientID,
        string facAdmissionID,
        string physicianAdmissionID,
        string visitAdmissionID,
        string parentClinicalSessionID,
        string clinicalSessionID,
        string facID,
        string presentComplaint,
        string pathologicalProcess,
        string personalHistory,
        string allergyHistory,
        string internalHistory,
        string surgeryHistory,
        string productUsing,
        string familyHistory,
        int? pulse,
        string temperature,
        int? bloodPressureUpper,
        int? bloodPressureLower,
        string bloodPressure,
        int? breath,
        string height,
        string weight,
        string bMI,
        string nutritionalClassification,
        string clinicalBody,
        string clinicalPart,
        string subClinical,
        string doctorBy,
        string doctorName,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            // Trích xuất logic kiểm tra và gán giá trị mặc định của các tham số
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            facAdmissionID = string.IsNullOrEmpty(facAdmissionID) ? QAFunction.DefaultGuid().ToString() : facAdmissionID;
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;

            // Tạo và trả về đối tượng RequestCollection
            return DataQuery.Create("QAHosGenericDB", "ws_CN_GenericExam_Save", new
            {
                DocumentID = documentID,
                PatientID = patientID,
                FacAdmissionID = facAdmissionID,
                PhysicianAdmissionID = physicianAdmissionID,
                VisitAdmissionID = visitAdmissionID,
                ParentClinicalSessionID = parentClinicalSessionID,
                ClinicalSessionID = clinicalSessionID,
                FacID = facID,
                PresentComplaint = presentComplaint,
                PathologicalProcess = pathologicalProcess,
                PersonalHistory = personalHistory,
                AllergyHistory = allergyHistory,
                InternalHistory = internalHistory,
                SurgeryHistory = surgeryHistory,
                ProductUsing = productUsing,
                FamilyHistory = familyHistory,
                Pulse = pulse + "" == "" ? (int?)null : pulse,
                Temperature = temperature + "" == "" ? null : temperature,
                BloodPressureUpper = bloodPressureUpper + "" == "" ? (int?)null : bloodPressureUpper,
                BloodPressureLower = bloodPressureLower + "" == "" ? (int?)null : bloodPressureLower,
                BloodPressure = bloodPressure + "" == "" ? null : bloodPressure,
                Breath = breath + "" == "" ? (int?)null : breath,
                Height = height + "" == "" ? null : height,
                Weight = weight + "" == "" ? null : weight,
                BMI = bMI + "" == "" ? null : bMI,
                NutritionalClassification = nutritionalClassification,
                ClinicalBody = clinicalBody,
                ClinicalPart = clinicalPart,
                SubClinical = subClinical,
                DoctorBy = doctorBy + "" == "" ? null : doctorBy,
                DoctorName = doctorName,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> QADocGenericExamDB..ws_DOC_GenericExam_Save",
            });
        }
        public RequestCollection ws_CN_VitalSign_ForDocGenericExam_Save(
        string facID,
        string parentClinicalSessionID,
        string visitAdmissionID,
        string physicianAdmissionID,
        string facAdmissionID,
        string patientID,
        string documentID,
        int? pulse,
        string temperature,
        int? bloodPressureUpper,
        int? bloodPressureLower,
        string bloodPressure,
        int? breath,
        string pupil,
        int? glasgow,
        string height,
        string weight,
        string bmi,
        string vitalSignOn,
        string vitalSignBy,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            facAdmissionID = string.IsNullOrEmpty(facAdmissionID) ? QAFunction.DefaultGuid().ToString() : facAdmissionID;
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            // Tạo và trả về đối tượng RequestCollection
            return DataQuery.Create("QADocGenericExamDB", "ws_CN_VitalSign_ForDocGenericExam_Save", new
            {
                FacID = facID,
                ParentClinicalSessionID = parentClinicalSessionID,
                VisitAdmissionID = visitAdmissionID,
                PhysicianAdmissionID = physicianAdmissionID,
                FacAdmissionID = facAdmissionID,
                PatientID = patientID,
                DocumentID = documentID,
                Pulse = pulse,
                Temperature = temperature,
                BloodPressureUpper = bloodPressureUpper,
                BloodPressureLower = bloodPressureLower,
                BloodPressure = bloodPressure,
                Breath = breath,
                Pupil = pupil,
                Glasgow = glasgow,
                Height = height,
                Weight = weight,
                BMI = bmi,
                VitalSignOn = vitalSignOn,
                VitalSignBy = vitalSignBy,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> QADocGenericExamDB..ws_CN_VitalSign_ForDocGenericExam_Save"
            });
        }
        public RequestCollection ws_DOC_DocumentSummary_ForGenericExam_Save(
        string documentID,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            // Tạo và trả về đối tượng RequestCollection
            return DataQuery.Create("Docs", "ws_DOC_DocumentSummary_ForGenericExam_Save", new
            {
                DocumentID = documentID,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> QADocGenericExamDB..ws_DOC_DocumentSummary_ForGenericExam_Save"
            });
        }


        public RequestCollection ws_CN_PhysicianAdmissions_UpdateIsPracticed(string facID, string physicianAdmissionID, int isPracticed)
        {
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;
            return DataQuery.Create("QAHosGenericDB", "ws_CN_PhysicianAdmissions_UpdateIsPracticed", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID,
                IsPracticed = isPracticed
            });
        }

        public RequestCollection ws_CN_PhysicianAdmissions_UpdatePrimaryDoctor(string facID, string physicianAdmissionID, int deptID, int roomID)
        {
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;
            return DataQuery.Create("QAHosGenericDB", "ws_CN_PhysicianAdmissions_UpdatePrimaryDoctor", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID,
                DeptID = deptID,
                RoomID = roomID
            });
        }

        public RequestCollection ws_DOC_PhysicianAdmissionSummary_Examination_Save(
        string facID,
        string physicianAdmissionID,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string notes)
        {
            physicianAdmissionID = string.IsNullOrEmpty(physicianAdmissionID) ? QAFunction.DefaultGuid().ToString() : physicianAdmissionID;
            return DataQuery.Create("Docs", "ws_DOC_PhysicianAdmissionSummary_Examination_Save", new
            {
                FacID = facID,
                PhysicianAdmissionID = physicianAdmissionID,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Notes = notes + "bool IDocumentEditor.Save()"
            });
        }

        public RequestCollection ws_DOC_GenericExam_Complete(
        string documentID,
        string patientID,
        string completedOn,
        string completedBy,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            return DataQuery.Create("Docs", "ws_DOC_GenericExam_Complete", new
            {
                DocumentID = documentID,
                PatientID = patientID,
                CompletedOn = completedOn,
                CompletedBy = completedBy,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> QADocGenericExamDB..ws_DOC_GenericExam_Complete"
            });
        }

        public RequestCollection ws_DOC_PatientDocument_Complete(
        string documentID,
        string patientID,
        string completedOn,
        string completedBy,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            return DataQuery.Create("Docs", "ws_DOC_PatientDocument_Complete", new
            {
                DocumentID = documentID,
                PatientID = patientID,
                CompletedOn = completedOn,
                CompletedBy = completedBy,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> Docs..ws_DOC_PatientDocument_Complete"
            });
        }

        public RequestCollection ws_DOC_PatientDocument_UnComplete(
        string documentID,
        string patientID,
        string fromMenu,
        string fromControl,
        string fromPC,
        string fromMAC,
        string note)
        {
            documentID = string.IsNullOrEmpty(documentID) ? QAFunction.DefaultGuid().ToString() : documentID;
            patientID = string.IsNullOrEmpty(patientID) ? QAFunction.DefaultGuid().ToString() : patientID;
            return DataQuery.Create("Docs", "ws_DOC_PatientDocument_UnComplete", new
            {
                DocumentID = documentID,
                PatientID = patientID,
                FromMenu = fromMenu,
                FromControl = fromControl,
                FromPC = fromPC,
                FromMAC = fromMAC,
                Note = note + " -> Docs..ws_DOC_PatientDocument_UnComplete"
            });
        }

    }
}
