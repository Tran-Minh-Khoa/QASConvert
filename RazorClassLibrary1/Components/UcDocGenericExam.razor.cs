using DevExpress.Utils;
using DevExpress.XtraPrinting.Shape.Native;
using Microsoft.AspNetCore.Components;
using RazorClassLibrary1.Models;
using QABlazor;
using System;

//using QA.Shared.Practice.VitalSign;
//using QA;
//using QASBlazor.DocGenericExam.Models;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using QA.Shared.Practice;
using System.Diagnostics;

namespace RazorClassLibrary1.Components
{
    public partial class UcDocGenericExam 
    {
        //[Parameter] public string DocumentID { get; set; }
        //[Parameter] public string PatientID { get; set; }
        //[Parameter] public string FacAdmissionID { get; set; }
        //[Parameter] public string PhysicianAdmissionID { get; set; }
        //[Parameter] public string VisitAdmissionID { get; set; }
        //[Parameter] public string ParentClinicalSessionID { get; set; }
        //[Parameter] public string ClinicalSessionID { get; set; }
        //[Parameter] public string ParentDocumentID { get; set; }
        //[Parameter] public string LinkToDocumentID { get; set; }
        //[Parameter] public string DocumentTypeID { get; set; }
        //[Parameter] public DateTime DocumentDate { get; set; }
        //[Parameter] public string DocumentName { get; set; }
        //[Parameter] public bool IsLocked { get; set; }
        [Parameter] public bool IsCompleted { get; set; }

        public bool isBilingual { get; set; }

        private string _fromMenu = "";
        private string _fromControl = "";
        private string _fromPC = "";
        private string _fromMAC = "";
        private string _note = "";

        private string _errorInfor = "";
        private string _errorMessage = "";
        [Inject]
        public IClientServices Services { get; set; }
        private DataRow RowDocumentInfo { get; set; }
        private DOC_GenericExam _docGenericExam { get; set; }
        private MDM_Patient _patient { get; set; }
        private CN_VitalSign _vitalSign { get; set; }
        private CN_PhysicianAdmissions _physicianAdmissions { get; set; }
        private CN_PersonalHistory _personalHistory { get; set; }
        private CN_FamilyHistory _familyHistory { get; set; }
        private CN_AllergyHistory _allergyHistory { get; set; }
        private List<CN_HistoryDiseasePersonal> _listDiseaseHistory = new List<CN_HistoryDiseasePersonal>();
        private List<CN_ProductHistory> _listProductUsing = new List<CN_ProductHistory>();
        private List<CN_DoctorDecision> _listFinalDecision = new List<CN_DoctorDecision>();
        private List<CN_FinalDecision> _listDecision = new List<CN_FinalDecision>();
        private List<MDM_Employee> _listEmployee = new List<MDM_Employee>();
        private List<QA.Shared.Practice.DataModels.CN_Diagnosis> _listDiagnosis = new List<QA.Shared.Practice.DataModels.CN_Diagnosis>();

        private PROCEDURE PROCEDURE = new PROCEDURE();
        private FUNCTION FUNCTION = new FUNCTION();
        private SETTING SETTING = new SETTING();

        private string _fullName;
        private DateTime? _doB;
        private string _doBName;
        private int? _age;
        private bool? _genderID;
        private string _genderName;
        private string _patientHospitalID;
        private string _roomID;
        private string _roomName;
        private DateTime? _examineDate;
        private string _phoneNumber;
        private string _address;
        private string _nationalID;
        private string _treatment;



        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        public DateTime? DoB
        {
            get => _doB;
            set => _doB = value;
        }

        public string DoBName
        {
            get => _doBName;
            set => _doBName = value;
        }

        public int? Age
        {
            get => _age;
            set => _age = value;
        }

        public bool? GenderID
        {
            get => _genderID;
            set => _genderID = value;
        }

        public string GenderName
        {
            get => _genderName;
            set => _genderName = value;
        }

        public string PatientHospitalID
        {
            get => _patientHospitalID;
            set => _patientHospitalID = value;
        }

        public string RoomID
        {
            get => _roomID;
            set => _roomID = value;
        }

        public string RoomName
        {
            get => _roomName;
            set => _roomName = value;
        }

