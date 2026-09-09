namespace TooManySugar;

using System.Collections;
public static class Extensions
{
    public static double Pow(this double bas, double pow)
    {
        return Math.Pow(bas, pow);
    }
    public static double Root(this double roo, double num)
    {
        return Math.Pow(num, 1.0 / roo);
    }
    public static bool InRange(this double val, double left, double right)
    {
        return (val >= left && val <= right);
    }
    public static double Per(this double val)
    {
        return val/100.0;
    }
    public static TimeSpan Sec(this int val) => TimeSpan.FromSeconds(val);
    public static TimeSpan Min(this int val) => TimeSpan.FromMinutes(val);
    public static TimeSpan Hour(this int val) => TimeSpan.FromHours(val);
    public static TimeSpan Day(this int val) => TimeSpan.FromDays(val);
    public static int RandDam(this int max)
    {
        return Random.Shared.Next(max);
    }
    public static double Reserve(this double inp, double reserve)
    {
        if (double.IsNaN(inp))
        {
            return reserve;
        }
        else
        {
            return inp;
        }
    }
    public static string Dubl(this string str, int times)
    {
        if (string.IsNullOrEmpty(str) || times <= 0) return String.Empty;
        var result = new System.Text.StringBuilder(str.Length * times);
        for (int i = 0; i < times; i++)
        {
            result.Append(str);
        }
        return result.ToString();
    }
    public static int Count(this string inp, string search)
    {
        if (string.IsNullOrEmpty(inp) || string.IsNullOrEmpty(search)) return 0;

        int count = 0;
        int index = 0;

        while ((index = inp.IndexOf(search, index, StringComparison.Ordinal)) != -1)
        {
            count++;
            index += search.Length;
        }
        return count;
    }
    public static string Reserve(this string inp, string reserve)
    {
        if (string.IsNullOrEmpty(inp))
        {
            return reserve;
        }
        else
        {
            return inp;
        }
    }
    public static string Invert(this string str)
    {
        if (string.IsNullOrEmpty(str)) return String.Empty;
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    public static void Times(this Action action, int times)
    {
        for (int i = 0; i < times; i++) action();
    }
    public static void Times(this Action<int> action, int times)
    {
        for (int i = 0; i < times; i++) action(i);
    }

    public static string Join<T>(this IEnumerable<T> coll, string separ = " ")
    {
        return string.Join(separ, coll);
    }
    public static void For<T>(this IEnumerable<T> col, Action<T> action)
    {
        foreach (var item in col) action(item);
    }
    public static T Choice<T>(this IReadOnlyList<T> lst)
    {
        if (lst == null || lst.Count == 0) return default!;
        return lst[Random.Shared.Next(lst.Count)];
    }
    public static string ToStr<T>(this IEnumerable<T> coll)
    {
        return $"[{coll.Join(", ")}]";
    }
    public static bool ToBool(this int val) => val != 0;
    public static int  ToInt(this bool val) => val ? 1 : 0;
}
public static class Core
{
    public static void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
    public static List<int> GenArr(int left, int right)
    {
        List<int> result = new List<int>();
        for (int i = left; i <= right; i++)
        {
            result.Add(i);
        }
        return result;
    }
}
