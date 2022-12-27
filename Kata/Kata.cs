using System.Data;
using System;


namespace Kata;

public class Printer 
{
    public static string PrinterError(String s)
    {
        var arr_count = s.Length;
        var arr = string.Concat(s).Where(x => x > 'm').Count();
        return $"{arr}/{arr_count}";
        
        // return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }
}