using System.Data;
using System;


namespace Kata;

public class Kata
{
    public static string Disemvowel(string str)
    {
        string vowels = "aeiouAEIOU";
        str = new string (str.Where(x => !vowels.Contains(x)).ToArray());
        return str;
    }
}