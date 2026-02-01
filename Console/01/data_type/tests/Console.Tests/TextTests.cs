public class StringTests
{
    [Theory]
    [InlineData("2", 2)]
    [InlineData("abc", 0)]
    [InlineData("", 0)]
    [InlineData("-3", -3)]
    [InlineData("03", 3)]
    [InlineData("4233.0038u32", 0)]
    public void AsInt(string text, Int64 expected)
    {
        //Act
        Int64 result = Text.AsInt(text);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("2", 2)]
    [InlineData("abc", 0)]
    [InlineData("", 0)]
    [InlineData("-3", 0)]
    [InlineData("03", 3)]
    [InlineData("4233.0038u32", 0)]
    public void AsUInt(string text, UInt64 expected)
    {
        //Act
        UInt64 result = Text.AsUInt(text);

        //Assert
        Assert.Equal(expected, result);
    }
}