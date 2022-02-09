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

    [TrackingEntity]
    public class TestClass
    {
        [TrackingProperty(PropertyName = "Name")]
        public string FirstName { get; set; }

        [TrackingProperty(PropertyName = "Name")]
        public string LastName { get; set; }

        [TrackingProperty]
        public int Age { get; set; }
        public string Email { get; set; }

    }
}
