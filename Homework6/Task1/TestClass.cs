
using Tracking;

namespace Task1
{

    [TrackingEntity]
    public class TestClass
    {
        [TrackingProperty(PropertyName = "Field")]
        public int _number;

        [TrackingProperty]
        public string FirstName { get; set; }

        [TrackingProperty(PropertyName = "Name")]
        public string LastName { get; set; }

        [TrackingProperty]
        public int Age { get; set; }
        public string Email { get; set; }


    }
}
