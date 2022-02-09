
namespace Tracking
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class TrackingPropertyAttribute : Attribute
    {
        public string? PropertyName { get; set; }

    }
}
