using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        var listOfString = string.Concat(s.ToLower()
            .GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key)).ToArray();
        if (s.Length == 0 || listOfString.Length == 0)
        {
            return string.Empty;
        }
        var position = s.ToLower().IndexOf(listOfString[0]);

        return s.ToArray().GetValue(position).ToString();
        
        // return s.GroupBy(char.ToLower)
        //     .Where(gr => gr.Count() == 1)
        //     .Select(x => x.First().ToString())
        //     .DefaultIfEmpty("")
        //     .First();
    }
}