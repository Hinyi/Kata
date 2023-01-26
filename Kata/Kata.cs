using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        var arrayOfUnique = new List<int>();

        Dictionary<int, int> freq = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count(); i++)
        {
            if (freq.ContainsKey(arr[i]))
                freq[arr[i]]++;
            else freq[arr[i]] = 1;
            
            if (freq[arr[i]] <= x)
            {
                arrayOfUnique.Add(arr[i]);
            }
        }
        return arrayOfUnique.ToArray();
        
        // var result = new List<int>();
        // foreach(var item in arr) {
        //     if(result.Count(i => i == item) < x)
        //         result.Add(item);
        // }
    }
}