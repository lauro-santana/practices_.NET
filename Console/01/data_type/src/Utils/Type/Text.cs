namespace Utils.Type;

public static class Text
{
    public static Int64 AsInt(string text)
    {
        return Int64.TryParse(text, out Int64 result) ? result : 0;
    }

    public static UInt64 AsUInt(string text)
    {
        return UInt64.TryParse(text, out UInt64 result) ? result : 0;
    }
}