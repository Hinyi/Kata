using System.Data;
using System;


namespace Kata;

public class Kata
{
    public static int SquareSum(int[] numbers)
    {
        return numbers.Select(x => x * x).Sum();
    }
}