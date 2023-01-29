using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Matrix
{

    static int recursion(int[][] arr)
    {
        if (arr.Length == 1)
        {
            return arr[0][0];
        }
        if (arr.Length == 2)
        {
            return arr[0][0]*arr[1][1] - arr[1][0]*arr[0][1];
        }

        var det = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            var a = arr;

            List<List<int>> minor = new List<List<int>>();
            int size_row = 0;

            for (int j = 0; j < a.Length; j++)
            {
                int size_column = 0;
                List<int> Child=new List<int>();
                for (int k = 0; k < a.Length; k++)
                {
                    if(j!=i && k!=0)
                    {
                        Child.Add(a[size_row][size_column]);
                    }
                    
                    size_column++;
                }
                if(Child.Count>1){minor.Add(Child);}
                
                size_row++;
            }
            int[][] arrays = minor.Select(a => a.ToArray()).ToArray();
            if(i%2==0)
            {
                det += arr[i][0] * recursion(arrays);
            }
            else
            {
                det -= arr[i][0] * recursion(arrays);
            }
        }
        return det;
    }
    public static int Determinant(int[][] matrix)
    {
        var result = recursion(matrix);
        return result;
    }
}