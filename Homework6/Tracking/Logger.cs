using System.Reflection;
using System.Text.Json;


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
            string fieldName;
            string propertyName;

            if (obj.GetType().GetCustomAttribute<TrackingEntityAttribute>() != null)
            {
                foreach (var fieldInfo in obj.GetType().GetFields()
              .Where(p => p.GetCustomAttribute<TrackingPropertyAttribute>() != null))
                {
                    fieldName = fieldInfo.GetCustomAttribute<TrackingPropertyAttribute>().PropertyName;

                    if (fieldName == null)
                    {
                        fieldName = fieldInfo.Name;
                    }

                    objTracked.Add(fieldName, fieldInfo.GetValue(obj).ToString());
                }

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
