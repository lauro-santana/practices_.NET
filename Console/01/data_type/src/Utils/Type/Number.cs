using System.Numerics;

namespace Utils.Type;

/// <summary>
/// Provides helper methods for converting numeric values into string or decimal representations.
/// </summary>
public class Number
{
    /// <summary>
    /// Converts a numeric value to its string representation.
    /// </summary>
    /// <typeparam name="T">
    /// The numeric type that implements <see cref="INumber{T}"/>.
    /// </typeparam>
    /// <param name="number">
    /// The numeric value to convert.
    /// </param>
    /// <returns>
    /// A string representation of the numeric value, or <c>null</c> if the conversion fails.
    /// </returns>
    public static string? AsString<T>(T number)
        where T : INumber<T>
    {
        return number.ToString();
    }

    /// <summary>
    /// Executes a function that returns a string representation of a value.
    /// </summary>
    /// <param name="function">
    /// A function that returns a string.
    /// </param>
    /// <returns>
    /// The string returned by the provided function, or <c>null</c>.
    /// </returns>
    public static string? AsString(Func<string?> function)
    {
        return function();
    }

    /// <summary>
    /// Combines an integer value and a fractional value into a decimal number.
    /// </summary>
    /// <param name="value">
    /// The integer part of the number.
    /// </param>
    /// <param name="fractionalValue">
    /// The fractional part of the number, expressed as hundredths (e.g., 25 represents 0.25).
    /// </param>
    /// <returns>
    /// A <see cref="decimal"/> composed of the integer and fractional parts.
    /// </returns>
    /// <example>
    /// <code>
    /// var result = Number.AsDecimal(10, 25); // 10.25
    /// </code>
    /// </example>
    public static decimal AsDecimal(int value, int fractionalValue) =>
        value + fractionalValue * 0.01M;
}
