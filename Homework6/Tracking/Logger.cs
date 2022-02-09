﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Dictionary<string, string> objTracked = new Dictionary<string, string>();
            string propertyName;

            if (obj.GetType().GetCustomAttribute<TrackingEntityAttribute>() != null)
            {
                foreach (var propertyInfo in obj.GetType().GetProperties()
              .Where(p => p.GetCustomAttribute<TrackingPropertyAttribute>() != null))
                {
                    propertyName = propertyInfo.GetCustomAttribute<TrackingPropertyAttribute>().PropertyName;

                    if (propertyName == null)
                    {
                        propertyName = propertyInfo.Name;
                    }

                    objTracked.Add(propertyName, propertyInfo.GetValue(obj).ToString());
                }

                string fileName = $"{FileName}.json";
                string jsonString = JsonSerializer.Serialize(objTracked);
                File.WriteAllText(fileName, jsonString);
            }

        }

    }
}