        public DateTime? ExamineDate
        {
            get => _examineDate;
            set => _examineDate = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string NationalID
        {
            get => _nationalID;
            set => _nationalID = value;
        }

        public string Treatment
        {
            get => _treatment;
            set => _treatment = value;
        }
        public string PresentComplaint { get; set; }
        public string PathologicalProcess { get; set; }
        public string PersonalHistory { get; set; }
        public string AllergyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string SurgicalHistory { get; set; }
        public string FamilyHistory { get; set; }
        public string ClinicalBody { get; set; }
        public string ClinicalPart { get; set; }
        public string SubClinical { get; set; }
        public string TreatmentOther { get; set; }
        public string DoctorBy { get; set; }
        public string Nationality { get; set; }
        public List<MDM_Employee> ListEmployee { get; set; }

        public string Pulse { get; set; }
        public string Temperature { get; set; }
        public string BloodPressure { get; set; }
        public string Breath { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BMI { get; set; }

        protected override void OnInitialized()
        {
            // Initialization logic here
            Populate(Services, RowDocumentInfo);
        }

        private void SetPatientInfo(string patientHospitalID, string fullName, DateTime dOb, string dObName, string age, bool genderID, string genderName, string roomID,
                            string roomName, string nationalID, string address, string phoneNumber, DateTime examineDate)
        {
            PatientHospitalID = patientHospitalID;
            FullName = fullName;
            DoB = dOb;
            DoBName = dObName;
            Age = string.IsNullOrEmpty(age) ? (int?)null : Convert.ToInt32(age);
            GenderID = genderID;
            GenderName = genderName;
            RoomID = roomID;
            RoomName = roomName;
            NationalID = nationalID;
            Address = address;
            PhoneNumber = phoneNumber;
            ExamineDate = examineDate;
        }

        private void SetVitalSign(string pulse, string temperature, string bloodPressure, string breath, string spO2, string pupil,
                          string glasgow, string weight, string height, string bMI, string nutritionalClassification)
        {
            Pulse = pulse;
            Temperature = temperature;
            BloodPressure = bloodPressure;
            Breath = breath;
            Height = height;
            Weight = weight;
            BMI = bMI;
        }

        private void SetDocument(string presentComplaint, string pathologicalProcess, string personalHistory, string familyHistory, string clinicalBody,
                        string clinicalPart, string subClinical, DateTime documentDate, string doctorBy, string allergyHistory, string medicalHistory,
                        string surgicalHistory, string productUsing, string treatment, string treatmentOther)
        {
            PresentComplaint = presentComplaint;
            PathologicalProcess = pathologicalProcess;
            PersonalHistory = personalHistory;
            FamilyHistory = familyHistory;
            ClinicalBody = clinicalBody;
            ClinicalPart = clinicalPart;
            SubClinical = subClinical;
            Treatment = treatment;
            TreatmentOther = treatmentOther;
            DocumentDate = documentDate.ToString();
            DoctorBy = doctorBy;
            AllergyHistory = allergyHistory;
            MedicalHistory = medicalHistory;
            SurgicalHistory = surgicalHistory;
        }

        public void Populate(IClientServices services, DataRow documentInfo)
        {
            //Debug.WriteLine("TestValue");
            //Debug.WriteLine(documentInfo);
            //Debug.WriteLine(documentInfo.Item("DocumentID"));
            //Debug.WriteLine(documentInfo.Item("DocumentID"));

            // Populate method logic here
            this.Services = services;
            this.RowDocumentInfo = documentInfo;
            this.DocumentID = documentInfo.Item("DocumentID");
            this.PatientID = documentInfo.Item("PatientID");
            this.FacAdmissionID = documentInfo.Item("FacAdmissionID");
            this.PhysicianAdmissionID = documentInfo.Item("PhysicianAdmissionID");
            this.VisitAdmissionID = documentInfo.Item("VisitAdmissionID");
            this.ParentClinicalSessionID = documentInfo.Item("ClinicalSessionID");
            this.ClinicalSessionID = documentInfo.Item("ClinicalSessionID");
            this.ParentDocumentID = documentInfo.Item("ParentDocumentID");
            this.LinkToDocumentID = documentInfo.Item("LinkToDocumentID");
            this.DocumentTypeID = documentInfo.Item("DocumentTypeID");
            //this.DocumentDate = documentInfo.Item("DocumentDate") + "" == "" ? DateTime.MinValue : DateTime.Parse(documentInfo.Item("DocumentDate"), CultureInfo.CurrentCulture);
            this.DocumentName = documentInfo.Item("DocumentName");
            Console.WriteLine("TestValue");
            Console.WriteLine($"{documentInfo.Item("DocumentID")}");
            Console.WriteLine(this.DocumentID);
            Process();

        }
        DateTime timestart;
        DateTime timestart1;
        DateTime timeend;
        TimeSpan finaltime;
        string showtime;
        private async void Process()
        {
            timestart = DateTime.Now;
            timestart1 = DateTime.Now;
            //sw.Start();
            //Console.WriteLine("Start 1: QA.Prescription.Prescription_Default ->  public override void Process() -> query {0}", sw.ElapsedMilliseconds);
            //base.Process();
            this.DocumentID = this.DocumentID + "" == "" ? QAFunction.DefaultGuid() + "" : this.DocumentID;
            this.PatientID = this.PatientID + "" == "" ? QAFunction.DefaultGuid() + "" : this.PatientID;
            this.FacAdmissionID = this.FacAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : this.FacAdmissionID;
            this.PhysicianAdmissionID = this.PhysicianAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : this.PhysicianAdmissionID;
            this.VisitAdmissionID = this.VisitAdmissionID + "" == "" ? QAFunction.DefaultGuid() + "" : this.VisitAdmissionID;
            this.ParentClinicalSessionID = this.ParentClinicalSessionID + "" == "" ? QAFunction.DefaultGuid() + "" : this.ParentClinicalSessionID;
            this.ClinicalSessionID = this.ClinicalSessionID + "" == "" ? QAFunction.DefaultGuid() + "" : this.ClinicalSessionID;
            this.ParentDocumentID = this.ParentDocumentID + "" == "" ? QAFunction.DefaultGuid() + "" : this.ParentDocumentID;
            this.LinkToDocumentID = this.LinkToDocumentID + "" == "" ? QAFunction.DefaultGuid() + "" : this.LinkToDocumentID;
            this.DocumentTypeID = this.DocumentTypeID + "" == "" ? QAFunction.DefaultGuid() + "" : this.DocumentTypeID;


            if (Services == null)
            {
                return;
            }
            _errorInfor = @"{""PhysicianAdmissionID""" + @":""" + this.PhysicianAdmissionID + @"""," + @"""ParentClinicalSessionID""" + @":""" + this.ParentClinicalSessionID + @"""," + @"""DocumentTypeID""" + @":""" + this.DocumentTypeID + @"""," + @"""DocumentID""" + @":""" + this.DocumentID + @"" + "}";
            _errorMessage = "Trong quá trình thực hiện truy vấn đã xảy ra lỗi, vui lòng gửi thông tin lỗi về Admin để được hỗ trợ nhanh nhất!\r\n\r\n Thông tin lỗi: \r\n" + "- Thông tin bệnh nhân:\r\n" + _errorInfor + "\r\n- Chi tiết lỗi:\r\n";
            this._fromMenu = Services.GetMemoryStorageValue("Menu_ControlType") + "";
            this._fromControl = this.GetType().Name;
            this._fromPC = Environment.MachineName;
            this._fromMAC = NetworkInterface
                                           .GetAllNetworkInterfaces()
                                           .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                                           .Select(nic => nic.GetPhysicalAddress().ToString())
                                           .FirstOrDefault();
            //this._note = "Menu: " + this._menu + "; Control: " + this._control + "; PC: " + this._pc + "; MAC: " + this._mac + "; Event: ";

            var query = new RequestCollection();
            query += PROCEDURE.ws_DocumentTypeSettings_WithDocumentTypeByFacility_List(await Services.GetSessionStorageValue("FacID"), this.DocumentTypeID);/*Tables[13]*/

            var ds = await Services.Execute(query);
            if (await ds.ValidateMessages(Services))
            {
                return;
            }

            var listDocumentTypeSettings = FUNCTION.ToDocumentTypeSettings(ds.Tables[0]);
            SetDocumentTypeSetting(listDocumentTypeSettings);

            // Tables[0]: Thông tin DOC
            query = PROCEDURE.ws_DOC_GenericExam_Get(await Services.GetSessionStorageValue("FacID"), this.PatientID, this.DocumentID);
            // Tables[1]: Thông tin bệnh nhân
            query += PROCEDURE.ws_MDM_Patient_Default_Get(this.PatientID);
            // Tables[2]: Sinh hiệu mặc định
            query += PROCEDURE.ws_CN_VitalSign_FinalExistsOfPatient_Get(await Services.GetSessionStorageValue("FacID"), this.PatientID);
            //Tables[3]: Thong tin PhysicianAdmission
            query += PROCEDURE.ws_CN_PhysicianAdmissions_Get(await Services.GetSessionStorageValue("FacID"), this.PhysicianAdmissionID);
            // Tables[4]:Summary Tiền sử bệnh bản thân của bệnh nhân
            query += PROCEDURE.ws_PersonalHistoryV2_SummaryLongByPatient_Get(await Services.GetSessionStorageValue("FacID"), this.PatientID);
            // Tables[5]:Summary Tiền sử bệnh gia đình của bệnh nhân
            query += PROCEDURE.ws_FamilyHistory_SummaryLongByPatient_Get(await Services.GetSessionStorageValue("FacID"), this.PatientID);
            // Tables[6]: Danh sách xử trí theo PhysicianAdmission
            query += PROCEDURE.ws_CN_DoctorDecision_ByPhysicianAdmission_List(await Services.GetSessionStorageValue("FacID"), this.PhysicianAdmissionID);
            // Tables[7]:Summary Tiền sử dị ứng của bệnh nhân
            query += PROCEDURE.ws_Allergy_Get(await Services.GetSessionStorageValue("FacID"), this.PatientID);
            // Tables[8]: Summary Tiền sử nội-ngoại tổng hợp của bệnh nhân
            query += PROCEDURE.ws_CN_HistoryDiseasePersonal_List(await Services.GetSessionStorageValue("FacID"), this.PhysicianAdmissionID);
            // Tables[9]: Danh sách thuốc đang dùng của bệnh nhân
            query += PROCEDURE.ws_Patient_HX_Medical_List(await Services.GetSessionStorageValue("FacID"), this.PatientID);
            // Tables[10]: Danh sách xử trí theo DocumentType của PhysicianAdmission
            query += PROCEDURE.ws_CN_DoctorDecision_ForDocumentTypeWithDocumentServiceFolder_List(await Services.GetSessionStorageValue("FacID"), this.ParentClinicalSessionID, this.DocumentTypeID);
            // Tables[11]: Thông tin phiếu hẹn tái khám
            query += PROCEDURE.ws_CN_PatientScheduledVisits_Get(await Services.GetSessionStorageValue("FacID"), this.PhysicianAdmissionID + "");
            // Tables[12]: Danh sách bác sĩ của bệnh viện
            string positionNames = "bác sĩ|bác sỹ|bát sĩ|bát sỹ|bac si|bac sy|bat si|bat sy|bác si| bác sy|bát si|bát sy|bac sĩ|bac sy|bat sĩ|bat sy";
            query += PROCEDURE.ws_MDM_Employee_HaveUserByPositionName_List(await Services.GetSessionStorageValue("FacID"), positionNames);
            ds = await Services.Execute(query);


            if (await ds.ValidateMessages(Services))
            {
                return;
            }
            this._docGenericExam = FUNCTION.ToDOCGenericExam(ds.Tables[0]).FirstOrDefault();
            if (this._docGenericExam == null)
            {
                this._docGenericExam = new DOC_GenericExam();
            }
            this._patient = FUNCTION.ToMDMPatient(ds.Tables[1]).FirstOrDefault();
            if (this._patient == null)
            {
                this._patient = new MDM_Patient();
            }
            this._vitalSign = FUNCTION.ToCN_VitalSign(ds.Tables[2]).FirstOrDefault();
            if (this._vitalSign == null)
            {
                this._vitalSign = new CN_VitalSign();
            }
            this._physicianAdmissions = FUNCTION.ToCN_PhysicianAdmissions(ds.Tables[3]).FirstOrDefault();
            if (this._physicianAdmissions == null)
            {
                this._physicianAdmissions = new CN_PhysicianAdmissions();
            }
            this._personalHistory = FUNCTION.ToPersonalHistoryV2(ds.Tables[4]).FirstOrDefault();
            if (this._personalHistory == null)
            {
                this._personalHistory = new CN_PersonalHistory();
            }
            this._familyHistory = FUNCTION.ToFamilyHistory(ds.Tables[5]).FirstOrDefault();
            if (this._familyHistory == null)
            {
                this._familyHistory = new CN_FamilyHistory();
            }
            this._listFinalDecision = FUNCTION.ToFinalDecision(ds.Tables[6]);
            if (this._listFinalDecision == null)
            {
                this._listFinalDecision = new List<CN_DoctorDecision>();
            }
            //this._rowPatientInfo = ds.Tables[1].FirstRow();
            //this._rowVitalSign = ds.Tables[2].FirstRow();
            //this._rowPhysicianAdmission = ds.Tables[3].FirstRow();
            //this._rowPersonalHistory = ds.Tables[4].FirstRow();
            //this._rowFamilyHistory = ds.Tables[5].FirstRow();
            //this._dtFinalDecision = ds.Tables[6];
            //SetEnable(this.IsLocked, (this._docGenericExam == null ? false : ((this._docGenericExam.CompletedOn == null || this._docGenericExam.CompletedOn == DateTime.MinValue || this._docGenericExam.CompletedOn == DateTime.MaxValue) ? false : true)), this._docGenericExam, this._listFinalDecision);

            this._allergyHistory = FUNCTION.ToAllergy(ds.Tables[7]).FirstOrDefault();
            if (this._allergyHistory == null)
            {
                this._allergyHistory = new CN_AllergyHistory();
            }
            //this._rowAllergyHistory = ds.Tables[7].FirstRow();
            this._listDiseaseHistory = FUNCTION.ToDiseaseHistory(ds.Tables[8]);
            if (this._listDiseaseHistory == null)
            {
                this._listDiseaseHistory = new List<CN_HistoryDiseasePersonal>();
            }
            //this._dtDeseaseHistory = ds.Tables[8];
            this._listProductUsing = FUNCTION.ToProductUsing(ds.Tables[9]);
            if (this._listProductUsing == null)
            {
                this._listProductUsing = new List<CN_ProductHistory>();
            }
            //this._dtProductUsing = ds.Tables[9];

            this._listDecision = FUNCTION.ToDecision(ds.Tables[10]);
            if (this._listDecision == null)
            {
                this._listDecision = new List<CN_FinalDecision>();
            }
            //DataTable dtDecision = ds.Tables[10];
            this._listEmployee = FUNCTION.ToEmployee(ds.Tables[12]);
            if (this._listEmployee == null)
            {
                this._listEmployee = new List<MDM_Employee>();
            }
            //this._dtDoctor = ds.Tables[12];
            //glu_DoctorBy.Properties.DataSource = this._listEmployee;

            //int dobAccuracyCode = ConvertSafe.ToInt32(rowPatientInfo.Item("DobAccuracyCode") + "");
            if (this._listFinalDecision == null)
            {
                this._listFinalDecision = new List<CN_DoctorDecision>();
            }
            if (_listDecision == null)
            {
                _listDecision = new List<CN_FinalDecision>();
            }

            var arrFinalDecisionName = (from final in this._listFinalDecision.AsEnumerable()
                                        join decis in _listDecision.AsEnumerable() on final.FinalDecisionID equals decis.FinalDecisionID
                                        where ConvertSafe.ToInt32(final.FinalDecisionID) != (int)QA.Decisions.DoctorDecisions.HenTaiKham
                                        orderby ConvertSafe.ToInt32(decis.SortOrder)
                                        select decis.FinalDecisionName).ToArray();

            this._treatment = string.Join(", ", arrFinalDecisionName);


            var rowScheduledVisit = ds.Tables[11].FirstRow();
            DateTime scheduledOn = rowScheduledVisit.Item("ScheduledDate") + "" == "" ? DateTime.MinValue : Convert.ToDateTime(rowScheduledVisit.Item("ScheduledDate"), CultureInfo.CurrentCulture);
            this._treatment = this._treatment + ", " + (scheduledOn == DateTime.MinValue ? "" : "Hẹn tái khám ngày " + scheduledOn.ToString("dd/MM/yyyy"));
            this._treatment = this._treatment.TrimStart(',').TrimStart(' ');

            bool isEqual = QABlazor.QAFunction.JSONEquals(this._docGenericExam, new DOC_GenericExam());

            if (isEqual == true)
            {
                this._docGenericExam = DefaultGenericExam(this._patient, this._physicianAdmissions, this._vitalSign, this._listProductUsing,
                                                          this._listDiseaseHistory, this._personalHistory, this._familyHistory, this._allergyHistory,
                                                          this._listEmployee);
            }
            timeend = DateTime.Now;
            finaltime = (timeend - timestart);
            showtime = showtime + " nyakia " + finaltime.TotalMilliseconds.ToString();
            timestart = DateTime.Now;
            //_age = ConvertSafe.ToInt32(this._docGenericExam.Age);
            SetPatientInfo(this._docGenericExam.PatientHospitalID,
                           this._docGenericExam.FullName,
                           this._docGenericExam.DoB + "" == "" ? DateTime.MinValue : Convert.ToDateTime(this._docGenericExam.DoB, CultureInfo.CurrentCulture),
                           this._docGenericExam.DoBName,
                           this._docGenericExam.Age + "",
                           ConvertSafe.ToBoolean(this._docGenericExam.GenderID),
                           this._docGenericExam.GenderName,
                           this._docGenericExam.RoomID + "",
                           this._docGenericExam.RoomName,
                           this._docGenericExam.NationalIDNo,
                           this._docGenericExam.Address,
                           this._docGenericExam.Mobile,
                           this._docGenericExam.AdmitOn + "" == "" ? DateTime.MinValue : Convert.ToDateTime(this._docGenericExam.AdmitOn, CultureInfo.CurrentCulture));
            timeend = DateTime.Now;
            finaltime = (timeend - timestart);
            showtime = showtime + " patientinfo " + finaltime.TotalMilliseconds.ToString();
            timestart = DateTime.Now;
            SetVitalSign(this._docGenericExam.Pulse + "",
                           this._docGenericExam.Temperature + "",
                           this._docGenericExam.BloodPressure + "",
                           this._docGenericExam.Breath + "",
                           this._docGenericExam.SpO2 + "",
                           this._docGenericExam.Pupil + "",
                           this._docGenericExam.Glasgow + "",
                           this._docGenericExam.Weight + "",
                           this._docGenericExam.Height + "",
                           this._docGenericExam.BMI + "",
                           this._docGenericExam.NutritionalClassification + "");

            timeend = DateTime.Now;
            finaltime = (timeend - timestart);
            showtime = showtime + " vitalsign " + finaltime.TotalMilliseconds.ToString();
            timestart = DateTime.Now;

            string doctorBy = this._docGenericExam.DoctorBy + "";
            //if (dtDoctor.AsEnumerable().Where(s => (s.Item("UserID") + "").ToUpper() == (Services.GetInformation("DoctorBy") + "").ToUpper()).FirstOrDefault() == null)
            //{
            //    var rowNew = dtDoctor.NewRow();
            //    if (doctorBy + "" != "")
            //    {
            //        rowNew["UserID"] = doctorBy;
            //    }
            //    rowNew["FullNameWithTechniqueCode"] = this.RowGenericExam.Item("DoctorName");
            //    dtDoctor.Rows.Add(rowNew);
            //}
            SetDocument(this._docGenericExam.PresentComplaint, this._docGenericExam.PathologicalProcess, this._docGenericExam.PersonalHistory,
                        this._docGenericExam.FamilyHistory, this._docGenericExam.ClinicalBody, this._docGenericExam.ClinicalPart, this._docGenericExam.SubClinical,
                        this._docGenericExam.DocumentDate + "" == "" ? DateTime.MinValue : Convert.ToDateTime(this._docGenericExam.DocumentDate, CultureInfo.CurrentCulture), doctorBy,
                        this._docGenericExam.AllergyHistory, this._docGenericExam.MedicalHistory, this._docGenericExam.SurgicalHistory,
                        this._docGenericExam.ProductUsing, this._treatment, this._docGenericExam.TreatmentOther);
            timeend = DateTime.Now;
            finaltime = (timeend - timestart);
            showtime = showtime + " setdocument " + finaltime.TotalMilliseconds.ToString();




            //query = PROCEDURE.ws_CN_Diagnosis_ByDocument_List(QAFunction.GetFacID(Services), this.PatientID, this.DocumentID);/*Tables[0]: Danh sách chẩn đoán của bệnh nhân*/






            //if (SETTING.MEF_HienThiChanDoanYHCT + "" == "Y")
            //{
            //    if (Services.GetInformation("ICDWithICDYHCT") == null)
            //    {
            //        query += PROCEDURE.ws_L_ICDWithICDYHCT_List(); /*LastTables(): Danh sách ICD*/
            //    }
            //}
            //else
            //{
            //    if (Services.GetInformation("ICDYHHD") == null)
            //    {
            //        query += PROCEDURE.ws_L_ICD_Active_List(); /*LastTables(): Danh sách ICD*/
            //    }
            //}
            //if (Services.GetInformation("ICDWithICDYHCT") == null)
            //{
            //    query += PROCEDURE.ws_L_ICDWithICDYHCT_List(); /*LastTables(): Danh sách ICD*/
            //}
            //timeend = DateTime.Now;
            //finaltime = (timeend - timestart);
            //showtime = finaltime.TotalMilliseconds.ToString();

            //timestart = DateTime.Now;
            //ucKetQuaCLS1.PatientID = this.PatientID;
            //ucKetQuaCLS1.FacAdmissionID = this.FacAdmissionID;
            //ucKetQuaCLS1.Initialize(Services);
            //ucLichSuDonThuoc1.PatientID = this.PatientID;
            //ucLichSuDonThuoc1.FacAdmissionID = this.FacAdmissionID;
            //ucLichSuDonThuoc1.Initialize(Services);
            //ucLichSuDonThuoc1.Process();
            //timeend = DateTime.Now;
            //finaltime = (timeend - timestart);
            //showtime = "loadsp " + showtime + ";kqcls " + finaltime.TotalMilliseconds.ToString();

            //timestart = DateTime.Now;
            //Services.ExecuteAsync(query, Load_Async, null);

        }
        DOC_GenericExam DefaultGenericExam(MDM_Patient _mdmPatient, CN_PhysicianAdmissions _physicianAdmissions, CN_VitalSign _vitalSign,
                                    List<CN_ProductHistory> _listProductUsing, List<CN_HistoryDiseasePersonal> _listDiseaseHistory,
                                    CN_PersonalHistory _personalHistory, CN_FamilyHistory _familyHistory,
                                   CN_AllergyHistory _allergy, List<MDM_Employee> _listEmployee)
        {
            DOC_GenericExam genericExam = new DOC_GenericExam();

            string dObName = "";
            int dobAccuracyCode = _mdmPatient.DobAccuracyCode.GetValueOrDefault();
            switch (dobAccuracyCode)
            {
                case 1:
                    dObName = _mdmPatient.DoB.ToString("yyyy");
                    break;
                case 2:
                    dObName = _mdmPatient.DoB.ToString("MM/yyyy");
                    break;
                case 3:
                    dObName = _mdmPatient.DoB.ToString("dd/MM/yyyy");
                    break;
                default:
                    dObName = "";
                    break;
            }







            genericExam.PatientHospitalID = _mdmPatient.PatientHospitalID + "";
            genericExam.FullName = _mdmPatient.FullName + "";
            genericExam.DoB = _mdmPatient.DoB + "" == "" ? (DateTime?)null : Convert.ToDateTime(_mdmPatient.DoB, CultureInfo.CurrentCulture);
            genericExam.DoBName = dObName + "";
            genericExam.Age = _mdmPatient.AgeFormatYMD + "" == "" ? (int?)null : ConvertSafe.ToInt32(_mdmPatient.AgeFormatYMD + "");
            genericExam.GenderID = ConvertSafe.ToBoolean(_mdmPatient.GenderID);
            genericExam.GenderName = _mdmPatient.GenderName + "";
            genericExam.RoomID = _physicianAdmissions.RoomID.ToString() == "" ? (int?)null : ConvertSafe.ToInt32(_physicianAdmissions.RoomID);

            genericExam.RoomName = _physicianAdmissions.RoomName + "";
            genericExam.NationalIDNo = _mdmPatient.NationalIDNo + "";
            genericExam.Address = _mdmPatient.Address + "";
            genericExam.Mobile = _mdmPatient.HomePhone + "";
            genericExam.AdmitOn = _physicianAdmissions.AdmitOn + "" == "" ? (DateTime?)null : Convert.ToDateTime(Convert.ToDateTime(_physicianAdmissions.AdmitOn, CultureInfo.CurrentCulture).ToString("yyyy/MM/dd HH:mm:ss"));
            genericExam.PresentComplaint = "";
            genericExam.PathologicalProcess = "";

            genericExam.Pulse = _vitalSign.Pulse + "" == "" ? (int?)null : ConvertSafe.ToInt32(_vitalSign.Pulse);
            genericExam.Temperature = _vitalSign.Temperature + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((_vitalSign.Temperature + "").Replace(",", "."));
            genericExam.BloodPressureUpper = FUNCTION.GetBloodPressureUpper(_vitalSign.BloodPressure);
            genericExam.BloodPressureLower = FUNCTION.GetBloodPressureLower(_vitalSign.BloodPressure);
            genericExam.BloodPressure = _vitalSign.BloodPressure;
            genericExam.Breath = _vitalSign.Breath + "" == "" ? (int?)null : ConvertSafe.ToInt32(_vitalSign.Breath);
            genericExam.SpO2 = _vitalSign.SpO2 + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((_vitalSign.SpO2 + "").Replace(",", "."));
            genericExam.Pupil = _vitalSign.Pupil;
            genericExam.Glasgow = _vitalSign.Glasgow + "" == "" ? (int?)null : ConvertSafe.ToInt32(_vitalSign.Glasgow);
            genericExam.Weight = _vitalSign.Weight + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((_vitalSign.Weight + "").Replace(",", "."));
            genericExam.Height = _vitalSign.Height + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((_vitalSign.Height + "").Replace(",", "."));
            genericExam.BMI = _vitalSign.BMI + "" == "" ? (double?)null : QA.Shared.Practice.FUNCTION.ConvertStringToDouble((_vitalSign.BMI + "").Replace(",", "."));
            genericExam.NutritionalClassification = FUNCTION.GetNutritionalClassification(_vitalSign.Height.ToString(), _vitalSign.Weight.ToString());

            genericExam.ClinicalBody = "";
            genericExam.ClinicalPart = "";
            genericExam.SubClinical = "";

            genericExam.TreatmentOther = "";
            genericExam.FinalDecision = "";






            string product = "";
            if (_listProductUsing.Count > 0)
            {
                for (int i = 0; i < _listProductUsing.Count; i++)
                {
                    if (i == _listDiseaseHistory.Count - 1)
                    {
                        product += _listProductUsing[i].ProductName_TT52;
                    }
                    product += _listProductUsing[i].ProductName_TT52 + ", ";
                }
            }

            //string medicalHistoryIDs="";
            string medicalHistoryNames = "";
            //string surgicalHistoryIDs = "";
            string surgicalHistoryNames = "";
            if (_listDiseaseHistory.Count > 0)
            {
                for (int i = 0; i < _listDiseaseHistory.Count; i++)
                {
                    if (i == _listDiseaseHistory.Count - 1)
                    {
                        if (_listDiseaseHistory[i].SpecialistID == 1)
                        {
                            // medicalHistoryIDs += dtDeseaseHistory.Rows[i].Item("DiseaseID");
                            medicalHistoryNames += _listDiseaseHistory[i].DiseaseName;
                        }
                        if (_listDiseaseHistory[i].SpecialistID == 16)
                        {
                            //surgicalHistoryIDs += dtDeseaseHistory.Rows[i].Item("DiseaseID");
                            surgicalHistoryNames += _listDiseaseHistory[i].DiseaseName;
                        }
                    }
                    if (_listDiseaseHistory[i].SpecialistID == 1)
                    {
                        // medicalHistoryIDs += dtDeseaseHistory.Rows[i].Item("DiseaseID");
                        medicalHistoryNames += _listDiseaseHistory[i].DiseaseName + ", ";
                    }
                    if (_listDiseaseHistory[i].SpecialistID == 16)
                    {
                        //surgicalHistoryIDs += dtDeseaseHistory.Rows[i].Item("DiseaseID");
                        surgicalHistoryNames += _listDiseaseHistory[i].DiseaseName + ", ";
                    }
                }
            }


            genericExam.PersonalHistory = _personalHistory.SummaryLong + "";
            genericExam.FamilyHistory = _familyHistory.SummaryLong + "";
            genericExam.DocumentDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), CultureInfo.CurrentCulture);
            //var rowDoctor = _listEmployee.AsEnumerable().Where(s => (s.UserID + "").ToUpper() == (Services.GetInformation("UserID") + "").ToUpper()).FirstOrDefault();
            //string doctorBy = rowDoctor == null ? "" : rowDoctor.UserID + "";
            //string doctorName = rowDoctor == null ? "" : rowDoctor.FullNameWithTechniqueCode;

            //genericExam.DoctorBy = doctorBy + "" == "" ? (Guid?)null : new Guid(doctorBy);
            //genericExam.DoctorName = doctorName + "";
            genericExam.AllergyHistory = _allergy.SummaryLong + "";
            genericExam.MedicalHistory = medicalHistoryNames + "";
            genericExam.SurgicalHistory = surgicalHistoryNames + "";
            genericExam.ProductUsing = product + "";


            return genericExam;
        }

