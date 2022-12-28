using System.Data;
using System;


namespace Kata;

public static class Kata {
    public static int Number(List<int[]> peopleListInOut)
    {
        var result = 0;
        foreach (var i in peopleListInOut)
        {
            result += i[0] - i[1];
        }
        return result;
    }
}