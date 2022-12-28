using System.Data;
using System;
using System.Linq;

namespace Kata;

public static class Kata {
    public static string GetMiddle(string s)
    {
        string result = string.Empty;
        var size = s.Length;
        var a = s.ToArray();
        if (size % 2 == 0)
        {
            result = a[size/2-1].ToString() + a[size/2].ToString();
        }
        else
        {
            result = a[size/2].ToString();
        }
        return result;
        
        // return string.IsNullOrEmpty(s)
        //     ? s
        //     : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
    }
}