        void SetDocumentTypeSetting(List<DocumentTypeSettings> listDocumentTypeSettings)
        {
            if (listDocumentTypeSettings == null)
            {
                listDocumentTypeSettings = new List<DocumentTypeSettings>();
            }


            var mEF_HienThiICDNote = listDocumentTypeSettings.Where(r => r.SettingCategory == "Practice" && r.SettingName == "MEF_HienThiICDNote").FirstOrDefault();
            SETTING.MEF_HienThiICDNote = mEF_HienThiICDNote == null ? "N" : mEF_HienThiICDNote.Value;

            var mEF_HienThiChanDoanYHCT = listDocumentTypeSettings.Where(r => r.SettingCategory == "Practice" && r.SettingName == "MEF_HienThiChanDoanYHCT").FirstOrDefault();
            SETTING.MEF_HienThiChanDoanYHCT = mEF_HienThiChanDoanYHCT == null ? "N" : mEF_HienThiChanDoanYHCT.Value;
        }

        public bool Save()
        {
            // Save method logic here
            return true;
        }

        public bool Delete()
        {
            return false;
        }

        public bool IsChanged()
        {
            // IsChanged method logic here
            return false;
        }

        public bool Complete()
        {
            // Complete method logic here
            return true;
        }

        public bool UnComplete()
        {
            // UnComplete method logic here
            return true;
        }

        public bool Lock()
        {
            return true;
        }

        public bool UnLock()
        {
            return false;
        }
    }
}

