namespace DelegatesAndEvents;

public static class CollectionExtensions
{
    public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
    {
        if (collection == null || !collection.Any())
            throw new ArgumentException("Collection is null or empty.");

        return collection.OrderByDescending(convertToNumber).FirstOrDefault();
    }
}