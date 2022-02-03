using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tracking
{
    public class Logger
    {
        public string FileName { get; set; }
        public Logger(string fileName)
        {
            FileName = fileName;
        }

        public void Track(object obj)
        {
            string fileName = $"{FileName}.json";
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, jsonString);
        }

    }
}
