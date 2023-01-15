using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var s = iterable.ToList();
        var s_new = new List<T>();
        

        for (int i=0; i < s.Count; i++ )
        {
            if(i==0)
                s_new.Add(s[i]);
            if ((!s[i].Equals(s_new[s_new.Count - 1])) && i>0)
                s_new.Add(s[i]);
        }
       
        var result = s_new.ToList();
        return result;
    }
}