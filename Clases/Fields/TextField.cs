using System;
using System.IO;

namespace RapiTools.Fields
{
    public class TextField : Field, ISerializableField
    {
        public TextField(string fieldName) : base(fieldName)
        {
        }
        public bool Encrypted
        {
            get; set;
        }

        public DateTime LastUpdated
        {
            get
            {
                return File.GetLastWriteTime(Path);
            }
        }

        public bool ReadField()
        {
            if (!Encrypted)
            {
                using (StreamReader temp = new StreamReader(Path))
                {
                    Value = temp.ReadLine();
                }
            }
            else
            {
                throw new NotImplementedException();
            }

            return true;
        }

        public bool WriteField(string SetValue)
        {
            if (!Encrypted)
            {
                File.WriteAllText(Path, SetValue);
            }
            else
            {
                throw new NotImplementedException();
            }
            return true;
        }

        public string ObtainValue()
        {
            return Value;
        }
    }
}
