using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Kata;

public class Kata
{
    public static string GoodVsEvil(string good, string evil)
    {
        var good_count = 0;
        var evil_count = 0;
        List<int> good_worth = new List<int>(){ 1, 2, 3, 3, 4, 10 };
        List<int> evil_worth = new List<int>(){ 1, 2, 2, 2, 3, 5, 10 };
        var good_army = good.Split(' ').ToArray();
        var evil_army = evil.Split(' ').ToArray();

        for (int i=0; i < evil_army.Length; i++)
        {
            evil_count += Int32.Parse(evil_army[i]) * evil_worth[i];
        }
        for (int i=0; i< good_army.Length; i++)
        {
            good_count += Int32.Parse(good_army[i]) * good_worth[i];
        }

        if (good_count > evil_count) return "Battle Result: Good triumphs over Evil";
        else if (evil_count > good_count) return "Battle Result: Evil eradicates all trace of Good";
        else return "Battle Result: No victor on this battle field";
    }
}