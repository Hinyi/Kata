using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;

public class Kata
{
    public static int[] CalculatePath(int[] path, string[] walk)
    {
        if ( walk.Length < 12 && walk.Length > 2)
        {
            for (int i = 0; i < walk.Length; i++)
            {
                switch (walk[i].ToCharArray()[0])
                {
                    case 'n':
                        path[1] += 1;
                        break;
                    case 's':
                        path[1] -= 1;
                        break;
                    case 'w':
                        path[0] -= 1;
                        break;
                    case 'e':
                        path[0] += 1;
                        break;
                }
            }
            return path;
        }

        return new[] { 11, 11 };
    }

    public static bool IsValidWalk(string[] walk)
    {
        //                      x - y
        int[] board = new[] { 0, 0 };
        var finalCord = CalculatePath(board, walk);
        if ((finalCord[0] == 0 && finalCord[1] == 0))
        {
            return true;
        }
        else return false;
    }
}