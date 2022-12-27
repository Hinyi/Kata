using System.Data;
using System;


namespace Kata;

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        int[] arr = new[] { a, b, c };
        if (a > 0 || b > 0 || c > 0)
        {
            foreach (var i in arr)
            {
                if (!(arr.Sum() - 2 * i > 0))
                {
                    return false;
                }
            }
        }
        return true;
    }
}