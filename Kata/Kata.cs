using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public static int MaxSequence(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        
        int currentMax = arr[0], max = 0;
 
        for (int i = 0; i < arr.Length; i++) {
            max +=  arr[i];
            if (max < 0)
                max = 0;
 
            else if (currentMax < max)
                currentMax = max;
        }
        return currentMax;
    }
}