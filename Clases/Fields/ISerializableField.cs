using System;

namespace RapiTools.Fields
{
    interface ISerializableField
    {
        /// <summary>
        /// Determinates if a field will be encrypted or not, this propertie must be especified at instantiation time.
        /// </summary>
        bool Encrypted { get; set; }
      
        /// <summary>
        /// This propertie indicates the Datetime of the last update of the Field either
        /// </summary>
        DateTime LastUpdated { get; }
        bool ReadField();
        bool WriteField(string str);
        
    }
}