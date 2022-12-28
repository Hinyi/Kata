using System.Data;
using System;
using System.Linq;

namespace Kata;

public class NthSeries {
	
    public static string seriesSum (int n)
    {
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            result = result + (1 / (1.0 + i * 3.0));
        }

        return result.ToString("F").Replace(",",".");
    }
}