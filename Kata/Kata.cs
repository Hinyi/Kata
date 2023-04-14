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
    static string cipher(char letter)
    {
        if(letter >= 'A' && letter <= 'Z')
        {
            var result = Convert.ToChar((letter - 'A' + 13) % 26 + 'A');
            return result.ToString();
        }
        if (letter >= 'a' && letter <= 'z')
        {
            var result = Convert.ToChar((letter - 'a' + 13) % 26 + 'a');
            return result.ToString();
        }

        return letter.ToString();
    }
    public static string Rot13(string message)
    {
        var result = string.Empty;
        var messageArr = message.ToCharArray();
        foreach (var i in messageArr)
        {
            result += cipher(i);
        }

        return result;
    }
}