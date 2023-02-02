using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    private static List<long> numberToDigitList(long n)
    {
        List<long> digits = new List<long>();
        var charArray = n.ToString().ToArray();
        foreach (var item in charArray)
        {
            digits.Add(long.Parse(item.ToString()));
        }

        return digits;
    }
    public static long NextBiggerNumber(long n)
    {
        var size = n.ToString().ToArray().Length;
        List<long> digArr = numberToDigitList(n);

        if (size == 1)
            return n;

        int i = 0;
        for (i = size-1; i > 0; i--)
        {
            if (digArr[i] > digArr[i - 1])
                break;
        }

        if (i != 0)
        {
            for (int j = size-1; j >= i; j--)
            {
                if (digArr[i - 1] < digArr[j])
                {
                    (digArr[j], digArr[i - 1]) = (digArr[i - 1], digArr[j]);
                    break;
                }
            }
        }
        else
        {
            return -1;
        }

        long[] res = new long[size];
        var ind = size - 1;
        for (int j = 0; j < i; j++)
            res[j] = digArr[j];
        for (int j = i; j < res.Length; j++)
            res[j] = digArr[ind--];

        string str = string.Join("", res);
        var result = Convert.ToInt64(str);
        return result;
        
        // public static long NextBiggerNumber(long n)
        // {        
        //     String str = GetNumbers(n);
        //     for (long i = n+1; i <= long.Parse(str); i++)
        //     {
        //         if(GetNumbers(n)==GetNumbers(i))
        //         {
        //             return i;
        //         }
        //     }
        //     return -1;        
        // }
        // public static string GetNumbers(long number)
        // {
        //     return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
        // }
    }
}