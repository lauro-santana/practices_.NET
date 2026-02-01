namespace Utils.Type;

public static class Collection
{
    public static List<T> AsList<T>(T[] values)
    {
        return values.ToList();
    }
}