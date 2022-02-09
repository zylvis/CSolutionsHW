using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class TrackingPropertyAttribute : Attribute
    {
        public string? PropertyName { get; set; }
        public TrackingPropertyAttribute()
        {

        }
    }
}
