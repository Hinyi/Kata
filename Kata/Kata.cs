using System.Data;
using System;


namespace Kata;

public class Kata
{
    public static int FindShort(string s)
    {
        var result = s.Split(" ").ToList();
        var arr = result.OrderBy(x => x.Length).ToList();
        return arr[0].Length;
        
        // return s.Split(' ').Min(x => x.Length);
    }
}