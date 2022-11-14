namespace Wfl.Domain.Entities
{
    // VOs don't have Ids - the point is lack of reusability in database
    internal class SampleValueObject
    {
        string SampleProperty { get; set; }
    }
}
