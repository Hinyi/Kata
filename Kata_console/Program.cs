// See https://aka.ms/new-console-template for more information

var s = "sokos";

var palindrom = new string(s.ToArray().Reverse().ToArray());

var AreEqual = s.Equals(palindrom);

Console.WriteLine($"{AreEqual}");


static double getMedian(double[] arr)
{
    var sortedArr = arr.Order().ToList();
    
    if (sortedArr.Count % 2 == 0)
        return (sortedArr[sortedArr.Count() / 2 - 1] + sortedArr[sortedArr.Count() / 2]) / 2;
    else
        return sortedArr[sortedArr.Count()/2];
}


static List<string> getMedianAndAverage(double[] arr)
{
    var result = new List<string>();
    var newArr = arr.Where(x => x % 2 == 0).ToArray();
    
    if (newArr.Length ==0)
        return new List<string>(){"","","nie da sie"};
    
    var median = getMedian(newArr);
    result.Add(median.ToString());
    
    var avg = newArr.Sum()/newArr.Length;
    result.Add(avg.ToString());
    
    var biggerNumber = string.Empty;
    if (median > avg)
        biggerNumber = "Mediana jest wieksza";
    else if (median < avg)
        biggerNumber = "Srednia jest wieksza";
    // if (median.Equals(avg))
    else
        biggerNumber = "wartosci sa równe";
    result.Add(biggerNumber);

    return result;
}

//[1,3,5,7] [1,3,5,7,9]
var test1 = new double[]{1,3,5,7};
var test2 = new double[]{1,3,5,7,9};
var test3 = new double[]{1,3,5,7,9,11,13,15,17};
var test4 = new double[]{};
var test5 = new double[]{0};
var test6 = new double[]{-1,2};


var result = getMedianAndAverage(test1);
var result1 = getMedianAndAverage(test2);
var result2 = getMedianAndAverage(test3);
var result3 = getMedianAndAverage(test4);
var result4 = getMedianAndAverage(test5);
var result5 = getMedianAndAverage(test6);
Console.WriteLine($"mediana {result[0]}, srednia {result[1]} i to ostatnie {result[2]}");
Console.WriteLine($"mediana {result1[0]}, srednia {result1[1]} i to ostatnie {result1[2]}");
Console.WriteLine($"mediana {result2[0]}, srednia {result2[1]} i to ostatnie {result2[2]}");
Console.WriteLine($"mediana {result3[0]}, srednia {result3[1]} i to ostatnie {result3[2]}");
Console.WriteLine($"mediana {result4[0]}, srednia {result4[1]} i to ostatnie {result4[2]}");
Console.WriteLine($"mediana {result5[0]}, srednia {result5[1]} i to ostatnie {result5[2]}");

