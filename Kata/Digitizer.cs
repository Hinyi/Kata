namespace Kata;

public class Digitizer
{
    public static long[] Digitize(long n)
    {
        /*var number = n.ToString();
        long[] arr = number.Select(digit => long.Parse(digit.ToString())).ToArray();
        long[] parse = new long[arr.Count()];
        
        for (int i = 0; i < arr.Count(); i++)
        {
            parse[i] = arr[arr.Count()-i-1];
        }
        return parse;*/
        
        return n.ToString()
            .Reverse()
            .Select(t => Convert.ToInt64(t.ToString()))
            .ToArray();
    }
}