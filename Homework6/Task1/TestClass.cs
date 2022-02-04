using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tracking;

namespace Task1
{
   
  [JsonObject(MemberSerialization.OptIn)]
  [Serializable]
  
   [TrackingEntity]
    public class TestClass
    {
        [JsonIgnore]
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

    }
}
