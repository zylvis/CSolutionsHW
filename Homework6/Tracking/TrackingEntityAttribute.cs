namespace Tracking
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class TrackingEntityAttribute : Attribute
    {
        public TrackingEntityAttribute()
        {

        }

    }
}