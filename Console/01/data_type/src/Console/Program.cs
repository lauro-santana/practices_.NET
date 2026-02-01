using System.Globalization;
using Utils.Type;

class Program
{
    const string EMPTY = "";
    static void Main(string[] args)
    {
        int i = 1;
        long l = 2;
        byte b = 3;
        decimal d = 3333.2244M;

        Console.WriteLine(Number.AsString(i));
        Console.WriteLine(Number.AsString(l));
        Console.WriteLine(Number.AsString(b));
        Console.WriteLine(Number.AsString(d));
        Console.WriteLine(d.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        d += 20;
        Console.WriteLine(d.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        d += 0.20M;
        Console.WriteLine(d.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        decimal dd = i + (decimal)20/100;
        Console.WriteLine(dd.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

        Console.WriteLine(Number.AsString(() => dd.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))));

        Console.WriteLine(Number.AsDecimal(i, 50).ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

    }
}