using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using static System.Math;

namespace Kata;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        var inputArr = input.ToCharArray();
        var counter = 0;
        foreach (var i in inputArr)
        {
            if (i == '(')
                counter++;
            if (i == ')')
                counter--;
            if(counter<0)
                return false;
                
        }
        return counter == 0;
    }
}
