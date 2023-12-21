namespace MaisonEauOr.Extensions;

public static class EntityCollectionConverter
{
    public static string EnumsToString<T>(this ICollection<T> enums) where T : struct, Enum
    {
        return string.Join(",", enums.ToList().ConvertAll<string>(x => x.ToString()));
    }

    public static ICollection<T> StringToEnums<T>(this string values) where T : struct, Enum
    {
        return values.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList().Select(Enum.Parse<T>).ToList();
    }

    public static string GuidsToString(this ICollection<Guid> guids)
    {
        return string.Join(",", guids.ToList().ConvertAll<string>(x => x.ToString()));
    }

    public static ICollection<Guid> StringToGuids(this string values)
    {
        return values.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList().Select(Guid.Parse).ToList();
    }
}