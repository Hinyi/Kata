using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public double trib(double[] signature, int n)
    {
        if (n == 2)
            return signature[2];
        else if (n == 1)
            return signature[1];
        else if (n == 0)
            return signature[0];
        else return trib(signature, n - 1) + trib(signature, n - 2) + trib(signature, n - 3);
    }

    public double[] Tribonacci(double[] s, int n)
    {
        double[] result = new double[n];
        Array.Copy(s,result, Math.Min(3,n));
        for (int i = 3; i < n; i++)
        {
            //result[i] = trib(signature,i);
            result[i] = result[i - 1] + result[i - 2] + result[i - 3];
        }

        return n==0 ? new double[]{} : result;
    }
}