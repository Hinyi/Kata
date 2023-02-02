using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using static System.Math;

namespace Kata;

public class Kata
{
    private static List<List<int>> arrToList(int[][] arr)
    {
        int x = 1,y = 1;
        List<List<int>> list = new List<List<int>>();
        var tak = arr[x][x];
        foreach (int[] item in arr)
        {
            foreach (int i in item)
            {
                list[x][y] = 1;
                list[x][y] = i;
                y++;
            }
            x++;
        }

        return list;
    }
    public static int[] Snail(int[][] array)
    {
        if (array[0].Length == 0)
            return new int[] { };
        int x=0, y = 0;
        var size = array.Length;
        int n = int.Parse(Pow(size,2).ToString());
        int k = 0;
        var arr = array;//arrToList(array);
        List<int> result = new List<int>();
        while (k < n)
        {
            for (int i = x; i < x+size; i++)
            {
                result.Add(arr[y][i]);
                k++;
            }
            size--;
            y++;
            for (int i = y; i < y+size; i++)
            {
                result.Add(arr[i][x+size]);
                // result[k] = arr[x][y];
                k++;
            }
            for (int i = x + size -1; i >= x; i--)
            {
                result.Add(arr[y+size-1][i]);
                k++;
            }

            size--;
            
            for (int i = y+size-1; i >= y; i--)
            {
                result.Add(arr[i][x]);
                k++;
            }

            x++;
        }

        int[] output = result.ToArray();
        return output;
    }
}
