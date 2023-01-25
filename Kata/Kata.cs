using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        var result2 = new List<int>();
        var b2 = b.ToList();

        if (b.Length == 0)
        {
            return a;
        }

        foreach (var item in a)
        {
            var temp = b2.Where(x => x == item).ToList();
            if(temp.Count==0)
            {
                result2.Add(item);
            }
        }
        
        return result2.ToArray();
        
        //return a.Where(n => !b.Contains(n)).ToArray();
    }
}