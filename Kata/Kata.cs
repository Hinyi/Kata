using System.Data;
using System;


namespace Kata;

public class Kata
{
    public static bool Solution(string str, string ending)
    {
        var size = ending.Length;
        var arr = str.ToArray().Reverse().ToArray();
        var arr_end = ending.ToArray().Reverse().ToArray();

        bool val = false;

        if (size > str.Length) return false;
        if (size == 0) return true;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] == arr_end[i]) val = true;
            else return false;
        }
        

        return val;
    }
}