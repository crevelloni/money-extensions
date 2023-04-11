using System.Globalization;

namespace MoneyExtension;
public static class Money
{

    public static int ToCents(this decimal value)
    {

        if (value < 0)
            return 0;

        var valor = value.ToString("N2").Replace(",","").Replace(".", "");

        if (string.IsNullOrEmpty(valor))
            return 0;

        int.TryParse(valor, out var result);
        return result;

    }
   

}
