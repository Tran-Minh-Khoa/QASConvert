using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RazorClassLibrary1.Models
{
    public class CN_FinalDecision
    {
        public bool? IsSelected { get; set; }// bit
        public Guid DocumentID { get; set; } // uniqueidentifier
        public Guid? PatientID { get; set; } // uniqueidentifier
        public Guid? FacAdmissionID { get; set; } // uniqueidentifier
        public Guid? PhysicianAdmissionID { get; set; } // uniqueidentifier
        public Guid? VisitAdmissionID { get; set; } // uniqueidentifier
        public Guid? ClinicalSessionID { get; set; } // uniqueidentifier
        public Guid? ParentClinicalSessionID { get; set; } // uniqueidentifier
        public Guid? ParentDocumentID { get; set; } // uniqueidentifier
        public Guid? LinkToDocumentID { get;set; }// uniqueidentifier
        public int? FinalDecisionID { get; set; }//int
        public string FinalDecisionName { get; set; }//nvarchar(500)
        public Guid? DocumentTypeID { get; set; }// uniqueidentifier
        public string DocumentName { get; set; }//nvarchar(MAX)
        public string EditorType { get; set; }// varchar(50)
        public int? SortOrder { get; set; }//int
    }
}
