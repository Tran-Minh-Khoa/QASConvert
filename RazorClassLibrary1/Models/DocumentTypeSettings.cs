using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RazorClassLibrary1.Models
{
    [Serializable]
    [DesignTimeVisible(false)]
    public class DocumentTypeSettings : ISerializable
    {
        public string SettingID { get; set; }
        public Guid? DocumentTypeID { get; set; }
        public string SettingCategory { get; set; }
        public string SettingName { get; set; }
        public string Value { get; set; }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext oContext)
        {
            info.AddValue("SettingID", this.SettingID);
            info.AddValue("DocumentTypeID", this.DocumentTypeID);
            info.AddValue("SettingCategory", this.SettingCategory);
            info.AddValue("SettingName", this.SettingName);
            info.AddValue("Value", this.Value);
        }

    }
}
