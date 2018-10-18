using System.IO;

namespace RapiTools.Fields
{
    public class Field
    {
        public string Name { get; private set; }
        public bool State { get; private set; }
        public string Path { get; private set; }
        protected string Value { get; set; }

        public Field(string fieldName)
        {
            Name = fieldName;

            if (!File.Exists($"{Name}.txt"))
                File.Create($"{ Name}.txt");

            Path = $"{ Name}.txt";
        }
    }
}
