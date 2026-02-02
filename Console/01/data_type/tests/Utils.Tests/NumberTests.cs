using System.ComponentModel;
using System.Globalization;

namespace Utils.Tests;

public class NumberTests
{
    [Fact]
    public void AsDecimalFromInt()
    {
        //Arrage
        int value = 20;
        int fractionalValue = 50;

        //Act
        decimal result = Number.AsDecimal(value, fractionalValue);

        //Assert
        Assert.Equal(20.50M, result);
    }

    [Theory]
    [InlineData(20, 20, 20.20)]
    [InlineData(30, 20, 30.20)]
    [InlineData(0, 20, 0.20)]
    [InlineData(1, 0, 1.00)]
    public void AsDecimalFromIntCases(int value, int fractionalValue, decimal expected)
    {
       
        //Act
        decimal result = Number.AsDecimal(value, fractionalValue);

        //Assert
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> NumberAsStringCases =>
    [
        new object[] { 20, "20" },
        new object[] { 20.20m, "20.20" },
        new object[] { 0, "0" }
    ];

    [Theory]
    [MemberData(nameof(NumberAsStringCases))]
    public void NumberAsString(dynamic value, string expected)
    {
       
        //Act
        string? result = Number.AsString(value);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(20, "R$ 20,00")]
    [InlineData(20.20, "R$ 20,20")]
    [InlineData(3000.99, "R$ 3.000,99")]
    [InlineData(1234567.344, "R$ 1.234.567,34")]
    [InlineData(-12.33, "-R$ 12,33")]
    public void DecimalAsString(decimal value, string expected)
    {
       
        //Act
        string? result = Number.AsString(() => value.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AsDecimalError()
    {
        //Arrage
        int value = 20;
        int fractionalValue = 999;

        //Assert
        Exception result = Assert.Throws<ArgumentOutOfRangeException>(() => Number.AsDecimal(value, fractionalValue));
    }
}