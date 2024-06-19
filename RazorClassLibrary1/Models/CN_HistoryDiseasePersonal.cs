using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RazorClassLibrary1.Models
{
    public class CN_HistoryDiseasePersonal
    {
        public int DiseaseID { get; set; }//int
        public string DiseaseName { get; set;}//nvarchar(500)
        public int SpecialistID { get; set; }//int
        public string SpecialistName { get; set;}//nvarchar(500)
    }
}
